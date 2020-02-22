using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Seller> ls = new List<Seller>();
            Seller s = null;
            List<Buyer> lb = new List<Buyer>();
            Buyer b = null;
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Seller");
                Console.WriteLine("2.Buyer");
                Console.WriteLine("3.exit");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1.register");
                        Console.WriteLine("2.login");
                        Console.WriteLine("3.exit");
                        Console.WriteLine("enter choice");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("enter name");
                            string name = Console.ReadLine();
                            Console.WriteLine("enter id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter mail id");
                            string email = Console.ReadLine();
                            Console.WriteLine("enter phone number");
                            string phno = Console.ReadLine();
                            Console.WriteLine("enter GSTIN number");
                            string GSTIN = Console.ReadLine();
                            Console.WriteLine("enter company name");
                            string cpname = Console.ReadLine();
                            s = new Seller(id, name,email, phno, GSTIN, cpname);
                            ls.Add(s);
                        }
                        else if (n == 2)
                        {
                            Console.WriteLine("enter username");
                            string usname = Console.ReadLine();
                            Console.WriteLine("enter mail id");
                            string mail = Console.ReadLine();
                            foreach (Seller i in ls)
                            {
                                if (usname.Equals(i.Name) && (mail.Equals(i.Email)))
                                {
                                    Console.WriteLine("...login successfull...");
                                    while (true)
                                    {
                                        Console.WriteLine("1.show details");
                                        Console.WriteLine("2.add items");
                                        Console.WriteLine("3.exit");
                                        int ch1 = int.Parse(Console.ReadLine());
                                        if (ch1 == 1)
                                        {
                                            s.details();
                                        }
                                        if (ch1 == 2)
                                        {
                                            SellerBO s1 = new SellerBO();
                                            s1.additems();
                                        }
                                        if (ch1 == 3)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("please login again");
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (ch == 2)
                {
                    while (true)
                    {

                        Console.WriteLine("1.register");
                        Console.WriteLine("2.login");
                        Console.WriteLine("3.exit");
                        Console.WriteLine("enter choice");
                        int n1 = int.Parse(Console.ReadLine());

                        if (n1 == 1)
                        {
                            Console.WriteLine("enter buyer name");
                            string bu_name = Console.ReadLine();
                            Console.WriteLine("enter buyer id");
                            int bu_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter emailid");
                            string bu_email = Console.ReadLine();
                            Console.WriteLine("enter phone number");
                            string bu_pn = Console.ReadLine();
                            b = new Buyer(bu_id, bu_name, bu_email, bu_pn);
                            lb.Add(b);
                        }
                        else if (n1 == 2)
                        {
                            Console.WriteLine("enter user name");
                            string buyer_usname = Console.ReadLine();
                            Console.WriteLine("enter email id");
                            string buyer_mail = Console.ReadLine();
                            foreach (Buyer i in lb) 
                            {
                                if ((buyer_usname.Equals(b.Name)) && (buyer_mail.Equals(b.Email)))
                                {
                                    Console.WriteLine("...login successfull...");
                                    while (true)
                                    {
                                        Console.WriteLine("Menu For Buyer");
                                        Console.WriteLine("1.display profile");
                                        Console.WriteLine("2.Search For Item");
                                        Console.WriteLine("3.Display All Items");
                                        Console.WriteLine("4.exit");
                                        Console.WriteLine("enter your Choice");

                                        int ch2 = int.Parse(Console.ReadLine());
                                        if (ch2 == 1)
                                        {
                                            b.display();
                                        }

                                        if (ch2 == 2)
                                        {
                                            b.search();
                                        }
                                        if (ch2 == 3)
                                        {
                                            b.displayitem();
                                        }
                                        if (ch2 == 4)
                                        {
                                            break;
                                        }

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Please login again");
                                }
                            }
                            
                        }
                    }
                    
                }
                else
                {
                    break;
                }
                if (ch==3)
                {
                    break;
                }
                else
                    Console.WriteLine("Wrong Choice. Please select appropriate Option");
            }
            Console.ReadLine();
        }
    }
    }

