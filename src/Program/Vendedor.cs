namespace DefaultNamespace;

public class Vendedor: IUsuario
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Inbox { get; set; }
        public List<string> HistoryMsg{ get; set; }
        public Tuple <string, string> Contact { get; set; }
        public List<Cliente> Clientes = new List<Cliente>();
    
        public Vendedor(string name, string surname, string numTelefono, string mail)
        {
            this.Name = name;
            this.Surname = surname;
            this.Contact = new Tuple<string, string>(numTelefono, mail);
        }
    
        //--Realiza una lista de los clientes del Vendedor--//
        public void ClientList(Cliente unCliente)
        {
            Clientes.Add(unCliente);
        }

        public void PrintClientList()
        {
            Console.WriteLine($"{Clientes}");
        }
        //--------------------------------------------------//      
    }
