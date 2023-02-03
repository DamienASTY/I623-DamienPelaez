using System;
using System.Collections.Generic;
using System.Text;

namespace PaintBallGun_DamienPelaezDiaz
{
    class PaintBallGun
    {
        private int munitionPoche { get; set; }
        private int munitionArme { get; set; } //max 200
        private int capacity { get; set; }
        public PaintBallGun()
        {
            this.munitionArme = 30;
            this.capacity = 30;
            this.munitionPoche = 0;
        }

        public string Recharger()
        {
            if (this.munitionPoche > 0)
            {
                //doit recharger à 30 balles
                if (this.munitionArme != this.capacity)
                {
                    int rest = this.munitionArme;
                    int aRecharger = this.capacity - rest;
                    if (aRecharger <= this.munitionPoche && (this.munitionPoche - aRecharger) >= 0)
                    {
                        this.munitionArme += aRecharger;
                        this.munitionPoche -= aRecharger;
                        return $"Vous avez recharger de {aRecharger} balles";
                    }
                    else
                    {
                        return "Impossible de recharger l'arme";
                    }
                }
                else
                {
                    return "Votre chargeur est plein";
                }
            }
            else
            {
                return "Vous n'avez plus de balles dans vos poches";
            }
        }

        public string PrendreBalles()
        {
            this.munitionPoche += this.capacity;
            return "Rechargement de 30 balles dans vos poches";
        }

        public string Tirer()
        {
            if (this.munitionArme > 0)
            {
                this.munitionArme -= 1;
                return "Vous avez tiré une balle";
            }

            return "Chargeur vide";
        }

        public string AmeliorerChargeur()
        {
            if (this.capacity == 50)
            {
                return "Capacité maximal atteinte";
            }
            else
            {
                this.capacity = 20;
                return "La capacité du chargeur à augmenter de 20 balles";
            }
        }

        public override string ToString()
        {
            string cpl;
            if (this.munitionArme == 0)
            {
                cpl = "\bAttention, votre chargeur est vide";
            }
            else
            {
                cpl = "";
            }
            return
                $"Vous avez un total de {this.munitionPoche} balles dans vos poches et {this.munitionArme} balles dans le chargeur" + cpl;
        }
    }
}
