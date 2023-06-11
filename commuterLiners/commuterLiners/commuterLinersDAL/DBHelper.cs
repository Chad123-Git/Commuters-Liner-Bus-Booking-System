using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace commutersLinersDAL
{
    public class DBHelper : ConnectionLine
    {
        public static DataTable ValidateUser(string username, string password)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("ValidateUser");
                db.AddInParameter(dbCommand, "@Username", DbType.String, username);
                db.AddInParameter(dbCommand, "@Password", DbType.String, password);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable ValidateBus(string Travel_Date, string To)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("ValidateBus");
                db.AddInParameter(dbCommand, "@Travel_Date", DbType.String, Travel_Date);
                db.AddInParameter(dbCommand, "@To", DbType.String, To);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }

        }

        public static DataTable InsertBusDetails(string Travel_Date, string To)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetBusDetails");
                db.AddInParameter(dbCommand, "@Travel_Date", DbType.String, Travel_Date);
                db.AddInParameter(dbCommand, "@To", DbType.String, To);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable GetBusDetails2(string cellValue)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetBusDetails2");
                db.AddInParameter(dbCommand, "@cellValue", DbType.String, cellValue);
                DataTable GetBusDetails2 = new DataTable();
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    GetBusDetails2.Load(dr);
                }
                return GetBusDetails2;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable InsertTicketNumber()
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("InsertTicketNumber");
                DataTable InsertTicketNumber = new DataTable();
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    InsertTicketNumber.Load(dr);
                }
                return InsertTicketNumber;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetTicketNumber(string cellValue)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetTicketNumber");
                db.AddInParameter(dbCommand, "@cellValue", DbType.String, cellValue);
                DataTable GetTicketNumber = new DataTable();
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    GetTicketNumber.Load(dr);
                }
                return GetTicketNumber;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetFares()
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetFares");
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable InsertBusReceiptDiscount(double Total, double PersonCount_Discount)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("InsertBusReceiptDiscount");
                db.AddInParameter(dbCommand, "@PersonCount_Discount", DbType.Int64, PersonCount_Discount);
                db.AddInParameter(dbCommand, "@Total", DbType.Int64, Total);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable InsertBusReceiptRegular(double Total, double PersonCount_Regular)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("InsertBusReceiptRegular");
                db.AddInParameter(dbCommand, "@PersonCount_Regular", DbType.Int64, PersonCount_Regular);
                db.AddInParameter(dbCommand, "@Total", DbType.Int64, Total);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable UpdatePassengerSeats(int is_selected, string seat_number, string bus_number)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("UpdatePassengerSeats");
                db.AddInParameter(dbCommand, "@is_selected", DbType.Int64, is_selected);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static DataTable GetSelectedStatus(string cellValue)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetSelectedStatus");
                db.AddInParameter(dbCommand, "@cellValue", DbType.String, cellValue);
                DataSet dataSet = db.ExecuteDataSet(dbCommand);
                if (dataSet.Tables.Count > 0)
                {
                    DataTable dt = dataSet.Tables[0];
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable InsertCellValue(string CellValue)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("InsertCellValue");
                db.AddInParameter(dbCommand, "@CellValue", DbType.String, CellValue);
                DataTable GetBusDetails2 = new DataTable();
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    GetBusDetails2.Load(dr);
                }
                return GetBusDetails2;
            }
            catch
            {
                return null;
            }
        }

        public static string GetLastCellValue()
        {
            string lastCellValue = string.Empty;
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetLastCellValue");

                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    if (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                        {
                            lastCellValue = dr.GetString(0);
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return lastCellValue;
        }

        public static DataTable UpdateAvailableSeats(string cellValue, int available_seats)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("UpdateAvailableSeats");
                db.AddInParameter(dbCommand, "@cellValue", DbType.String, cellValue);
                db.AddInParameter(dbCommand, "@available_seats", DbType.Int64, available_seats);
                DataTable GetTicketNumber = new DataTable();
                using (IDataReader dr = db.ExecuteReader(dbCommand))
                {
                    GetTicketNumber.Load(dr);
                }
                return GetTicketNumber;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable InsertReceiptDetails(string ticket_number, string bus_number, string travel_date, string from, string to, string seat_number, int available_seats, string personcount_discount, string personcount_regular, double price, double total)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("InsertReceiptDetails");
                db.AddInParameter(dbCommand, "@ticket_number", DbType.String, ticket_number);
                db.AddInParameter(dbCommand, "@bus_number", DbType.String, bus_number);
                db.AddInParameter(dbCommand, "@travel_date", DbType.String, travel_date);
                db.AddInParameter(dbCommand, "@from", DbType.String, from);
                db.AddInParameter(dbCommand, "@to", DbType.String, to);
                db.AddInParameter(dbCommand, "@seat_number", DbType.String, seat_number);
                db.AddInParameter(dbCommand, "@available_seats", DbType.Int64, available_seats);
                db.AddInParameter(dbCommand, "@personcount_discount", DbType.String, personcount_discount);
                db.AddInParameter(dbCommand, "@personcount_regular", DbType.String, personcount_regular);
                db.AddInParameter(dbCommand, "@price", DbType.Double, price);
                db.AddInParameter(dbCommand, "@total", DbType.Double, total);
                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
                return dt;
            }
            catch { return null; }
        }

        public static string GetTransactionID()
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = GetCLDatabase();
                dbCommand = db.GetStoredProcCommand("GetTransactionID");
                db.AddOutParameter(dbCommand, "LastTransactionID", DbType.String, 255);
                db.ExecuteNonQuery(dbCommand);
                string lastTransactionID = db.GetParameterValue(dbCommand, "LastTransactionID").ToString();
                return lastTransactionID;
            }
            catch
            {
                return string.Empty; 
            }
        }
    }
}
