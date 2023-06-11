using commutersLinersDAL;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace commuterLinersDAL
{
    public class DBUpdateSeats : ConnectionLine
    {
        public static DataTable btn1UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn1UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn2UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn2UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn3UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn3UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn4UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn4UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn5UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn5UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn6UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn6UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn7UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn7UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn8UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn8UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn9UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn9UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn10UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn10UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn11UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn11UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn12UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn12UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn13UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn13UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn14UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn14UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn15UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn15UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn16UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn16UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn17UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn17UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn18UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn18UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn19UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn19UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn20UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn20UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn21UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn21UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn22UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn22UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn23UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn23UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn24UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn24UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn25UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn25UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn26UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn26UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn27UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn27UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn28UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn28UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn29UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn29UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn30UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn30UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn31UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn31UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn32UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn32UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn33UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn33UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn34UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn34UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn35UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn35UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn36UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn36UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn37UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn37UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn38UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn38UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn39UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn39UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn40UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn40UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn41UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn41UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn42UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn42UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn43UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn43UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn44UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn44UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn45UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn45UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn46UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn46UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn47UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn47UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn48UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn48UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn49UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn49UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn50UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn50UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn51UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn51UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn52UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn52UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn53UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn53UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn54UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn54UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable btn55UpdateSeats(int is_selected, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("btn55UpdateSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }
    }
}
