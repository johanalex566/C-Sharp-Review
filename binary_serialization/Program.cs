using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace binary_serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;


            Console.WriteLine("1)crear y serializar auto, 2) leer auto");
            opc = Convert.ToInt32(Console.ReadLine());

            if (opc.Equals(1))
            {
                Console.WriteLine("Get modelo");
                string modelo = (Console.ReadLine());


                Console.WriteLine("get costo");
                int cost = Convert.ToInt32(Console.ReadLine());
                //Create obj
                var Spark = new Auto(cost, modelo);

                //show info
                Spark.showInformatio();

                Console.WriteLine("serealizando........");

                //set object binary
                BinaryFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream("Auto.aut", FileMode.Create, FileAccess.Write, FileShare.None);

              

                //Serialice
                formatter.Serialize(stream, Spark);

                stream.Close();


            }
            if (opc.Equals(2))
            {
                Console.WriteLine("deserealizando........");

                Stream stream = new FileStream("Auto.aut", FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();

                //Get cant
                long cant = stream.Length;
                long value = 0;

                Console.WriteLine("The file size : {0}", cant);

                //Read byte for byte
                for (int i = 0; i < cant; i++)
                {
                    stream.Seek(i, SeekOrigin.Begin);

                    value = stream.ReadByte();

                    Console.WriteLine(" {0} ", (char)value);
                }
                Console.ReadKey();


                Auto auto = (Auto)formatter.Deserialize(stream);

                stream.Close();

                auto.showInformatio();

                Console.ReadKey();
            }
        }
    }
}
