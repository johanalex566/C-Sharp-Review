using System.Collections;

namespace _IEnumerable
{
    class AutoStore
    {
        private Auto[] Available;

        public AutoStore()
        {
            Available = new Auto[4];

            Available[0] = new Auto("Soul",220000);
            Available[1] = new Auto("Fit",650000);
            Available[2] = new Auto("March",440000);
            Available[3] = new Auto("Spark",320000);
        }

        public IEnumerator GetEnumerator()
        {
            //Regresamos la estructura que nos interesa que
            //Recorra el foreach, esta debe de implementar IEnumeerator.

            return Available.GetEnumerator();
        }

        //indexer
        public Auto this[int indice]
        {
            get { return Available[indice]; }
            set { Available[indice] = value; }
        }
    }
}
