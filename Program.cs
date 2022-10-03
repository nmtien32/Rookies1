using System;

namespace ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Member> listMember = new List<Member>()
            {
                new Member(){Firstname ="Huyen", Lastname = "Nguyen", Gender = "FeMale", DoB= new DateTime(07/22/2003) , PhoneNumber = "0962838383", BirthPlace = "Ha Noi"},
                new Member(){Firstname ="Hoa", Lastname = "Nguyen", Gender = "FeMale", DoB= new DateTime(01/02/2002) , PhoneNumber = "0962838383", BirthPlace = "Ha Tay"},
                new Member(){Firstname ="Son", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2001) , PhoneNumber = "0962838383", BirthPlace = "Ha Tinh"},
                new Member(){Firstname ="Hung", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2002) , PhoneNumber = "0962838383", BirthPlace = "Ha Tinh"},
                new Member(){Firstname ="Hoang", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2000) , PhoneNumber = "0962838383", BirthPlace = "Ha Noi"},
            };
            Console.WriteLine(" 1. Return a list of members who is Male");
            foreach (Member student in listMember)
            {
                if (student.Gender == "Male")
                {
                    Console.WriteLine(student.ToString());
                }
            }
            Console.WriteLine("2. Return the oldest one based on “Age”");
            uint oldestMemberAge = 0;

            foreach (Member item in listMember)
            {
                if (item.Age > oldestMemberAge)
                {
                    oldestMemberAge = item.Age;
                }
            }

            foreach (Member item in listMember)
            {
                if (item.Age == oldestMemberAge)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("3. Return a new list that contains Full Name");
            foreach (Member item in listMember)
            {
                string FullName = item.Firstname + " " + item.Lastname;
                Console.WriteLine(FullName);
            }

            Console.WriteLine("5. List member who has born in Ha Noi");
            int i = 0;
            while (i < listMember.Count)
            {
                if (listMember[i].BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(listMember[i].ToString());
                    break;
                }
                ++i;
            }

            Console.WriteLine("4. Return 3 Lists");
            int option = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Members have birth year = 2000:");
                            foreach (Member item in listMember)
                            {
                                if (item.DoB.Year == 2000)
                                    Console.WriteLine(item.ToString());
                            }
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("Members have birth year > 2000:");
                            foreach (Member item in listMember)
                            {
                                if (item.DoB.Year > 2000)
                                    Console.WriteLine(item.ToString());
                            }
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("Members have birth year < 2000:");
                            foreach (Member item in listMember)
                            {
                                if (item.DoB.Year < 2000)
                                    Console.WriteLine(item.ToString());
                            }
                            break;
                        }
                }
            } while (option > 1 && option < 3);
            Console.ReadKey();
        }
    }
}