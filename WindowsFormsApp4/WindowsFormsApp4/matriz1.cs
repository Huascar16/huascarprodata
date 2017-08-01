using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class matriz
    {
        public int posicion_del_areglo = 0;
        public string[,] arreglo1 = new string[5, 4];   
        public void Adicionar(string a, string b, string c, string d)
        {
            arreglo1[posicion_del_areglo, 0] = a;
            arreglo1[posicion_del_areglo, 1] = b;
            arreglo1[posicion_del_areglo, 2] = c;
            arreglo1[posicion_del_areglo, 3] = d;
        }
       public int i;

        int posision;
        public void Mostrar()
          {
            for (i = 0; i <= 4; i++)
            try
                {
                    Form1 load = new Form1();
                    if(load.listBox1.Items== null)
                    {
                        MessageBox.Show("esta en blanco");
                    }
                    else
                    {
                        MessageBox.Show(" Codigo: " + arreglo1[i, 0] + " Nombre: " + arreglo1[i, 1] + " Sexo " + arreglo1[i, 2] + " Salario " + arreglo1[i, 3]);
                    }
                     
    
                }
                catch { }
         }
        public void lista()
        {
            i = 0;
        }
        public void ultimo()
        {
            foreach (var item in arreglo1)
            {
                try
                {
                    MessageBox.Show("CODIGO ULTIMO " + item.ToString());
                    break;
                }
                catch
                {
                }
            }
        }
        
        public void PRINCIPAL()
        {

            posision = Int32.Parse(i.ToString());
            MessageBox.Show("CODIGO PRINCIPAL : " + posision);
           
        }

        public void eliminar()
        {
            Array.Clear(arreglo1, i, 0);
            Array.Clear(arreglo1, i, 1);
            Array.Clear(arreglo1, i, 2);
            Array.Clear(arreglo1, i, 3);
            MessageBox.Show("Arreglo limpio");
        }
      
    
    }
}
