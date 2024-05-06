using prova;
class Program{
static void Main(string[] args){
    Leao leao = new Leao();
    leao.Name = "Leao";
    leao.Comer();
    Console.WriteLine(leao.Name + ", seu peso é:" + leao.peso);
}
}