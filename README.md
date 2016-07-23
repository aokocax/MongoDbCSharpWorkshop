# MongoDbCSharpWorkshop
<h3>MongoDB indirme linki</h3>


Temel mongodb işlemleri
Terminal üzerinden 
Sunucu üzerinden daha çok GUI'e sahip istemciler kullansak da terminal üzerinden de MongoDB'yi çalıştırabileceğiniz göstermek adına temel terminal komutlarını sıralayalım.
windows sunucuları üzerinde mongodb c:\programfiles\mongodb\server\3.x\bin dizininde kuruluyor mongod.exe dosyasını çalıştırarak serveri başlattıktan sonra mongo.exe'yi çalıştırarak terminal üzerinden mongodb komut setlerini girebilirsiniz.


show dbs //tüm databaseleri gösterir
use dbname // dbname ile belirtilen database'i kullanacağınızı belirtir
show collections //ilgili db içindeki tüm koleksiyonları döndürür
db.CollectionName.find({}) //belirtilen koleksiyondaki dokümanları listeler
db.CollectionName.insert({Name:"Test"}) // koleksiyona kayıt ekledik


 
<h3>GUI için Robomongo</h3>
https://robomongo.org/download

Sunucuya sağ tıklayıp Create Database'yi seçerek DB oluşturabilirsiniz.
imgdb1.png

DB'yi oluşturduktan sonra seçimi genişletip Collections'a sağ tıklayıp Create Collection ile Koleksiyon oluşturabilirsiniz

Koleksiyon oluşturduktan sonra ilgili koleksiyona sağ tıklayıp Insert Document'i seçerek koleksiyona doküman ekleyebilirsiniz. 
Aynı menü üzerinden doküman silme, güncelleme ve istatisklerine de bakabilirsiniz.


Temel işlemler

1) Insert (Kayıt ekleme)



