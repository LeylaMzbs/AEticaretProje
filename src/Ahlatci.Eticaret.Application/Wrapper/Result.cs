namespace Ahlatci.Eticaret.Application.Wrapper
{
    public class Result<T> where T:new()
    {
        public T Data { get; set; } 
        //Response'lar için bir şablon Response'tan ne dönüyorsa onu data ile göndeririz.
        public bool Success { get; set; } = true; 
        //işlem başarılı mı değil mi? İşlemin durumana ilişkin bir şeyi Success ile göndeririz.
        public List<string> Errors { get; set; } = new List<string>();
        //Hata varsa hataları tutan bir kolleksiyon.

        //Result Standardizasyon'u sağlar geriye dönen çıktıların,tiplerin aynı formatta olmasını sağlar.

    }
}
