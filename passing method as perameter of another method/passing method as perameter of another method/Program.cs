using System;

namespace passing_method_as_perameter_of_another_method
{
    public delegate int calculator(int first_num, int sec_num);
    class cosmetic_shop
    {
        int quantity, single_piece_price;
        public string brand_name
        { get; set; }
        public int body_lotion(int quantity,int single_piece_price)
        {
            this.quantity = quantity;
            this.single_piece_price = single_piece_price;
            int tot_price = this.quantity * this.single_piece_price;
            return tot_price;
        }
        public void display(calculator calc)
        {
            Console.WriteLine("enter quantity and per piece price:");
            var inp = Console.ReadLine();
            var data = inp.Split(' ');
            int k = int.Parse(data[0]);
            int l = int.Parse(data[1]);
            int res=calc(k, l);    //calc er value hisebe cal pass kora hoyechilo jehetu cal body_lotion ke point kore chilo tai bola jay calc o body_lotion ke point kore
            //ache....ar ekhane value deya hocche mane body_lotion ke call/invoke kora hocche.
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your brand name:");
            string s = Console.ReadLine();
            cosmetic_shop cosm = new cosmetic_shop();
            cosm.brand_name = s;
            calculator cal = new calculator(cosm.body_lotion);   //pointing body_lotion by delegate cal;
            cosm.display(cal);  //jehetu cal body_lotion ke point kore ache tai cal ke pass kora mane body_lotion ke pass kora
        }
    }
}
