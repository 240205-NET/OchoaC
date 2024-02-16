using static System.Console;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Project.Logic
{

    [Serializable]
    public class ClientKey
    {
        public int ClientID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public ClientKey()
        {
        }

        public ClientKey(int clientID, string username, string password)
        {
            ClientID = clientID;
            Username = username;
            Password = password;
        }
        
    }

    [Serializable]
    public class EmployeeKey
    {
        public int EmployeeID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public EmployeeKey()
        {
        }

        public EmployeeKey(int employeeID, string username, string password)
        {
            EmployeeID = employeeID;
            Username = username;
            Password = password;
        }
        
    }


    [Serializable]
    public class Appointment
    {
        [XmlElement]
        public string? AptDatetime { get; set;}
        [XmlElement]
        public string? AptLocation { get; set;}
        [XmlElement]
        public string? AptDescription { get; set;}
        [XmlElement]
        public int ClientID { get; set; }
        [XmlElement]
        public int EmployeeID { get; set; }
        
        public Appointment()
        {
        }

        public Appointment(string datetime, string location, string description, int clientID, int employeeID)
        {
            AptDatetime = datetime;
            AptLocation = location;
            AptDescription = description;
            this.ClientID = clientID;
            this.EmployeeID = employeeID;

        }

        public void DisplayAppointment()
        {
            WriteLine($"Date and Time: {AptDatetime}");
            WriteLine($"Location: {AptLocation}");
            WriteLine($"Description: {AptDescription}");
        }
    }

    [Serializable]
    public abstract class Person
    {
        [XmlElement]
        public string? Name { get; set;}
        [XmlElement]
        public string? Email { get; set;}
        [XmlElement]
        public string? PhoneNumber { get; set;}
        [XmlElement]
        public string? Username { get; set;}
        [XmlElement]
        public string? Password { get; set;}
        [XmlElement]
        public List<Appointment> Appointments { get; set;}

        public Person()
        {
            Appointments = new List<Appointment>();
        }

        public Person(string? name, string? email, string? phoneNumber, string? username, string? password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Password = password;
            Appointments = new List<Appointment>();
        }

        public void AddAppointment(Appointment apt)
        { 
        }

        public void RemoveAppointment(Appointment apt)
        {
        }

        public void DisplayAppointments()
        {
            foreach (var apt in Appointments)
            {
                apt.DisplayAppointment();
                WriteLine("----------------------------");
            }
        }
    }


    [XmlRoot("ClientList")]
    public class ClientList
    {
        [XmlElement("Client")]
        public List<Client> clientList { get; set; }

        public ClientList()
        {
            clientList = new List<Client>();
        }
    }

    [Serializable]
    public class Client : Person
    {
        [XmlElement]
        public int ClientID { get; set; }
        private int _clientIDseed;
        [XmlElement]
        public string? ClientType { get; set; }

        public Client()
        {
        }

        public Client(string? name, string? email, string? phoneNumber, string? username, string? password, string? clientType) : base(name, email, phoneNumber, username, password)
        {
            this.ClientType = clientType;
        }

        public void AddAppointment(string datetime, string location, string description, int employeeID)
        {
            //first check to see if appointment is available in availability.xml

            Appointment apt = new Appointment(datetime, location, description, ClientID, employeeID);
            Appointments.Add(apt);
        }

        public override string ToString()
        {
            return $"Name: {Name}, {Username}, {Password}";
        }

    }

    [XmlRoot("EmployeeList")]
    public class EmployeeList
    {
        [XmlElement("Employees")]
        public List<Employee> employeeList { get; set; }

        public EmployeeList()
        {
            employeeList = new List<Employee>();
        }
    }

    [Serializable]
    public class Employee : Person
    {
        [XmlElement]
        public int EmployeeID { get; set; }
        private int _employeeIDseed;
        [XmlElement]
        public string? OfficeLocation { get; set; }

        public Employee()
        {
        }
        
        public Employee(string? name, string? email, string? phoneNumber, string? username, string? password, string? officeLocation) : base(name, email, phoneNumber, username, password)
        {
            this.OfficeLocation = officeLocation;
        }

        public void AddAppointment(string datetime, string location, string description, int clientID)
        {
            //first check to see if appointment is available in availability.xml

            Appointment apt = new Appointment(datetime, location, description, clientID, EmployeeID);
            Appointments.Add(apt);
        }
    }


}


