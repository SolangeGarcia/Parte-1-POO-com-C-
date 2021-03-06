﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1LP2
{
    public class ContaCorrente : Conta
    {
        public const decimal Taxa = 0.10M;

        public ContaCorrente(string t) : base(t) { }

        public override string Id
        {
            get { return Titular + "(ContaCorrente)"; }
        }
        public override void Depositar(decimal valor)
        {
            decimal desconto = valor * Taxa;
            base.Depositar(valor);
        }
        public override void Sacar(decimal valor)
        {
            decimal desconto = valor * Taxa;
            base.Sacar(valor);
        }

    }
}

