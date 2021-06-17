using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO
{
    class AddressRepo
    {
        public static string connectionString = @"Data Source = (localdb)\ProjectsV13;Initial Catalog = Address_book_service; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                AddressModel addressModel = new AddressModel();
                using (this.connection)
                {

                    SqlCommand cmd = new SqlCommand(@"select * from employee_payroll where state='Hassan'", this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressModel.FirstName = dr.GetString(0);
                            addressModel.LastName = dr.GetString(1);
                            addressModel.Address = dr.GetString(2);
                            addressModel.PhoneNumber = dr.GetString(6);
                            addressModel.zip = dr.GetInt32(5);
                            addressModel.City = dr.GetString(3);
                            addressModel.State = dr.GetString(4);
                            addressModel.AddressBookName = dr.GetString(8);
                            addressModel.Email = dr.GetString(7);
                            addressModel.Type = dr.GetString(9);

                            System.Console.WriteLine(addressModel.FirstName + " " + addressModel.LastName + " " + addressModel.Address + " " + addressModel.City + " " + addressModel.zip + " " + addressModel.State + " " + addressModel.PhoneNumber + " " + addressModel.AddressBookName + " " + addressModel.Type);
                            System.Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");

                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
