using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;

namespace CitomMobileMonitor.classes
{
    class DatabaseHandler
    {
        private string path;
        private string password;
        private string conn_string;

        public DatabaseHandler()
        {
            this.path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\db.sdf";
            this.password = "password";
            this.conn_string = "Data Source='" + this.path + "'; LCID=1033; Password=\"" + this.password + "\"; Encrypt = FALSE;";
        }

        public void checkAndCreateDBAvailability()
        {
            //check individual path elements for existence
            //if exist return true
            if (File.Exists(this.path) == true)
            {
                //do nothing but return
                return;
            }
            //else create it!!!!
            else
            {
                //create db
                //System.IO.File.Delete(this.path);
                SqlCeEngine engine = new SqlCeEngine(this.conn_string);
                engine.CreateDatabase();

                string sql_stmt;
                //create the tables
                //violations
                sql_stmt = "CREATE TABLE violations " + 
                           "(   " +
                           "    violation_id int," +
                           "    violation nvarchar(20)," +
                           "    description nvarchar(100)," +
                           "    price money," +
                           "    last_modified datetime" + 
                           ")   ";

                SqlCeConnection conn = new SqlCeConnection(this.conn_string);
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql_stmt;
                cmd.ExecuteNonQuery();

                //issuance
                sql_stmt = "CREATE TABLE issuances " +
                           "(   " +
                           "    issuance_date datetime," +
                           "    license_no nvarchar(20)," +
                           "    violation_id int," +
                           "    price money," +
                           "    officer_id int," +
                           "    issuance_status int" +
                           ")   ";

                cmd.CommandText = sql_stmt;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        //add violation
        public bool addViolation(int id, string violation, string desc, decimal price, DateTime last_mod)
        {
            string sql_stmt;
            bool result = false;
            sql_stmt = "INSERT INTO violations " +
                       "    (violation_id,violation,description,price,last_modified) " + 
                       "VALUES " +
                       "    (@id, @violation, @desc, @price, @last_mod)";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();

            try
            {
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql_stmt;

                cmd.Parameters["id"].SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters["id"].Value = id;

                cmd.Parameters["violation"].SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters["violation"].Value = violation;

                cmd.Parameters["desc"].SqlDbType = System.Data.SqlDbType.NText;
                cmd.Parameters["desc"].Value = desc;

                cmd.Parameters["price"].SqlDbType = System.Data.SqlDbType.Money;
                cmd.Parameters["price"].Value = price;

                cmd.Parameters["last_mod"].SqlDbType = System.Data.SqlDbType.DateTime;
                cmd.Parameters["last_mod"].Value = last_mod; ;

                result = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                result = false;
            }
            conn.Close();
            return result;
        }

        //get violations
        public List<Violation> getAllViolations()
        {   
            string sql_stmt;
            sql_stmt =  "SELECT " + 
                        "   violation_id,violation,description,price,last_modified " + 
                        "FROM " + 
                        "   violations";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql_stmt;
            SqlCeResultSet result = cmd.ExecuteResultSet(ResultSetOptions.Insensitive);

            List<Violation> violations = new List<Violation>();

            while (result.Read() != null)
            {
                Violation violation = new Violation();
                violation.ViolationId = result.GetInt32(0);
                violation.ViolationName = result.GetString(1);
                violation.Description = result.GetString(2);
                violation.Price = result.GetDecimal(3);
                violation.LastModified = result.GetDateTime(4);

                violations.Add(violation);
            }

            result.Close();
            conn.Close();

            return violations;
        }

        //get one violation
        public Violation getViolation(int id)
        {
            string sql_stmt;
            sql_stmt = "SELECT " +
                        "   violation_id,violation,description,price,last_modified " +
                        "FROM " +
                        "   violations " + 
                        "WHERE " + 
                        "   violation_id = @id";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql_stmt;
            SqlCeResultSet result = cmd.ExecuteResultSet(ResultSetOptions.Insensitive);

            Violation violation = null;

            while (result.Read() != null)
            {
                violation = new Violation();
                violation.ViolationId = result.GetInt32(0);
                violation.ViolationName = result.GetString(1);
                violation.Description = result.GetString(2);
                violation.Price = result.GetDecimal(3);
                violation.LastModified = result.GetDateTime(4);

                break;
            }

            result.Close();
            conn.Close();

            return violation;
        }

        //get last_modified_violation
        public DateTime getLastModifiedDate()
        {
            string sql_stmt;
            sql_stmt = "SELECT " +
                        "   last_modified " +
                        "FROM " +
                        "   violations " +
                        "ORDER BY " +
                        "   last_modified DESC";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql_stmt;
            SqlCeResultSet result = cmd.ExecuteResultSet(ResultSetOptions.Insensitive);

            DateTime retval = new DateTime();

            while (result.Read() != null)
            {
                retval = result.GetDateTime(0);
                break;
            }

            result.Close();
            conn.Close();

            return retval;
        }

        //delete violation
        public bool deleteViolation(int id)
        {
            string sql_stmt;
            bool result = false;
            sql_stmt = "DELETE FROM violations " +
                       "WHERE " +
                       "    violation_id = @id";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();

            try
            {
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql_stmt;

                cmd.Parameters["id"].SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters["id"].Value = id;

                result = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                result = false;
            }
            conn.Close();
            return result;
        }

        //edit violation
        public bool editViolation(int id, string violation, string desc, decimal price, DateTime last_mod)
        {
            string sql_stmt;
            bool result = false;
            sql_stmt = "UPDATE violations " +
                       "    (violation_id,violation,description,price,last_modified) " +
                       "SET " +
                       "    violation = @violation, " + 
                       "    description = @desc, " + 
                       "    price = @price, " + 
                       "    last_modified = @last_mod " +
                       "WHERE " + 
                       "    violation_id = @id";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();

            try
            {
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql_stmt;

                cmd.Parameters["id"].SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters["id"].Value = id;

                cmd.Parameters["violation"].SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters["violation"].Value = violation;

                cmd.Parameters["desc"].SqlDbType = System.Data.SqlDbType.NText;
                cmd.Parameters["desc"].Value = desc;

                cmd.Parameters["price"].SqlDbType = System.Data.SqlDbType.Money;
                cmd.Parameters["price"].Value = price;

                cmd.Parameters["last_mod"].SqlDbType = System.Data.SqlDbType.DateTime;
                cmd.Parameters["last_mod"].Value = last_mod; ;

                result = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                result = false;
            }
            conn.Close();
            return result;
        }

        //add issuance
        public bool addIssuance(DateTime issuance_date, string license_no, 
                                int violation_id, decimal price, int officer_id,
                                int issuance_status)
        {
            string sql_stmt;
            bool result = false;

            /**
            sql_stmt = "CREATE TABLE issuances " +
                           "(   " +
                           "    issuance_date datetime," +
                           "    license_no nvarchar(20)," +
                           "    violation_id int," +
                           "    price money," +
                           "    officer_id int," +
                           "    issuance_status int" +
                           ")   ";
            **/

            sql_stmt = "INSERT INTO issuances " +
                       "    (issuance_date,license_no,violation_id,price,officer_id,issuance_status) " +
                       "VALUES " +
                       "    (@id, @violation, @desc, @price, @last_mod)";

            SqlCeConnection conn = new SqlCeConnection(this.conn_string);
            conn.Open();

            try
            {
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql_stmt;

                cmd.Parameters["issuance_date"].SqlDbType = System.Data.SqlDbType.DateTime;
                cmd.Parameters["issuance_date"].Value = issuance_date;

                cmd.Parameters["license_no"].SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters["license_no"].Value = license_no;

                cmd.Parameters["violation_id"].SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters["violation_id"].Value = violation_id;

                cmd.Parameters["price"].SqlDbType = System.Data.SqlDbType.Money;
                cmd.Parameters["price"].Value = price;
                
                //cmd.Parameters["officer_id"].SqlDbType = System.Data.SqlDbType.Int;
                //cmd.Parameters["officer_id"].Value = last_mod;

                cmd.Parameters["issuance_status"].SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters["issuance_status"].Value = issuance_status;

                result = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                result = false;
            }
            conn.Close();
            return result;
        }
        //get issuance


        //delete issuance
    }
}
