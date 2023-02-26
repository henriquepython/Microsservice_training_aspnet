using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection )
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                  Id= "uteratcurabitur",
                  Name= "odio porttitor id consequat in consequat ut nulla sed accumsan felis ut at dolor quis odio consequat",
                  Category= "nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque",
                  Description= "a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante",
                  Image= "https=//weibo.com/potenti.html?tempus=donec&sit=vitae&amet=nisi&sem=nam&fusce=ultrices&consequat=libero&nulla=non&nisl=mattis&nunc=pulvinar&nisl=nulla&duis=pede&bibendum=ullamcorper&felis=augue&sed=a&interdum=suscipit&venenatis=nulla&turpis=elit&enim=ac&blandit=nulla&mi=sed",
                  Price= 1
                },
                new Product()
                {
                  Id= "sempraesentid",
                  Name= "massa quis augue luctus tincidunt nulla mollis molestie lorem quisque ut erat curabitur gravida nisi at nibh in",
                  Category= "vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit",
                  Description= "quis augue luctus tincidunt nulla mollis molestie lorem quisque ut erat curabitur gravida nisi at",
                  Image= "https=//goodreads.com/risus/semper/porta.xml?suscipit=vivamus&a=vestibulum&feugiat=sagittis&et=sapien&eros=cum&vestibulum=sociis&ac=natoque&est=penatibus&lacinia=et&nisi=magnis&venenatis=dis&tristique=parturient&fusce=montes&congue=nascetur&diam=ridiculus&id=mus&ornare=etiam&imperdiet=vel&sapien=augue&urna=vestibulum&pretium=rutrum&nisl=rutrum&ut=neque&volutpat=aenean&sapien=auctor&arcu=gravida&sed=sem&augue=praesent&aliquam=id&erat=massa&volutpat=id&in=nisl&congue=venenatis&etiam=lacinia&justo=aenean&etiam=sit&pretium=amet&iaculis=justo&justo=morbi&in=ut&hac=odio&habitasse=cras&platea=mi&dictumst=pede&etiam=malesuada&faucibus=in&cursus=imperdiet&urna=et",
                  Price= 2
                },
                new Product()
                {
                  Id= "fusceconsequatnulla",
                  Name= "orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet",
                  Category= "morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est phasellus sit",
                  Description= "venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris",
                  Image= "http=//bloglines.com/phasellus/sit/amet/erat/nulla.js?dis=diam&parturient=cras&montes=pellentesque&nascetur=volutpat&ridiculus=dui&mus=maecenas&etiam=tristique&vel=est&augue=et&vestibulum=tempus&rutrum=semper&rutrum=est&neque=quam&aenean=pharetra&auctor=magna&gravida=ac&sem=consequat&praesent=metus&id=sapien&massa=ut&id=nunc&nisl=vestibulum&venenatis=ante&lacinia=ipsum&aenean=primis&sit=in&amet=faucibus&justo=orci&morbi=luctus&ut=et&odio=ultrices&cras=posuere&mi=cubilia&pede=curae&malesuada=mauris&in=viverra&imperdiet=diam&et=vitae&commodo=quam&vulputate=suspendisse&justo=potenti&in=nullam&blandit=porttitor&ultrices=lacus&enim=at&lorem=turpis&ipsum=donec&dolor=posuere&sit=metus&amet=vitae&consectetuer=ipsum&adipiscing=aliquam&elit=non&proin=mauris&interdum=morbi&mauris=non&non=lectus&ligula=aliquam&pellentesque=sit&ultrices=amet&phasellus=diam&id=in&sapien=magna&in=bibendum&sapien=imperdiet&iaculis=nullam&congue=orci&vivamus=pede&metus=venenatis&arcu=non&adipiscing=sodales&molestie=sed&hendrerit=tincidunt&at=eu&vulputate=felis&vitae=fusce&nisl=posuere&aenean=felis&lectus=sed&pellentesque=lacus&eget=morbi&nunc=sem&donec=mauris&quis=laoreet&orci=ut&eget=rhoncus&orci=aliquet&vehicula=pulvinar&condimentum=sed&curabitur=nisl&in=nunc&libero=rhoncus&ut=dui&massa=vel&volutpat=sem",
                  Price= 3
                },
                new Product()
                {
                  Id= "luctusnecmolestie",
                  Name= "pellentesque at nulla suspendisse potenti cras in purus eu magna vulputate luctus cum sociis natoque penatibus et magnis dis",
                  Category= "eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis",
                  Description= "nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id justo",
                  Image= "https=//printfriendly.com/turpis/donec/posuere/metus/vitae/ipsum.json?proin=et&at=commodo&turpis=vulputate&a=justo&pede=in&posuere=blandit&nonummy=ultrices&integer=enim&non=lorem&velit=ipsum&donec=dolor&diam=sit&neque=amet&vestibulum=consectetuer&eget=adipiscing&vulputate=elit&ut=proin&ultrices=interdum&vel=mauris&augue=non&vestibulum=ligula&ante=pellentesque&ipsum=ultrices&primis=phasellus&in=id&faucibus=sapien&orci=in&luctus=sapien&et=iaculis&ultrices=congue&posuere=vivamus&cubilia=metus&curae=arcu&donec=adipiscing&pharetra=molestie&magna=hendrerit&vestibulum=at&aliquet=vulputate&ultrices=vitae&erat=nisl&tortor=aenean&sollicitudin=lectus&mi=pellentesque&sit=eget&amet=nunc&lobortis=donec&sapien=quis&sapien=orci&non=eget&mi=orci&integer=vehicula&ac=condimentum&neque=curabitur",
                  Price= 4
                },
                new Product()
                {
                  Id= "semfusceconsequat",
                  Name= "ac tellus semper interdum mauris ullamcorper purus sit amet nulla quisque arcu libero rutrum ac lobortis vel dapibus at diam",
                  Category= "phasellus in felis donec semper sapien a libero nam dui proin leo odio",
                  Description= "in consequat ut nulla sed accumsan felis ut at dolor quis odio consequat varius integer ac leo pellentesque ultrices",
                  Image= "http=//businessweek.com/a.aspx?platea=eget&dictumst=rutrum&maecenas=at&ut=lorem&massa=integer&quis=tincidunt&augue=ante&luctus=vel&tincidunt=ipsum&nulla=praesent&mollis=blandit&molestie=lacinia&lorem=erat&quisque=vestibulum&ut=sed&erat=magna&curabitur=at&gravida=nunc&nisi=commodo&at=placerat&nibh=praesent&in=blandit&hac=nam&habitasse=nulla&platea=integer&dictumst=pede&aliquam=justo&augue=lacinia&quam=eget&sollicitudin=tincidunt&vitae=eget&consectetuer=tempus&eget=vel&rutrum=pede&at=morbi&lorem=porttitor&integer=lorem",
                  Price= 5
                },
                new Product()
                {
                  Id= "purussitamet",
                  Name= "suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna",
                  Category= "accumsan felis ut at dolor quis odio consequat varius integer ac leo pellentesque ultrices mattis odio",
                  Description= "cras in purus eu magna vulputate luctus cum sociis natoque",
                  Image= "http=//tmall.com/integer/ac.js?cum=feugiat&sociis=non&natoque=pretium&penatibus=quis&et=lectus&magnis=suspendisse&dis=potenti&parturient=in&montes=eleifend&nascetur=quam&ridiculus=a&mus=odio&vivamus=in&vestibulum=hac&sagittis=habitasse&sapien=platea&cum=dictumst&sociis=maecenas&natoque=ut&penatibus=massa&et=quis&magnis=augue&dis=luctus&parturient=tincidunt&montes=nulla&nascetur=mollis&ridiculus=molestie&mus=lorem&etiam=quisque&vel=ut&augue=erat&vestibulum=curabitur&rutrum=gravida&rutrum=nisi&neque=at&aenean=nibh&auctor=in",
                  Price= 6
                },
                new Product()
                {
                  Id= "auguequasollicitudin",
                  Name= "ipsum dolor sit amet consectetuer adipiscing elit proin risus praesent lectus vestibulum",
                  Category= "varius ut blandit non interdum in ante vestibulum ante ipsum primis",
                  Description= "libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh",
                  Image= "http=//friendfeed.com/in/quam/fringilla/rhoncus/mauris/enim/leo.xml?diam=mauris&erat=viverra&fermentum=diam&justo=vitae&nec=quam&condimentum=suspendisse&neque=potenti&sapien=nullam&placerat=porttitor&ante=lacus&nulla=at&justo=turpis&aliquam=donec&quis=posuere&turpis=metus&eget=vitae&elit=ipsum&sodales=aliquam&scelerisque=non&mauris=mauris&sit=morbi&amet=non&eros=lectus&suspendisse=aliquam&accumsan=sit&tortor=amet&quis=diam&turpis=in&sed=magna&ante=bibendum&vivamus=imperdiet",
                  Price= 7
                },
                new Product()
                {
                  Id= "feliseusapienm",
                  Name= "morbi vestibulum velit id pretium iaculis diam erat fermentum justo",
                  Category= "praesent id massa id nisl venenatis lacinia aenean sit amet justo",
                  Description= "nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros",
                  Image= "https=//ifeng.com/vivamus/vestibulum.json?pharetra=erat&magna=quisque&ac=erat&consequat=eros&metus=viverra&sapien=eget&ut=congue&nunc=eget&vestibulum=semper&ante=rutrum&ipsum=nulla&primis=nunc&in=purus&faucibus=phasellus&orci=in&luctus=felis&et=donec&ultrices=semper&posuere=sapien&cubilia=a&curae=libero&mauris=nam&viverra=dui&diam=proin&vitae=leo&quam=odio&suspendisse=porttitor&potenti=id&nullam=consequat&porttitor=in&lacus=consequat&at=ut&turpis=nulla&donec=sed&posuere=accumsan&metus=felis&vitae=ut&ipsum=at&aliquam=dolor&non=quis&mauris=odio&morbi=consequat&non=varius&lectus=integer&aliquam=ac&sit=leo&amet=pellentesque&diam=ultrices&in=mattis&magna=odio&bibendum=donec&imperdiet=vitae&nullam=nisi&orci=nam&pede=ultrices&venenatis=libero&non=non&sodales=mattis&sed=pulvinar&tincidunt=nulla&eu=pede&felis=ullamcorper&fusce=augue&posuere=a&felis=suscipit&sed=nulla&lacus=elit&morbi=ac&sem=nulla&mauris=sed&laoreet=vel&ut=enim&rhoncus=sit&aliquet=amet&pulvinar=nunc&sed=viverra&nisl=dapibus&nunc=nulla&rhoncus=suscipit&dui=ligula&vel=in&sem=lacus&sed=curabitur&sagittis=at&nam=ipsum&congue=ac&risus=tellus&semper=semper&porta=interdum&volutpat=mauris&quam=ullamcorper&pede=purus&lobortis=sit&ligula=amet&sit=nulla&amet=quisque&eleifend=arcu&pede=libero",
                  Price= 8
                },
                new Product()
                {
                  Id= "atipsumac",
                  Name= "volutpat dui maecenas tristique est et tempus semper est quam pharetra magna ac consequat",
                  Category= "morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc",
                  Description= "tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed",
                  Image= "https=//walmart.com/nullam/varius/nulla/facilisi.xml?sem=metus&sed=vitae&sagittis=ipsum&nam=aliquam&congue=non&risus=mauris&semper=morbi&porta=non&volutpat=lectus&quam=aliquam&pede=sit&lobortis=amet&ligula=diam&sit=in&amet=magna&eleifend=bibendum&pede=imperdiet&libero=nullam&quis=orci&orci=pede",
                  Price= 9
                },
                new Product()
                {
                  Id= "eraturabitugravid",
                  Name= "vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc",
                  Category= "sapien arcu sed augue aliquam erat volutpat in congue etiam",
                  Description= "aliquet at feugiat non pretium quis lectus suspendisse potenti in",
                  Image= "http=//mail.ru/sapien/varius/ut/blandit.xml?libero=gravida&quis=nisi&orci=at&nullam=nibh&molestie=in&nibh=hac&in=habitasse&lectus=platea&pellentesque=dictumst&at=aliquam&nulla=augue&suspendisse=quam&potenti=sollicitudin&cras=vitae&in=consectetuer&purus=eget&eu=rutrum&magna=at&vulputate=lorem&luctus=integer&cum=tincidunt&sociis=ante&natoque=vel&penatibus=ipsum&et=praesent&magnis=blandit&dis=lacinia&parturient=erat&montes=vestibulum&nascetur=sed&ridiculus=magna&mus=at&vivamus=nunc&vestibulum=commodo&sagittis=placerat&sapien=praesent&cum=blandit&sociis=nam&natoque=nulla&penatibus=integer&et=pede&magnis=justo&dis=lacinia&parturient=eget&montes=tincidunt&nascetur=eget&ridiculus=tempus&mus=vel&etiam=pede&vel=morbi&augue=porttitor&vestibulum=lorem&rutrum=id&rutrum=ligula&neque=suspendisse&aenean=ornare&auctor=consequat&gravida=lectus&sem=in&praesent=est&id=risus&massa=auctor&id=sed&nisl=tristique&venenatis=in&lacinia=tempus&aenean=sit&sit=amet&amet=sem&justo=fusce&morbi=consequat&ut=nulla&odio=nisl&cras=nunc&mi=nisl&pede=duis&malesuada=bibendum&in=felis&imperdiet=sed&et=interdum&commodo=venenatis&vulputate=turpis&justo=enim&in=blandit",
                  Price= 10
                }
            };
        }
    }
}
