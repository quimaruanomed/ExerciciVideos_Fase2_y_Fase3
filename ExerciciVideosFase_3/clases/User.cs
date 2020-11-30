using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercici3VideosFases_3.Clases
{
    public class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatRegister { get; set; }
        public User()
        {

        }

        //Metodo que valida si los campos están vacíos 
        public static void DatesEmptys(string resp)
        {
            if (resp == "")
            {
                Console.WriteLine("Error!!! No has introducido ningún valor");
                Console.WriteLine();
                

            }
  

        }
        public static void Login()
        {

            Console.WriteLine("Introduce tu usuario/Username: ");
            string login = Console.ReadLine();
            
            Console.WriteLine("Introduce el Password: ");
            string pass = Console.ReadLine();
           
            Console.WriteLine();
            

            var fUser = User.uList.Exists(x => x.Username.Equals(login));
            var fpas = User.uList.Exists(x => x.Password.Equals(pass));
            Console.WriteLine();

            // Comprobamos que valor tienen las variables fUser y fpas para poder programar las condiciones que comprueben que los datos introducidos son correctos 
            
            Console.WriteLine("Usuario  :" + fUser);
            Console.WriteLine("Password  : " + fpas);
          

            if ((fUser == true) && (fpas == true))
            {
                Console.WriteLine("Validacion correcta");
               
            }
            else
            {
                Console.WriteLine("**************************************");
               Console.WriteLine("********  Prueba de nuevo:  ***********");
               do
                {
                    Console.WriteLine("Introduce tu usuario/Username: ");
                    login = Console.ReadLine();
                    
                    Console.WriteLine();
                    Console.WriteLine("Introduce el Password: ");
                    pass = Console.ReadLine();
                   
                    Console.WriteLine();

                    fUser = User.uList.Exists(x => x.Username.Equals(login));
                   
                    Console.WriteLine("Usuario  :" + fUser);
                    fpas = User.uList.Exists(x => x.Password.Equals(pass));
                    Console.WriteLine();
                    Console.WriteLine("Password  : " + fpas);


                } while ((fUser != true) && (fpas != true));
                Console.WriteLine("Validacion correcta");
            }

            {

                var newR = new List<Video>();
                var conVideo = Video.vList.ToList();
                List<Video> newVideo = new List<Video>();
                List<bool> vT = new List<bool>().ToList();

                // Variable que utilizaremos para las dif. opciones del swtich 
                
                ConsoleKeyInfo op;
                


                do
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine("   Bienvenido a : Videos  ");
                    Console.WriteLine();
                    Console.WriteLine("***************************");
                    Console.WriteLine("============================");
                    Console.WriteLine("         MENU     ");
                    Console.WriteLine("============================");
                    Console.WriteLine("Opciones:" +
                   "\n A.-Listar mis video" +
                   "\n B.-Crear video " +
                   "\n C.-Buscar Video : y accdiones sobre el video: " +

                    "\n D.-Para Salir pulsa ESC dos veces "
                    );


                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        case ConsoleKey.A:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("LISTADO DE VIDEOS DEL USUARIO LOGEADO : " + login);
                            Console.WriteLine();

                            if (login == "admin")
                            {
                                Console.WriteLine("Pearl harbor sound track");


                            }

                            if (login == "jruanomed")
                            {
                                Console.WriteLine("Gladiator - Now We Are Free Super Theme Song");
                                Console.WriteLine(" Sarah Mclachlan - In The Arms Of The Angel");

                            }
                            if (login == "jperez")
                            {
                                Console.WriteLine(" One day We Had Today");
                                Console.WriteLine(" John Barry - The Old Woman");
                            }

                            break;


                        case ConsoleKey.B:

                            Console.Clear();

                            Console.WriteLine("Introduce su Url: ");
                            string nUrl = Console.ReadLine();
                            Console.WriteLine("Introduce el título del video que quieres crear: ");
                            string nVideo = Console.ReadLine();
                            Video.vList.Add(new Video() { Url = nVideo, Title = nUrl });
                            List<Video> newVi = new List<Video>();
                            newVi.Add(new Video() { Url = nVideo, Title = nUrl });

                            // Comprobamos que los registros nuevos se han guardado 

                            Console.WriteLine("####################################################################################");
                            Console.WriteLine("Listado de Video : Comprobación de que el video creado se ha guardado en la lista ");
                            Console.WriteLine("######################################################################################");
                            Console.WriteLine();
                            for (int i = 0; i < Video.vList.Count; i++)
                            {

                                Console.WriteLine("Titulo: " + "\n" + Video.vList[i].Title + "\n" + "Url: " + "\n" + Video.vList[i].Url);

                            }
                            Console.WriteLine();
                            Console.WriteLine("###########");
                            Console.WriteLine("TAGS");
                            Console.WriteLine("############");

                            Console.WriteLine("1.- Crear un Tag:  " + "Si: 1 " + " " + "No :2");
                            string resp = Console.ReadLine();
                            DatesEmptys(resp);

                            do
                            {

                              
                               
                               
                                if (resp == "2")
                                {
                                    break;
                                }

                                if (resp == "1")
                                {
                                    Console.WriteLine("Introduce el nombre del Tag/etiqueta : ");
                                    string nTag = Console.ReadLine();
                                    List<string> newTags = new List<string>();
                                    newTags.Add(nTag);
                                    Console.WriteLine("Quieres añadir otro Tag ");
                                    resp = Console.ReadLine();
                                    DatesEmptys(resp);
                                    
                                        if ((resp == "2") || (resp != "1"))
                                       {
                                           break;
                                       }
                                }

                            } while ((resp != "2") || (resp != ""));

                            break;

                        case ConsoleKey.C:
                            Console.Clear();
                            Console.WriteLine("Introduce el titulo del video que quieres buscar: ");
                            string xVideo = Console.ReadLine();
                            string findVideo = Video.vList.ToString();
                             DatesEmptys(xVideo);

                            if (login == "admin")
                            {
                                
                                if (xVideo == "Pearl harbor sound track")
                                {
                                    Console.WriteLine("Resultado de la busqueda:  " + xVideo);
                                    Console.WriteLine("\n 1.- Reproducir video" +
                                             "\n 2- Pausar video " +
                                              "\n 3 - Parar video");

                                    string respSub = Console.ReadLine();
                                    DatesEmptys(respSub);
                                    
                            if (respSub == "1")
                            {
                                Console.WriteLine("El video se está reproduciendo");
                            }
                            if (respSub == "2")
                            {
                                Console.WriteLine("Video Pausado");
                            }
                            if (respSub == "3")
                            {
                                Console.WriteLine("Video detenido");
                            }

                        }
                            }

                            if (login == "jruanomed")
                            {
                               if (xVideo == "Gladiator - Now We Are Free Super Theme Song" || xVideo == "Sarah Mclachlan - In The Arms Of The Angel")
                                {
                                    
                                    Console.WriteLine("Resultado de la busqueda : " + xVideo);
                                    Console.WriteLine("\n 1.- Reproducir video" +
                                             "\n 2- Pausar video " +
                                              "\n 3 - Parar video");

                                    string respSubm = Console.ReadLine();
                                    DatesEmptys(respSubm);
                                    if (respSubm == "1")
                                    {
                                        Console.WriteLine("El video se está reproduciendo");
                                    }
                                    if (respSubm == "2")
                                    {
                                        Console.WriteLine("Video Pausado");
                                    }
                                    if (respSubm == "3")
                                    {
                                        Console.WriteLine("Video detenido");
                                    }

                                }
                            }

                            if (login == "jperez")
                            {
                               if (xVideo == "One day We Had Today" || xVideo == "John Barry - The Old Woman")
                                {

                                    Console.WriteLine("Resultado de la busqueda : " + xVideo);
                                    Console.WriteLine("\n 1.- Reproducir video" +
                                             "\n 2- Pausar video " +
                                              "\n 3 - Parar video");

                                    string respSubmn = Console.ReadLine();

                                    DatesEmptys(respSubmn);
                                    if (respSubmn == "1")
                                    {
                                        Console.WriteLine("El video se está reproduciendo");
                                    }
                                    if (respSubmn == "2")
                                    {
                                        Console.WriteLine("Video Pausado");
                                    }
                                    if (respSubmn == "3")
                                    {
                                        Console.WriteLine("Video detenido");
                                    }
                                }
                            }

                            break;

                        default:

                            Console.WriteLine();
                            Console.WriteLine("Opción no valida");
                            Console.WriteLine();
                         break;


                        case ConsoleKey.Escape:
                            break;
                    }

                } while (op.Key != ConsoleKey.Escape);
            }
            Console.ReadKey();
        }


        public static List<User> uList = new List<User>
        {
           new User {Name="Joaquina", Surname="Ruano",Username="jruanomed",Password="jruanomed" },
           new User {Name= "Javier", Surname= "Perez", Username= "jperez", Password= "jperez" },
           new User {Name= "admin", Surname= "admin", Username= "admin", Password= "admin"}};
    }

}








