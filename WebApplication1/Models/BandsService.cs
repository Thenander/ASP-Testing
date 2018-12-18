using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class BandsService
    {
        private static List<Band> bands = new List<Band>
        {
            new Band
            {
                Id = 1,
                Name = "Adam and the Ants",
                Description = "Bandets musikstil har kallats New romantic. De bildades redan 1971[1] av London-borna Danny Kleinman (gitarr/sång), Pat Collier (bas), John Ellis (gitarr) och Rick Wernham (trummor) och gick då under namnet Bazooka Joe. Det var Danny Kleinman som värvade Adam Ant till bandet, som då studerade vid Homsey Art College. Mellan 1971 och 1977 bytte bandet line-up 25 gånger. Adam Ant tröttnade och i början av 1976 startade han bandet B-sides med Lester Square (vars riktiga namn är Thomas Hardy). Båda var vid tidpunkten studenter på Homsey Art College. Men bandet hade problem med att få spelningar och Adam Ant lämnade bandet för att senare komma tillbaka en kort tid och slutligen lämna bandet helt i början av 1977. I april 1977 startade Adam Ant det första bandet med namnet Adam And the Ants tillsammans med Lester Square (gitarr), Andy Warren (bas, sång) och Paul Flanagan (trummor).",
                ImageUrl = "/images/AdamAndTheAnts.jpg",
                Spot = "6Ery60n0SHDiIG18DMi5cV",
            },
            new Band
            {
                Id = 2,
                Name = "Arthur Baker",
                Description = "Arthur Baker (born April 22, 1955) is an American record producer and DJ best known for his work with hip hop artists like Afrika Bambaataa, Planet Patrol, and the British group New Order. He is also known for remixing the Jill Jones song Mia Bocca on the 12 inch single, taken from her self-titled debut album Jill Jones (1987), released on Prince's Paisley Park Records, as well as remixing the Pet Shop Boys song, In The Night. His remix of the song was used as the main theme for the BBC TV programme The Clothes Show between 1986 and 1994. He also remixed 'the Massive Jungle Mix' for Tina Turner's UK top 40 lead single from her 1996 album Wildest Dreams Whatever You Want (co-written by himself, Taylor Dayne and Fred Zarr). Arthur Baker's songs are represented by Downtown Music Publishing.",
                ImageUrl = "/images/ArthurBaker.jpg",
                Spot = "4oPFzHKR5nqVjwt3bgRq5p",
      },
            new Band
            {
                Id = 3,
                Name = "Giorgio Moroder",
                Description = "Giovanni Giorgio Moroder (på skivomslag oftast bara Giorgio), ursprungligen Hansjörg Moroder,[1] född 26 april 1940 i Ortisei i Sydtyrolen, är en italiensk musikproducent och kompositör, stilbildare inom disco- och dansmusiken. Moroder hade en egen solokarriär i slutet av 1960-talet men det var som producent som det stora genombrottet skulle komma under 1970-talet. Moroder var producent till Donna Summer och låg bland annat bakom hennes genombrottslåt och discoklassiker Love to love you baby och I feel love. Moroder har som producent influerat musikstilar som new wave, house, techno och elektronisk musik i allmänhet. Han grundade Oasis Records, senare en del av Casablanca Records. Moroder slog sig sedan in på filmmusik där framgångarna fortsatte; Moroder vann tre Oscars för Midnight Express(1978), Flashdance(1983) och Top Gun(1986).",
                ImageUrl = "/images/GiorgioMoroder.jpg",
                Spot = "4zV2nLoVFrOOxlmTN8OoiG",
            },
            new Band
            {
                Id = 4,
                Name = "Hecq",
                Description = "Born in 1981 as the third child of opera singer Deirdre Boysen and actor Claus Boysen, his classical music training on piano and guitar began when he was seven years old. Ben’s first electronic compositions were done by experimenting with samplers and tape loops when he was 16. Setting up HECQ Audio as a studio project in 2008, he has produced many albums and created custom sound design for films, commercials, installations, and image films – clients include MTV, BBC, Amnesty International, Marvel Comics, and Mazda. Festivals such as OFFF, BD4D, and Flash On The Beach have been inviting Ben to give workshops for students, TV and film editors, composers, and sound designers. Boysen wrote his first score in 2010 for the feature film Restive, directed by Jeremiah Jones, followed by Johan Liedgren’s Mother Nature and California Scheming by Marco Weber scored in 2011.",
                ImageUrl = "/images/Hecq.jpg",
                Spot = "566xbpxVn3rLGW7CPCsd1B",
            },
                        new Band
            {
                Id = 5,
                Name = "James Brown",
                Description = "James Brown, född James Joseph Brown Jr. den 3 maj 1933 i Barnwell, South Carolina, död 25 december 2006 i Atlanta, Georgia, var en amerikansk soul- och funkartist. Han kom att få stort inflytande på musiker inom såväl soul och funk som rap och hip hop.[1] Han var också känd för att vara en skicklig dansare. Han har fått smeknamn som The Godfather of Soul, Soul Brother Number One och Mr. Dynamite. Han kallade ofta sig själv The Hardest Working Man in Show Business. Gruppen som Brown slog igenom i hette The famous flames. En långfilm baserad på hans liv, Get on Up, med Chadwick Boseman i huvudrollen hade premiär 2014.",
                ImageUrl = "/images/JamesBrown.jpg",
                Spot = "6Wzf9BalBqQAenrUb9xzUH",
            },
            new Band
            {
                Id = 6,
                Name = "Kiss",
                Description = "Kiss (ofta stiliserat KISS) är ett amerikanskt hårdrocksband som bildades den 3 januari 1973 i New York[1] av Paul Stanley (gitarr), Gene Simmons (bas), Peter Criss (trummor) och Ace Frehley (gitarr). Välkänt för medlemmarnas ansiktsmålning och teatraliska scenkläder, fick gruppen sitt genombrott i mitten till slutet av 1970-talet, bland annat tack vare sina liveuppträdanden, som innehåller eldsprutning, blodspottning, rykande gitarrer, explosioner, svävande trumset och pyroteknik. Bandet har gått igenom en mängd medlemsbyten med Stanley och Simmons som de enda kvarvarande medlemmarna från originaluppsättningen. Med sitt smink och sina dräkter, antog de serietidningsliknande personas: Starchild (Stanley), Demon (Simmons), Spaceman eller Space Ace (Frehley) och Catman (Criss).",
                ImageUrl = "/images/Kiss.jpg",
                Spot = "59plsPcJYFlSA5ImekNQJ0",
            },
            new Band
            {
                Id = 7,
                Name = "Kraftwerk",
                Description = "Kraftwerk är en tysk elektronisk musik-grupp från Düsseldorf i Västtyskland, bildad av Ralf Hütter och Florian Schneider 1970. Kraftwerks produktionsbolag heter Kling Klang Studio. Några av gruppens mest kända låtar är Autobahn, Radio-Activity, Trans Europe Express, The Model, The Robots och Tour de France. Kraftwerk anses vara pionjärerna inom den elektroniska musiken och har varit viktiga inspiratörer för bland annat techno.",
                ImageUrl = "/images/Kraftwerk.jpg",
                Spot = "42hCHiMtfs7mfBTVX3V6k7",
            },
            new Band
            {
                Id = 8,
                Name = "Lassigue Bendthaus",
                Description = "Lassigue Bendthaus is the electro-industrial project of Uwe Schmidt. The final album, Pop Artificielle, is in the glitch/techno music style of Schmidt's Atom™ project and is an album of pop and soul covers.",
                ImageUrl = "/images/LassigueBendthaus.jpg",
                Spot = "5c1dJ6o2x2S1ADJXAtx8zU",
            },
            new Band
            {
                Id = 9,
                Name = "Meat Beat Manifesto",
                Description = "Industrial, Electronic, Experimental music act started by John Stephen Corrigan aka Jack Dangers and Jonny Stephens in 1987, Swindon, United Kingdom. Jack Dangers has led the group and been the only permanent member, collaborating with other members along the way. Meat Beat Manifesto worked with Consolidated and The Disposable Heroes Of Hiphoprisy to pioneer the early '90s industrial hip-hop sound. Meat Beat Manifesto's earlier work is widely credited with influencing trip hop, drum & bass and big beat.",
                ImageUrl = "/images/MeatBeatManifesto.jpg",
                Spot = "7H2nuZwpHopMtzX4bEbULM",
            },
            new Band
            {
                Id = 10,
                Name = "Nitzer Ebb",
                Description = "Nitzer Ebb är en brittisk musikgrupp inom industrial/electro/techno/EBM som bildades år 1982 av barndomsvännerna från Chelmsford i Essex: Douglas McCarthy (sång), David Vaughn (Bon) Harris och David Gooday (keyboard). Gruppen splittrades år 1995, men återförenades år 2006. Nitzer Ebb har en aggressiv sångstil och tung minimalistisk synthmusik. Under sina första år var de tydligt inspirerade av Deutsch-Amerikanische Freundschaft. Gruppens estetiska helhetskoncept som innefattar merchandise, skivomslag, scenframträdanden, logotyper, med mera, går under beteckningen Nitzer Ebb Produkt (NEP).",
                ImageUrl = "/images/NitzerEbb.jpg",
                Spot = "4hyPZs0cTC25UUI5GzgiWy",
            },
            new Band
            {
                Id = 11,
                Name = "Public Enemy",
                Description = "Public Enemy är en amerikansk hiphopgrupp, som bildades 1982 på Long Island i New York. Gruppen har gjort sig kända för sina politiskt laddade låttexter och för sitt engagemang i svarta amerikaners frågor.",
                ImageUrl = "/images/PublicEnemy.jpg",
                Spot = "03Mx6yaV7k4bsEmcTH8J49",
            },
            new Band
            {
                Id = 12,
                Name = "Skinny Puppy",
                Description = "Skinny Puppy är ett kanadensiskt band i genren industrial som bildades 1982 i Vancouver i British Columbia.",
                ImageUrl = "/images/SkinnyPuppy.jpg",
                Spot = "3407VUJZNjRiZDy3DS1JiQ",
            },
            new Band
            {
                Id = 13,
                Name = "Sweet",
                Description = "Sweet (före 1974, The Sweet) var ett brittiskt rockband som bildades 1968 i London och hade sin storhetstid i mitten av 1970-talet. Den mest kända och framgångsrika uppsättningen av bandet bestod av Brian Connolly (sång), Steve Priest (bas), Andy Scott (gitarr) och Mick Tucker (trummor). Sweet började sin karriär som ett tuggummipopband och gruppens tidiga stora hitlåtar skrevs av Nicky Chinn och Mike Chapman, medan singlarnas B-sidor stod till förfogande för gruppens egna låtar. Bandet gav ut sitt första studioalbum, Funny How Sweet Co-Co Can Be, 1971 och bland gruppens tidiga hits, skrivna av Chinn och Chapman, återfinns bland andra Funny Funny, The Ballroom Blitz, Hell Raiser, Poppa Joe, Wig Wam Bam och The Six Teens. Från 1974 började gruppen frångå sitt sound, till att istället spela hårdrock, och gav under året ut två studioalbum – Sweet Fanny Adams och Desolation Boulevard.",
                ImageUrl = "/images/Sweet.jpg",
                Spot = "6VO2Snr3GpwW3uAd9qZtmt",
            },
            new Band
            {
                Id = 14,
                Name = "Visage",
                Description = "Visage är en brittisk synthpopgrupp (New romantic) som bildades 1978. Deras allra mest kända låt är Fade to Grey. I början gjorde de bara musik som var tänkt att spelas på Steve Strange's och Rusty Egan's nattklubb Billy's i London. Namnet Visage ska, enligt Strange, vara en ihopsättning av Vis, för bandets VISuella sida, och Age för den nya tiden (eng. age) inom dansmusiken.",
                ImageUrl = "/images/Visage.jpg",
                Spot = "3j601V2oigPTHypgq3wwCu",
            },
            new Band
            {
                Id = 15,
                Name = "Wulfband",
                Description = "De är lika ilskna och aggressiva som hemlighetsfulla och tillbakadragna. De har nyligen färdigställt sitt debutalbum. På Bodyfest i Stockholm kan man uppleva deras första officiella liveframträdande någonsin. Wulfband, like the wolf, sneaks out from the dark and attacks you. Så hotfullt presenterar skivbolaget Progress Productions sin nya signing.",
                ImageUrl = "/images/Wulfband.jpg",
                Spot = "417hSrkMWXTRb3YUP3MFHA",
            },
            new Band
            {
                Id = 16,
                Name = "Yello",
                Description = "Yello är en schweizisk synthgrupp bildad 1979 i Zürich bestående av kompositören Boris Blank och textförfattaren/sångaren Dieter Meier. Carlos Perón lämnade gruppen 1983. Yello har haft en del singlar högt upp på listorna (såsom Vicious Games, Oh Yeah och The Race) och deras kommersiella storhetstid var främst mellan 1985 och 1995. De kännetecknas dels av att de sällan väljer enkla melodier, dels av deras udda texter, om sådana saker som galna flipperspelare (Pinball cha cha), eller personer som gillar patologiska lögnare (Of course I'm lying). Deras låt Oh Yeah blev en framgång sedan den använts till filmen Fira med Ferris. Gruppens musik är mångfacetterad, men vissa element återkommer, till exempel texter på nonsensspråk, texter på många olika språk, och Dieter Meiers djupa basröst (som har modifierats elektroniskt av Boris).",
                ImageUrl = "/images/Yello.jpg",
                Spot = "5BqZGAQq2JjVcaD3mNYXra",
            },
        };

        public Band GetBandById(int id)
        {
            return bands
                .Where(e => e.Id == id)
                .Single();
        }

        public Band[] GetAllBands()
        {
            return bands
                .OrderBy(b => b.Name)
                .ToArray();
        }
    }
}
