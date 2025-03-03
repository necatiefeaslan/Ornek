namespace Ornek;
public class Ogrenci
{
public int Id { get; set; }
public string Ad { get; set; } = string.Empty ;
public string Soyad { get; set; } = string.Empty ;
public string? OkulNumarasi { get; set; }
public Sinif? sinif { get; set; }
public int SinifId { get; set; }
}


