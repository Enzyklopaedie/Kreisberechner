using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreisberechner_x_Klassen
{
    internal class Kreis
    {
        public double radius, durchmesser, umfang, flaecheninhalt;
        

        public void eingabe_radius(double r)
        {
            radius = r;
        }
        public void eingabe_durchmesser(double d)
        {
            durchmesser = d;
        }
        public void eingabe_umfang(double u)
        {
            umfang = u;
        }
        public void eingabe_flaeche(double f)
        {
            flaecheninhalt = f;
        }

        public double berradius()
        {
            if (durchmesser <= 0)
            {
                if (umfang <= 0)
                {
                    radius = Math.Sqrt(flaecheninhalt / Math.PI);
                }

                else
                {
                    radius = umfang / (2 * Math.PI);
                }
            }

            else
            {
                radius = durchmesser / 2;
            }

            return radius;
        }

        public double berdurchmesser()
        {
            if (radius <= 0)
            {
                if (umfang <= 0)
                {
                    durchmesser = Math.Sqrt(flaecheninhalt / Math.PI) * 2;
                }

                else
                {
                    durchmesser = umfang / Math.PI;
                }
            }

            else
            {
                durchmesser = 2 * radius;
            }

            return durchmesser;
        }

        public double berumfang()
        {
            if (radius <= 0)
            {
                if (durchmesser <= 0)
                {
                    umfang = Math.Sqrt(flaecheninhalt / Math.PI) * 2 * Math.PI;
                }

                else
                {
                    umfang = durchmesser * Math.PI ;
                }
            }

            else
            {
                umfang = 2 * radius * Math.PI;
            }

            return umfang;
        }

        public double berflaeche()
        {
            if (radius > 0)
            {
                flaecheninhalt = Math.PI * radius * radius;
            }
            else if (durchmesser > 0)
            {
                flaecheninhalt = Math.PI * (durchmesser / 2) * (durchmesser / 2);
            }
            else if (umfang > 0)
            {
                double r = umfang / (2 * Math.PI);
                flaecheninhalt = Math.PI * r * r;
            }

            return flaecheninhalt;
        }
    }
}
