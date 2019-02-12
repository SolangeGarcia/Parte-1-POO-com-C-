﻿using System;





namespace Atividade1LP2
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;

        public Conta(string t)
        {
            titular = t;
        }
        public decimal Saldo
        {
            get { return saldo; }
        }
        public String Titular
        {
            get { return titular; } 
        }
        public abstract string Id
        {
            get;
        }
        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor <= saldo)
                saldo -= valor;
        }
    }
}