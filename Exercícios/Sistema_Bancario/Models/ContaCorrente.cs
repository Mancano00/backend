namespace Model
{
    public class ContaCorrente
    {
        private string titular { get; set; }
        private decimal saldo { get; set; }

        public ContaCorrente (string titularContaCorrente)
        {
            this.titular = titularContaCorrente;
        }
        public void depositar(decimal deposito)
        {
            if (deposito > 0){
                saldo += deposito;
            }else{
                Console.WriteLine("Seu deposito é invalido");
            }
        }
        public void CosultarSaldo()
        {
            Console.WriteLine($"Seu saldo é de R${saldo}");
        }
        public void Sacar(decimal saque)
        {
            if (saque < saldo){
                Console.WriteLine($"saque realizado foi de R${saque}, o saldo atual é de R${saldo - saque}");
            }else{
                Console.WriteLine($"Seu saque é alem do seu saldo");
            }
            saldo -= saque;
        }
    }
}