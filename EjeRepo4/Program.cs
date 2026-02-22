//Programa con repositorio 4
Console.WriteLine("Seleccione el incidente ocurrido \n" +
    "1)Malware \n" +
    "2)Phishing \n" +
    "3)Acceso no autorizado \n" +
    "4)Fuga de informacion_");
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione el dispositivo afectado \n" +
    "1)PC \n" +
    "2)Servidor \n" +
    "3)Base de datos \n" +
    "4)Red_");
int device = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione los datos afectados \n" +
    "1)Ninguno \n" +
    "2)Internos \n" +
    "3)Personales \n" +
    "4)Finacieros_");
int datos = int.Parse(Console.ReadLine());
Console.WriteLine("La amenaza persiste? (s/n)_");
string persiste = Console.ReadLine();
Console.WriteLine("Ingrese el número de usuarios afectados_");
int usuarios = int.Parse(Console.ReadLine());
