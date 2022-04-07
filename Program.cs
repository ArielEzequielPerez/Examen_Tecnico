static void quicksort(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indiceParticion = particion(arreglo, izquierda, derecha);
                quicksort(arreglo, izquierda, indiceParticion);
                quicksort(arreglo, indiceParticion + 1, derecha);
            }
        }
static int particion(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[izquierda];
            while (true)
            {
                /*
                Acercar los extremos hacia el centro mientras se encuentren elementos ordenados
                 */
                while (arreglo[izquierda] < pivote)
                {
                    izquierda++;
                }

                while (arreglo[derecha] > pivote)
                {
                    derecha--;
                }
                // Si los extremos se cruzaron o superaron, entonces toda la porción del arreglo estaba ordenada
                if (izquierda >= derecha)
                {
                    // Regresamos el índice para indicar hasta qué posición el arreglo está en orden
                    return derecha;
                }
                else
                {
                    // Si no estuvieron ordenados, vamos a hacer el intercambio
                    int temporal = arreglo[izquierda];
                    arreglo[izquierda] = arreglo[derecha];
                    arreglo[derecha] = temporal;
                    // Y acercamos en 1 los extremos
                    derecha--; izquierda++;

                }
                // El while se repite hasta que izquierda >= derecha
            }
    }

int[] numeros = { 1,2,3,1};
//ordenar numeros
quicksort(numeros, 0, numeros.Length - 1);

bool bandera = false;
for(int i = 0; i<numeros.Length; i++)
{
    if(numeros[i] == numeros[i+1])
    {
        bandera = true;
    }
}
Console.WriteLine(bandera);

