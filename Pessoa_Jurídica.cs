namespace ControleDeClientes
{
    class Pessoa_Jurídica : Clientes {
        public string cnpj{get; set;}
        public string ie{get; set;}

        public override void Pagar_Imposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 0.2f;
            this.total = this.valor + this.valor_imposto;
        }
    }
}