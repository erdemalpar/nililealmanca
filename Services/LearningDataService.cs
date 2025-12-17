using System.Collections.Generic;
using GermanLearningApp.Mvc.Models;

namespace GermanLearningApp.Mvc.Services
{
    public class LearningDataService
    {
        public List<string> GetFunPrizes()
        {
            return new List<string>
            {
                "🌟 Harika!", "👑 Süpersin!", "💯 Tam isabet!", "🎉 Zafer!",
                "🏆 Şampiyon!", "🚀 Roket Hızı!", "🇩🇪 Mükemmel Almanca!", "✨ Işık Hızında!"
            };
        }

        public List<Lesson> GetLessons()
        {
            return new List<Lesson>
            {
                new Lesson
                {
                    Id = 1,
                    Title = "1. Günlük Konuşma Kelimeleri 👋",
                    Content = "Almanca iletişim kurmanın temeli selamlaşma ve nazik ifadelerden geçer. Birine teşekkür etmek, özür dilemek veya sadece 'Merhaba' demek için bu sihirli kelimeleri kullan.",
                    KeyPhrases = new List<string> { "Hallo", "Guten Morgen", "Danke schön", "Bitte schön", "Entschuldigung" },
                    FunFact = "Almanya'da telefon açıldığında genellikle 'Alo' denmez, kişi doğrudan kendi soyadını söyleyerek telefonu açar.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Sabahları insanlara nasıl selam verirsin?", Options = new List<string> { "Guten Abend", "Gute Nacht", "Guten Morgen" }, Answer = "Guten Morgen" },
                        new QuizQuestion { Id = 2, Question = "Birine teşekkür etmek için ne dersin?", Options = new List<string> { "Bitte", "Danke", "Entschuldigung" }, Answer = "Danke" },
                        new QuizQuestion { Id = 3, Question = "'Rica ederim' veya 'Lütfen' anlamına gelen kelime hangisidir?", Options = new List<string> { "Hallo", "Bitte", "Nein" }, Answer = "Bitte" },
                        new QuizQuestion { Id = 4, Question = "Bir hata yaptığında nasıl özür dilersin?", Options = new List<string> { "Entschuldigung", "Danke", "Hallo" }, Answer = "Entschuldigung" },
                        new QuizQuestion { Id = 5, Question = "En basit 'Merhaba' deme şekli nedir?", Options = new List<string> { "Tschüss", "Hallo", "Auf Wiedersehen" }, Answer = "Hallo" },
                        new QuizQuestion { Id = 6, Question = "Akşamları nasıl selam verilir?", Options = new List<string> { "Guten Tag", "Guten Abend", "Morgen" }, Answer = "Guten Abend" },
                        new QuizQuestion { Id = 7, Question = "Gece yatmadan önce ne söylenir?", Options = new List<string> { "Gute Nacht", "Hallo", "Tschüss" }, Answer = "Gute Nacht" },
                        new QuizQuestion { Id = 8, Question = "Resmi bir şekilde 'Görüşürüz' demek?", Options = new List<string> { "Ciao", "Auf Wiedersehen", "Bis bald" }, Answer = "Auf Wiedersehen" },
                        new QuizQuestion { Id = 9, Question = "Arkadaşına 'Hoşçakal' (Samimi) demek için?", Options = new List<string> { "Tschüss", "Entschuldigung", "Bitte" }, Answer = "Tschüss" },
                        new QuizQuestion { Id = 10, Question = "'Sonra görüşürüz' anlamına gelen söz?", Options = new List<string> { "Bis später", "Danke", "Nein" }, Answer = "Bis später" },
                        new QuizQuestion { Id = 11, Question = "'Nasılsın?' sorusu hangisidir?", Options = new List<string> { "Wie heißt du?", "Wie geht's?", "Wer bist du?" }, Answer = "Wie geht's?" },
                        new QuizQuestion { Id = 12, Question = "'İyiyim' (Mir geht's gut) cevabının anlamı?", Options = new List<string> { "Kötüyüm", "İyiyim", "Yorgunum" }, Answer = "İyiyim" },
                        new QuizQuestion { Id = 13, Question = "'Evet' kelimesinin Almancası?", Options = new List<string> { "Ja", "Nein", "Vielleicht" }, Answer = "Ja" },
                        new QuizQuestion { Id = 14, Question = "'Hayır' kelimesinin Almancası?", Options = new List<string> { "Doch", "Nein", "Ja" }, Answer = "Nein" },
                        new QuizQuestion { Id = 15, Question = "'Çok iyi' (Sehr gut) ne demektir?", Options = new List<string> { "Çok iyi", "Fena değil", "Kötü" }, Answer = "Çok iyi" },
                        new QuizQuestion { Id = 16, Question = "Resmi bir şekilde 'Affedersiniz' demek?", Options = new List<string> { "Entschuldigen Sie", "Sorry", "Hoppla" }, Answer = "Entschuldigen Sie" },
                        new QuizQuestion { Id = 17, Question = "'Hoş geldiniz' nasıl denir?", Options = new List<string> { "Willkommen", "Weggehen", "Tschüss" }, Answer = "Willkommen" },
                        new QuizQuestion { Id = 18, Question = "'Benim adım...' (Ich heiße...)", Options = new List<string> { "İsmim...", "Senin adın...", "Onun adı..." }, Answer = "İsmim..." },
                        new QuizQuestion { Id = 19, Question = "'İyi' (Gut) kelimesinin anlamı?", Options = new List<string> { "Kötü", "İyi", "Orta" }, Answer = "İyi" },
                        new QuizQuestion { Id = 20, Question = "'Güle güle' demenin başka bir yolu?", Options = new List<string> { "Bis bald", "Hallo", "Tag" }, Answer = "Bis bald" }
                    }
                },
                new Lesson
                {
                    Id = 2,
                    Title = "2. Örnek Diyaloglar 🗣️",
                    Content = "Tanışma vakti! Yeni biriyle tanıştığında ismini sormayı, kendini tanıtmayı ve hal hatır sormayı öğrenelim. Kısa diyaloglar seni konuşmaya hazırlar.",
                    KeyPhrases = new List<string> { "Wie heißt du?", "Ich heiße...", "Wie geht's?", "Mir geht's gut", "Freut mich" },
                    FunFact = "Almancada 'Wie geht's?' (Nasılsın?) sorusuna sadece 'Gut' (İyi) demek yerine, 'Es geht' (İdare eder) demek de çok yaygındır.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Adın ne?' sorusunun Almancası nedir?", Options = new List<string> { "Wer bist du?", "Wie heißt du?", "Was machst du?" }, Answer = "Wie heißt du?" },
                        new QuizQuestion { Id = 2, Question = "'Benim adım...' diyerek cümleye nasıl başlarsın?", Options = new List<string> { "Du heißt...", "Ich heiße...", "Er heißt..." }, Answer = "Ich heiße..." },
                        new QuizQuestion { Id = 3, Question = "'Nasılsın?' diye sormak için hangisi kullanılır?", Options = new List<string> { "Wie geht's?", "Wo wohnst du?", "Wie alt bist du?" }, Answer = "Wie geht's?" },
                        new QuizQuestion { Id = 4, Question = "'İyiyim' cevabı hangisidir?", Options = new List<string> { "Mir geht's gut", "Ich bin müde", "Schlecht" }, Answer = "Mir geht's gut" },
                        new QuizQuestion { Id = 5, Question = "Tanıştığımıza memnun oldum demek için:", Options = new List<string> { "Danke", "Freut mich", "Bitte" }, Answer = "Freut mich" },
                        new QuizQuestion { Id = 6, Question = "'Nerelisin?' sorusu hangisidir?", Options = new List<string> { "Woher kommst du?", "Wohin gehst du?", "Wer bist du?" }, Answer = "Woher kommst du?" },
                        new QuizQuestion { Id = 7, Question = "'Ben Türkiyeliyim' (Ich komme aus der Türkei) cümlesindeki fiil?", Options = new List<string> { "komme", "gehe", "wohne" }, Answer = "komme" },
                        new QuizQuestion { Id = 8, Question = "'Nerede oturuyorsun?' sorusu?", Options = new List<string> { "Wo wohnst du?", "Wie heißt du?", "Was machst du?" }, Answer = "Wo wohnst du?" },
                        new QuizQuestion { Id = 9, Question = "'Berlin'de oturuyorum' (Ich wohne in Berlin) cümlesindeki fiil?", Options = new List<string> { "wohne", "komme", "bin" }, Answer = "wohne" },
                        new QuizQuestion { Id = 10, Question = "'Kaç yaşındasın?' sorusu?", Options = new List<string> { "Wie alt bist du?", "Wie spät ist es?", "Wie geht es dir?" }, Answer = "Wie alt bist du?" },
                        new QuizQuestion { Id = 11, Question = "'Ben 20 yaşındayım' (Ich bin 20 Jahre alt) cümlesi doğru mu?", Options = new List<string> { "Evet", "Hayır", "Belki" }, Answer = "Evet" },
                        new QuizQuestion { Id = 12, Question = "'Bu kim?' (Wer ist das?) sorusunun cevabı?", Options = new List<string> { "Das ist Ali", "Das ist ein Auto", "Das ist blau" }, Answer = "Das ist Ali" },
                        new QuizQuestion { Id = 13, Question = "'Almanca konuşuyor musun?' sorusu?", Options = new List<string> { "Sprichst du Deutsch?", "Lernst du Deutsch?", "Schreibst du Deutsch?" }, Answer = "Sprichst du Deutsch?" },
                        new QuizQuestion { Id = 14, Question = "'Biraz' (Ein bisschen) ne demektir?", Options = new List<string> { "Çok", "Hiç", "Biraz" }, Answer = "Biraz" },
                        new QuizQuestion { Id = 15, Question = "'Anlamıyorum' ifadesi hangisidir?", Options = new List<string> { "Ich verstehe nicht", "Ich weiß", "Ich sehe" }, Answer = "Ich verstehe nicht" },
                        new QuizQuestion { Id = 16, Question = "'Lütfen tekrar edin' demek için?", Options = new List<string> { "Wiederholen Sie bitte", "Danke", "Hallo" }, Answer = "Wiederholen Sie bitte" },
                        new QuizQuestion { Id = 17, Question = "'Bu nedir?' (Was ist das?) sorusu?", Options = new List<string> { "Was ist das?", "Wer ist das?", "Wo ist das?" }, Answer = "Was ist das?" },
                        new QuizQuestion { Id = 18, Question = "'Kim' (Wer) ne anlama gelir?", Options = new List<string> { "Ne", "Kim", "Nerede" }, Answer = "Kim" },
                        new QuizQuestion { Id = 19, Question = "'Ne' (Was) ne anlama gelir?", Options = new List<string> { "Ne", "Kim", "Neden" }, Answer = "Ne" },
                        new QuizQuestion { Id = 20, Question = "Vedalaşırken 'Tschüss' demek resmi midir?", Options = new List<string> { "Hayır, samimidir", "Evet, resmidir", "Farketmez" }, Answer = "Hayır, samimidir" }
                    }
                },
                new Lesson
                {
                    Id = 3,
                    Title = "3. Fiiller (Eylemler) 🏃",
                    Content = "Hayat harekettir! Almanca cümle kurmak için en sık kullanılan fiilleri öğrenmelisin. Yapmak, gelmek, gitmek ve oynamak gibi temel eylemlerle başla.",
                    KeyPhrases = new List<string> { "machen (yapmak)", "kommen (gelmek)", "gehen (gitmek)", "spielen (oynamak)", "wohnen (oturmak/yaşamak)" },
                    FunFact = "Almanca fiillerin mastar hali genellikle '-en' ile biter (machen, kommen). Cümle içinde bu takı kişiye göre değişir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Oynamak' fiilinin Almancası nedir?", Options = new List<string> { "lernen", "spielen", "singen" }, Answer = "spielen" },
                        new QuizQuestion { Id = 2, Question = "'Kommen' ne anlama gelir?", Options = new List<string> { "Gitmek", "Gelmek", "Koşmak" }, Answer = "Gelmek" },
                        new QuizQuestion { Id = 3, Question = "'Yapmak' fiili hangisidir?", Options = new List<string> { "machen", "lachen", "kochen" }, Answer = "machen" },
                        new QuizQuestion { Id = 4, Question = "'Bir yerde ikamet etmek/yaşamak' anlamındaki fiil?", Options = new List<string> { "wohnen", "gehen", "sagen" }, Answer = "wohnen" },
                        new QuizQuestion { Id = 5, Question = "'Gehen' fiilinin anlamı nedir?", Options = new List<string> { "Durmak", "Gitmek", "Yemek" }, Answer = "Gitmek" },
                        new QuizQuestion { Id = 6, Question = "'Yemek yemek' fiili?", Options = new List<string> { "essen", "trinken", "schlafen" }, Answer = "essen" },
                        new QuizQuestion { Id = 7, Question = "'İçmek' (Su vb.) fiili?", Options = new List<string> { "trinken", "essen", "laufen" }, Answer = "trinken" },
                        new QuizQuestion { Id = 8, Question = "'Uyumak' fiilinin Almancası?", Options = new List<string> { "schlafen", "wachen", "stehen" }, Answer = "schlafen" },
                        new QuizQuestion { Id = 9, Question = "'Yazmak' fiili hangisidir?", Options = new List<string> { "schreiben", "lesen", "sprechen" }, Answer = "schreiben" },
                        new QuizQuestion { Id = 10, Question = "'Okumak' fiili?", Options = new List<string> { "lesen", "sehen", "hören" }, Answer = "lesen" },
                        new QuizQuestion { Id = 11, Question = "'Konuşmak' (Sprechen) ne demektir?", Options = new List<string> { "Konuşmak", "Susmak", "Bağırmak" }, Answer = "Konuşmak" },
                        new QuizQuestion { Id = 12, Question = "'Öğrenmek' (Okulda vb.) fiili?", Options = new List<string> { "lernen", "lehren", "wissen" }, Answer = "lernen" },
                        new QuizQuestion { Id = 13, Question = "'Sahip olmak' (Haben) fiili?", Options = new List<string> { "haben", "sein", "werden" }, Answer = "haben" },
                        new QuizQuestion { Id = 14, Question = "'Olmak' (Sein) fiili?", Options = new List<string> { "sein", "haben", "tun" }, Answer = "sein" },
                        new QuizQuestion { Id = 15, Question = "'Görmek' fiili hangisidir?", Options = new List<string> { "sehen", "hören", "fühlen" }, Answer = "sehen" },
                        new QuizQuestion { Id = 16, Question = "'Duymak' fiili?", Options = new List<string> { "hören", "riechen", "schmecken" }, Answer = "hören" },
                        new QuizQuestion { Id = 17, Question = "'Satın almak' fiili?", Options = new List<string> { "kaufen", "verkaufen", "geben" }, Answer = "kaufen" },
                        new QuizQuestion { Id = 18, Question = "'Çalışmak' (İş anlamında) fiili?", Options = new List<string> { "arbeiten", "spielen", "reisen" }, Answer = "arbeiten" },
                        new QuizQuestion { Id = 19, Question = "'Soru sormak' (Fragen) fiili?", Options = new List<string> { "fragen", "antworten", "sagen" }, Answer = "fragen" },
                        new QuizQuestion { Id = 20, Question = "'Cevap vermek' (Antworten) fiili?", Options = new List<string> { "antworten", "fragen", "machen" }, Answer = "antworten" }
                    }
                },
                new Lesson
                {
                    Id = 4,
                    Title = "4. Renkler 🎨",
                    Content = "Dünyayı renklendir! Gökkuşağının renklerini ve etrafındaki nesneleri tanımlamayı öğren. Renkler sıfat olarak her yerde karşına çıkacak.",
                    KeyPhrases = new List<string> { "rot (kırmızı)", "blau (mavi)", "grün (yeşil)", "gelb (sarı)", "schwarz (siyah)" },
                    FunFact = "Almancada 'mavi olmak' (blau sein) deyimi sarhoş olmak anlamına gelir, bu yüzden renkleri kullanırken dikkatli ol!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Güneşin rengi (sarı) Almanca nedir?", Options = new List<string> { "rot", "gelb", "blau" }, Answer = "gelb" },
                        new QuizQuestion { Id = 2, Question = "'Kırmızı' rengin Almancası?", Options = new List<string> { "rot", "grün", "grau" }, Answer = "rot" },
                        new QuizQuestion { Id = 3, Question = "Gökyüzü (mavi) hangi renktir?", Options = new List<string> { "schwarz", "blau", "weiß" }, Answer = "blau" },
                        new QuizQuestion { Id = 4, Question = "Çimenlerin rengi (yeşil) nedir?", Options = new List<string> { "gelb", "lila", "grün" }, Answer = "grün" },
                        new QuizQuestion { Id = 5, Question = "'Schwarz' hangi renktir?", Options = new List<string> { "Beyaz", "Siyah", "Kahverengi" }, Answer = "Siyah" },
                        new QuizQuestion { Id = 6, Question = "'Beyaz' rengin Almancası?", Options = new List<string> { "weiß", "schwarz", "grau" }, Answer = "weiß" },
                        new QuizQuestion { Id = 7, Question = "'Gri' rengin Almancası?", Options = new List<string> { "grau", "braun", "rot" }, Answer = "grau" },
                        new QuizQuestion { Id = 8, Question = "'Kahverengi' hangi renktir?", Options = new List<string> { "braun", "blau", "bunt" }, Answer = "braun" },
                        new QuizQuestion { Id = 9, Question = "'Pembe' (Rosa) rengi?", Options = new List<string> { "rosa", "lila", "rot" }, Answer = "rosa" },
                        new QuizQuestion { Id = 10, Question = "'Mor' rengin Almancası?", Options = new List<string> { "lila", "gelb", "grün" }, Answer = "lila" },
                        new QuizQuestion { Id = 11, Question = "'Turuncu' hangi renktir?", Options = new List<string> { "orange", "rot", "weiß" }, Answer = "orange" },
                        new QuizQuestion { Id = 12, Question = "'Açık mavi' (Hellblau) ne demektir?", Options = new List<string> { "Açık mavi", "Koyu mavi", "Yeşil" }, Answer = "Açık mavi" },
                        new QuizQuestion { Id = 13, Question = "'Koyu kırmızı' (Dunkelrot) ne demektir?", Options = new List<string> { "Koyu kırmızı", "Açık kırmızı", "Pembe" }, Answer = "Koyu kırmızı" },
                        new QuizQuestion { Id = 14, Question = "'Renk' (Farbe) kelimesinin anlamı?", Options = new List<string> { "Renk", "Boy", "Şekil" }, Answer = "Renk" },
                        new QuizQuestion { Id = 15, Question = "'Renkli' (Bunt) ne demektir?", Options = new List<string> { "Renkli", "Siyah-beyaz", "Karanlık" }, Answer = "Renkli" },
                        new QuizQuestion { Id = 16, Question = "'Gümüş' rengi?", Options = new List<string> { "silber", "gold", "kupfer" }, Answer = "silber" },
                        new QuizQuestion { Id = 17, Question = "'Altın' rengi?", Options = new List<string> { "gold", "silber", "gelb" }, Answer = "gold" },
                        new QuizQuestion { Id = 18, Question = "Kar (Schnee) hangi renktir?", Options = new List<string> { "weiß", "schwarz", "rot" }, Answer = "weiß" },
                        new QuizQuestion { Id = 19, Question = "Gece (Nacht) genellikle hangi renkle ilişkilendirilir?", Options = new List<string> { "schwarz", "weiß", "gelb" }, Answer = "schwarz" },
                        new QuizQuestion { Id = 20, Question = "Portakal (meyve) hangi renktir?", Options = new List<string> { "orange", "blau", "grau" }, Answer = "orange" }
                    }
                },
                new Lesson
                {
                    Id = 5,
                    Title = "5. Sayılar 🔢",
                    Content = "Matematiğin temeli! 0'dan 20'ye kadar saymayı öğreniyoruz. Alışverişte, saatlerde ve tarihlerde sayılar her zaman gereklidir.",
                    KeyPhrases = new List<string> { "eins (1)", "zwei (2)", "drei (3)", "zehn (10)", "zwanzig (20)" },
                    FunFact = "Almancada 1 rakamı tek başına sayarken 'eins' denir, ancak bir şeyden bahsederken (bir araba gibi) duruma göre 'ein' veya 'eine' olur.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "3 sayısının Almancası nedir?", Options = new List<string> { "zwei", "drei", "vier" }, Answer = "drei" },
                        new QuizQuestion { Id = 2, Question = "'Zehn' hangi sayıdır?", Options = new List<string> { "10", "12", "20" }, Answer = "10" },
                        new QuizQuestion { Id = 3, Question = "1 sayısının Almancası?", Options = new List<string> { "eins", "elf", "null" }, Answer = "eins" },
                        new QuizQuestion { Id = 4, Question = "'Yirmi' sayısı nasıldır?", Options = new List<string> { "zwölf", "zwanzig", "zwei" }, Answer = "zwanzig" },
                        new QuizQuestion { Id = 5, Question = "8 sayısının Almancası nedir?", Options = new List<string> { "acht", "nacht", "sechs" }, Answer = "acht" },
                        new QuizQuestion { Id = 6, Question = "'Sıfır' (0) Almanca nedir?", Options = new List<string> { "null", "eins", "zehn" }, Answer = "null" },
                        new QuizQuestion { Id = 7, Question = "'İki' (2) sayısı?", Options = new List<string> { "zwei", "drei", "vier" }, Answer = "zwei" },
                        new QuizQuestion { Id = 8, Question = "'Dört' (4) sayısı?", Options = new List<string> { "vier", "fünf", "sechs" }, Answer = "vier" },
                        new QuizQuestion { Id = 9, Question = "'Beş' (5) sayısı?", Options = new List<string> { "fünf", "sechs", "sieben" }, Answer = "fünf" },
                        new QuizQuestion { Id = 10, Question = "'Altı' (6) sayısı?", Options = new List<string> { "sechs", "sieben", "acht" }, Answer = "sechs" },
                        new QuizQuestion { Id = 11, Question = "'Yedi' (7) sayısı?", Options = new List<string> { "sieben", "acht", "neun" }, Answer = "sieben" },
                        new QuizQuestion { Id = 12, Question = "'Dokuz' (9) sayısı?", Options = new List<string> { "neun", "zehn", "elf" }, Answer = "neun" },
                        new QuizQuestion { Id = 13, Question = "'On bir' (11) sayısı?", Options = new List<string> { "elf", "zwölf", "dreizehn" }, Answer = "elf" },
                        new QuizQuestion { Id = 14, Question = "'On iki' (12) sayısı?", Options = new List<string> { "zwölf", "elf", "zehn" }, Answer = "zwölf" },
                        new QuizQuestion { Id = 15, Question = "'On üç' (13) sayısı?", Options = new List<string> { "dreizehn", "vierzehn", "fünfzehn" }, Answer = "dreizehn" },
                        new QuizQuestion { Id = 16, Question = "'On dört' (14) sayısı?", Options = new List<string> { "vierzehn", "fünfzehn", "sechzehn" }, Answer = "vierzehn" },
                        new QuizQuestion { Id = 17, Question = "'On beş' (15) sayısı?", Options = new List<string> { "fünfzehn", "sechzehn", "siebzehn" }, Answer = "fünfzehn" },
                        new QuizQuestion { Id = 18, Question = "'On altı' (16) sayısı?", Options = new List<string> { "sechzehn", "siebzehn", "achtzehn" }, Answer = "sechzehn" },
                        new QuizQuestion { Id = 19, Question = "'On yedi' (17) sayısı?", Options = new List<string> { "siebzehn", "achtzehn", "neunzehn" }, Answer = "siebzehn" },
                        new QuizQuestion { Id = 20, Question = "'On sekiz' (18) sayısı?", Options = new List<string> { "achtzehn", "neunzehn", "zwanzig" }, Answer = "achtzehn" }
                    }
                },
                // Add remaining lessons here if needed, keeping it concise for now or I can add all.
                // Let's add 6-10 to be complete as it is best for user experience.
                 new Lesson
                {
                    Id = 6,
                    Title = "6. Yer Yön ve Tarif 📍",
                    Content = "Kedi nerede? Masanın altında mı, üstünde mi? Nesnelerin konumunu anlatmak için edatları (prepositions) öğrenelim.",
                    KeyPhrases = new List<string> { "vor (önünde)", "hinter (arkasında)", "neben (yanında)", "auf (üstünde)", "unter (altında)" },
                    FunFact = "Almancada yön edatları, nesnenin hareket edip etmediğine göre (Dativ veya Akkusativ) ismin halini değiştirir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Bir şeyin 'üstünde' olduğunu nasıl söylersin?", Options = new List<string> { "unter", "auf", "in" }, Answer = "auf" },
                        new QuizQuestion { Id = 2, Question = "'Hinter' kelimesinin anlamı nedir?", Options = new List<string> { "Arkasında", "Önünde", "İçinde" }, Answer = "Arkasında" },
                        new QuizQuestion { Id = 3, Question = "'Yanında' demek için hangi kelime kullanılır?", Options = new List<string> { "neben", "zwischen", "über" }, Answer = "neben" },
                        new QuizQuestion { Id = 4, Question = "Masanın 'altında' demek istersen:", Options = new List<string> { "auf", "unter", "vor" }, Answer = "unter" },
                        new QuizQuestion { Id = 5, Question = "'Vor' ne anlama gelir?", Options = new List<string> { "Arkada", "Önünde", "Üstte" }, Answer = "Önünde" },
                        new QuizQuestion { Id = 6, Question = "'İçinde' kelimesinin Almancası?", Options = new List<string> { "in", "an", "auf" }, Answer = "in" },
                        new QuizQuestion { Id = 7, Question = "Bir şeyin 'üzerinde' (temas etmeden) olması?", Options = new List<string> { "über", "unter", "neben" }, Answer = "über" },
                        new QuizQuestion { Id = 8, Question = "'Arasında' ne demektir?", Options = new List<string> { "zwischen", "inmitten", "durch" }, Answer = "zwischen" },
                        new QuizQuestion { Id = 9, Question = "'Sol' taraf Almanca?", Options = new List<string> { "links", "rechts", "gerade" }, Answer = "links" },
                        new QuizQuestion { Id = 10, Question = "'Sağ' taraf Almanca?", Options = new List<string> { "rechts", "links", "oben" }, Answer = "rechts" },
                        new QuizQuestion { Id = 11, Question = "'Dosdoğru' (Geradeaus) ne demektir?", Options = new List<string> { "Dosdoğru", "Geri", "Dön" }, Answer = "Dosdoğru" },
                        new QuizQuestion { Id = 12, Question = "'Burada' (Hier) kelimesi?", Options = new List<string> { "Hier", "Da", "Dort" }, Answer = "Hier" },
                        new QuizQuestion { Id = 13, Question = "'Orada' (Dort) kelimesi?", Options = new List<string> { "Dort", "Hier", "Wo" }, Answer = "Dort" },
                        new QuizQuestion { Id = 14, Question = "'Yukarı' (Oben) ne demektir?", Options = new List<string> { "Oben", "Unten", "Links" }, Answer = "Oben" },
                        new QuizQuestion { Id = 15, Question = "'Aşağı' (Unten) ne demektir?", Options = new List<string> { "Unten", "Oben", "Rechts" }, Answer = "Unten" },
                        new QuizQuestion { Id = 16, Question = "'Uzak' (Weit) kelimesinin anlamı?", Options = new List<string> { "Uzak", "Yakın", "Kısa" }, Answer = "Uzak" },
                        new QuizQuestion { Id = 17, Question = "'Yakın' (Nah) kelimesinin anlamı?", Options = new List<string> { "Yakın", "Uzak", "Geniş" }, Answer = "Yakın" },
                        new QuizQuestion { Id = 18, Question = "'Nerede?' sorusu?", Options = new List<string> { "Wo?", "Wohin?", "Woher?" }, Answer = "Wo?" },
                        new QuizQuestion { Id = 19, Question = "'Nereye?' sorusu?", Options = new List<string> { "Wohin?", "Wo?", "Wann?" }, Answer = "Wohin?" },
                        new QuizQuestion { Id = 20, Question = "Duvarın 'bitişiğinde' (an) demek için?", Options = new List<string> { "an", "in", "auf" }, Answer = "an" }
                    }
                },
                 new Lesson
                {
                    Id = 7,
                    Title = "7. Tarih ve Saat ⏰",
                    Content = "Zamanı yakala! Haftanın günlerini, ayları ve saatin kaç olduğunu sormayı öğreniyoruz. Randevulara geç kalmamak için önemli!",
                    KeyPhrases = new List<string> { "Montag (Pazartesi)", "Sonntag (Pazar)", "Wieviel Uhr ist es?", "Es ist drei Uhr", "Heute (Bugün)" },
                    FunFact = "Almanya'da saat söylerken genellikle 24 saatlik dilim kullanılır (13:00, 14:00 gibi), özellikle resmi durumlarda.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Haftanın ilk günü (Pazartesi) Almanca nedir?", Options = new List<string> { "Dienstag", "Montag", "Freitag" }, Answer = "Montag" },
                        new QuizQuestion { Id = 2, Question = "'Saat kaç?' sorusu hangisidir?", Options = new List<string> { "Wie heißt du?", "Wieviel Uhr ist es?", "Wo bist du?" }, Answer = "Wieviel Uhr ist es?" },
                        new QuizQuestion { Id = 3, Question = "'Pazar' günü hangisidir?", Options = new List<string> { "Sonntag", "Samstag", "Mittwoch" }, Answer = "Sonntag" },
                        new QuizQuestion { Id = 4, Question = "'Bugün' kelimesinin karşılığı nedir?", Options = new List<string> { "Morgen", "Gestern", "Heute" }, Answer = "Heute" },
                        new QuizQuestion { Id = 5, Question = "'Saat 3' demek için:", Options = new List<string> { "Es ist drei Uhr", "Es ist fünf Uhr", "Drei Uhr" }, Answer = "Es ist drei Uhr" },
                        new QuizQuestion { Id = 6, Question = "'Salı' günü Almanca?", Options = new List<string> { "Dienstag", "Mittwoch", "Montag" }, Answer = "Dienstag" },
                        new QuizQuestion { Id = 7, Question = "'Çarşamba' günü?", Options = new List<string> { "Mittwoch", "Freitag", "Samstag" }, Answer = "Mittwoch" },
                        new QuizQuestion { Id = 8, Question = "'Perşembe' günü?", Options = new List<string> { "Donnerstag", "Dienstag", "Sonntag" }, Answer = "Donnerstag" },
                        new QuizQuestion { Id = 9, Question = "'Cuma' günü?", Options = new List<string> { "Freitag", "Montag", "Samstag" }, Answer = "Freitag" },
                        new QuizQuestion { Id = 10, Question = "'Cumartesi' günü?", Options = new List<string> { "Samstag", "Sonntag", "Freitag" }, Answer = "Samstag" },
                        new QuizQuestion { Id = 11, Question = "'Yarın' (Morgen) ne demektir?", Options = new List<string> { "Yarın", "Dün", "Bugün" }, Answer = "Yarın" },
                        new QuizQuestion { Id = 12, Question = "'Dün' (Gestern) ne demektir?", Options = new List<string> { "Dün", "Yarın", "Şimdi" }, Answer = "Dün" },
                        new QuizQuestion { Id = 13, Question = "'Gün' (Tag) kelimesi?", Options = new List<string> { "Tag", "Nacht", "Woche" }, Answer = "Tag" },
                        new QuizQuestion { Id = 14, Question = "'Hafta' (Woche) kelimesi?", Options = new List<string> { "Woche", "Monat", "Jahr" }, Answer = "Woche" },
                        new QuizQuestion { Id = 15, Question = "'Ay' (Monat) kelimesi?", Options = new List<string> { "Monat", "Jahr", "Tag" }, Answer = "Monat" },
                        new QuizQuestion { Id = 16, Question = "'Yıl' (Jahr) kelimesi?", Options = new List<string> { "Jahr", "Monat", "Zeit" }, Answer = "Jahr" },
                        new QuizQuestion { Id = 17, Question = "'Dakika' (Minute) Almanca?", Options = new List<string> { "Minute", "Stunde", "Sekunde" }, Answer = "Minute" },
                        new QuizQuestion { Id = 18, Question = "'Saniye' (Sekunde) Almanca?", Options = new List<string> { "Sekunde", "Minute", "Tag" }, Answer = "Sekunde" },
                        new QuizQuestion { Id = 19, Question = "'Öğlen' (Mittag) vakti?", Options = new List<string> { "Mittag", "Abend", "Morgen" }, Answer = "Mittag" },
                        new QuizQuestion { Id = 20, Question = "'Gece yarısı' (Mitternacht)?", Options = new List<string> { "Mitternacht", "Mittag", "Morgen" }, Answer = "Mitternacht" }
                    }
                },
                 new Lesson
                {
                    Id = 8,
                    Title = "8. Meyveler ve Sebzeler 🍎",
                    Content = "Pazara gidiyoruz! En sevilen meyve ve sebzelerin isimlerini öğren. Sağlıklı beslenmek için kelime dağarcığını genişlet.",
                    KeyPhrases = new List<string> { "der Apfel (elma)", "die Banane (muz)", "die Tomate (domates)", "die Kartoffel (patates)", "die Orange (portakal)" },
                    FunFact = "Patates (Kartoffel) Alman mutfağının kralıdır. Kızartması, püresi, salatası... Her haliyle çok sevilir!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Elma' kelimesinin Almancası?", Options = new List<string> { "die Birne", "der Apfel", "die Traube" }, Answer = "der Apfel" },
                        new QuizQuestion { Id = 2, Question = "'Die Tomate' ne demektir?", Options = new List<string> { "Patates", "Domates", "Salatalık" }, Answer = "Domates" },
                        new QuizQuestion { Id = 3, Question = "Maymunların sevdiği meyve (muz)?", Options = new List<string> { "die Banane", "die Kirsche", "die Zitrone" }, Answer = "die Banane" },
                        new QuizQuestion { Id = 4, Question = "'Patates' Almanca nedir?", Options = new List<string> { "die Karotte", "die Kartoffel", "der Kohl" }, Answer = "die Kartoffel" },
                        new QuizQuestion { Id = 5, Question = "Turuncu renkli meyve hangisidir?", Options = new List<string> { "die Orange", "der Apfel", "die Beere" }, Answer = "die Orange" },
                        new QuizQuestion { Id = 6, Question = "'Armut' (Birne) Almanca nedir?", Options = new List<string> { "die Birne", "die Beere", "die Bohne" }, Answer = "die Birne" },
                        new QuizQuestion { Id = 7, Question = "'Çilek' (Erdbeere) ne demektir?", Options = new List<string> { "Erdbeere", "Himbeere", "Blaubeere" }, Answer = "Erdbeere" },
                        new QuizQuestion { Id = 8, Question = "'Kiraz' (Kirsche) Almanca?", Options = new List<string> { "Kirsche", "Kürbis", "Kohl" }, Answer = "Kirsche" },
                        new QuizQuestion { Id = 9, Question = "'Üzüm' (Traube) ne demektir?", Options = new List<string> { "Traube", "Tomate", "Tee" }, Answer = "Traube" },
                        new QuizQuestion { Id = 10, Question = "'Limon' (Zitrone) Almanca?", Options = new List<string> { "Zitrone", "Zwiebel", "Zucker" }, Answer = "Zitrone" },
                        new QuizQuestion { Id = 11, Question = "'Karpuz' (Wassermelone) ne demektir?", Options = new List<string> { "Wassermelone", "Honigmelone", "Wasser" }, Answer = "Wassermelone" },
                        new QuizQuestion { Id = 12, Question = "'Havuç' (Karotte) Almanca?", Options = new List<string> { "Karotte", "Kartoffel", "Kohl" }, Answer = "Karotte" },
                        new QuizQuestion { Id = 13, Question = "'Salatalık' (Gurke) ne demektir?", Options = new List<string> { "Gurke", "Gabel", "Glas" }, Answer = "Gurke" },
                        new QuizQuestion { Id = 14, Question = "'Soğan' (Zwiebel) Almanca?", Options = new List<string> { "Zwiebel", "Zitrone", "Zucker" }, Answer = "Zwiebel" },
                        new QuizQuestion { Id = 15, Question = "'Salata' (Salat) kelimesi?", Options = new List<string> { "Salat", "Salz", "Saft" }, Answer = "Salat" },
                        new QuizQuestion { Id = 16, Question = "'Meyve' (Obst) ne demektir?", Options = new List<string> { "Obst", "Gemüse", "Essen" }, Answer = "Obst" },
                        new QuizQuestion { Id = 17, Question = "'Sebze' (Gemüse) ne demektir?", Options = new List<string> { "Gemüse", "Obst", "Fleisch" }, Answer = "Gemüse" },
                        new QuizQuestion { Id = 18, Question = "'Biber' (Paprika) Almanca?", Options = new List<string> { "Paprika", "Pfeffer", "Pilz" }, Answer = "Paprika" },
                        new QuizQuestion { Id = 19, Question = "'Fasulye' (Bohne) ne demektir?", Options = new List<string> { "Bohne", "Birne", "Brot" }, Answer = "Bohne" },
                        new QuizQuestion { Id = 20, Question = "'Ispanak' (Spinat) Almanca?", Options = new List<string> { "Spinat", "Salat", "Spaghetti" }, Answer = "Spinat" }
                    }
                },
                 new Lesson
                {
                    Id = 9,
                    Title = "9. Yiyecekler ve İçecekler 🍞",
                    Content = "Acıktın mı? Ekmek, su, süt ve peynir gibi temel gıdaları öğrenelim. Kahvaltı sofrası hazırlamak için hazırsın.",
                    KeyPhrases = new List<string> { "das Brot (ekmek)", "das Wasser (su)", "die Milch (süt)", "der Käse (peynir)", "das Ei (yumurta)" },
                    FunFact = "Almanya, dünyada en çok ekmek çeşidine sahip ülkedir. 3000'den fazla ekmek çeşidi olduğu söylenir!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Temel gıda 'Ekmek' nedir?", Options = new List<string> { "das Brot", "der Kuchen", "das Mehl" }, Answer = "das Brot" },
                        new QuizQuestion { Id = 2, Question = "'Su' kelimesinin Almancası?", Options = new List<string> { "der Saft", "das Wasser", "der Tee" }, Answer = "das Wasser" },
                        new QuizQuestion { Id = 3, Question = "Beyaz içecek (süt) hangisidir?", Options = new List<string> { "die Milch", "das Wasser", "der Kaffee" }, Answer = "die Milch" },
                        new QuizQuestion { Id = 4, Question = "Kahvaltıda yenen 'Peynir'?", Options = new List<string> { "der Käse", "die Wurst", "das Ei" }, Answer = "der Käse" },
                        new QuizQuestion { Id = 5, Question = "'Yumurta' ne demektir?", Options = new List<string> { "das Ei", "das Eis", "der Reis" }, Answer = "das Ei" },
                        new QuizQuestion { Id = 6, Question = "'Meyve Suyu' (Saft) Almanca?", Options = new List<string> { "Saft", "Salz", "Suppe" }, Answer = "Saft" },
                        new QuizQuestion { Id = 7, Question = "'Çay' (Tee) ne demektir?", Options = new List<string> { "Tee", "Kaffee", "Milch" }, Answer = "Tee" },
                        new QuizQuestion { Id = 8, Question = "'Kahve' (Kaffee) Almanca?", Options = new List<string> { "Kaffee", "Kuchen", "Käse" }, Answer = "Kaffee" },
                        new QuizQuestion { Id = 9, Question = "'Pasta' (Kuchen) ne demektir?", Options = new List<string> { "Kuchen", "Küche", "Kochen" }, Answer = "Kuchen" },
                        new QuizQuestion { Id = 10, Question = "'Pirinç' (Reis) Almanca?", Options = new List<string> { "Reis", "Eis", "Mais" }, Answer = "Reis" },
                        new QuizQuestion { Id = 11, Question = "'Makarna' (Nudel) ne demektir?", Options = new List<string> { "Nudel", "Nadel", "Nuss" }, Answer = "Nudel" },
                        new QuizQuestion { Id = 12, Question = "'Et' (Fleisch) Almanca?", Options = new List<string> { "Fleisch", "Fisch", "Frühstück" }, Answer = "Fleisch" },
                        new QuizQuestion { Id = 13, Question = "'Balık' (Fisch) ne demektir?", Options = new List<string> { "Fisch", "Fleisch", "Flasche" }, Answer = "Fisch" },
                        new QuizQuestion { Id = 14, Question = "'Tavuk' (Hähnchen) Almanca?", Options = new List<string> { "Hähnchen", "Hahn", "Hase" }, Answer = "Hähnchen" },
                        new QuizQuestion { Id = 15, Question = "'Şeker' (Zucker) ne demektir?", Options = new List<string> { "Zucker", "Salz", "Zitrone" }, Answer = "Zucker" },
                        new QuizQuestion { Id = 16, Question = "'Tuz' (Salz) Almanca?", Options = new List<string> { "Salz", "Saft", "Sand" }, Answer = "Salz" },
                        new QuizQuestion { Id = 17, Question = "'Karabiber' (Pfeffer) ne demektir?", Options = new List<string> { "Pfeffer", "Paprika", "Pilz" }, Answer = "Pfeffer" },
                        new QuizQuestion { Id = 18, Question = "'Tereyağı' (Butter) Almanca?", Options = new List<string> { "Butter", "Brot", "Birne" }, Answer = "Butter" },
                        new QuizQuestion { Id = 19, Question = "'Çorba' (Suppe) ne demektir?", Options = new List<string> { "Suppe", "Soße", "Salat" }, Answer = "Suppe" },
                        new QuizQuestion { Id = 20, Question = "'Sıcak' (Heiß) (Çay vb. için)?", Options = new List<string> { "Heiß", "Kalt", "Warm" }, Answer = "Heiß" }
                    }
                },
                 new Lesson
                {
                    Id = 10,
                    Title = "10. Matematik İşlemleri ➕",
                    Content = "Matematik evrenseldir ama terimleri Almanca öğrenmelisin. Toplama, çıkarma, çarpma ve bölme işlemlerini ifade et.",
                    KeyPhrases = new List<string> { "plus (artı)", "minus (eksi)", "mal (çarpı)", "geteilt durch (bölü)", "ist gleich (eşittir)" },
                    FunFact = "Almancada çarpım tablosuna 'das Einmaleins' (bir kere bir) denir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Toplama işlemi (+) için ne denir?", Options = new List<string> { "minus", "plus", "mal" }, Answer = "plus" },
                        new QuizQuestion { Id = 2, Question = "Çıkarma işlemi (-) hangisidir?", Options = new List<string> { "weniger", "minus", "ohne" }, Answer = "minus" },
                        new QuizQuestion { Id = 3, Question = "'Eşittir' (=) işareti nasıl okunur?", Options = new List<string> { "ist gleich", "macht", "ergibt" }, Answer = "ist gleich" },
                        new QuizQuestion { Id = 4, Question = "Çarpma işlemi (x) için kullanılan kelime?", Options = new List<string> { "mal", "plus", "durch" }, Answer = "mal" },
                        new QuizQuestion { Id = 5, Question = "Bölme işlemi (÷) nasıl söylenir?", Options = new List<string> { "geteilt durch", "geschnitten", "getrennt" }, Answer = "geteilt durch" },
                        new QuizQuestion { Id = 6, Question = "'Sayı' (Zahl) kelimesinin Almancası?", Options = new List<string> { "Zahl", "Zeit", "Ziel" }, Answer = "Zahl" },
                        new QuizQuestion { Id = 7, Question = "'Hesaplamak' (Rechnen) ne demektir?", Options = new List<string> { "Rechnen", "Reden", "Rufen" }, Answer = "Rechnen" },
                        new QuizQuestion { Id = 8, Question = "'Hesap Makinesi' (Taschenrechner) Almanca?", Options = new List<string> { "Taschenrechner", "Tasche", "Rechner" }, Answer = "Taschenrechner" },
                        new QuizQuestion { Id = 9, Question = "'Problem/Soru' (Aufgabe) ne demektir?", Options = new List<string> { "Aufgabe", "Ausgabe", "Abgabe" }, Answer = "Aufgabe" },
                        new QuizQuestion { Id = 10, Question = "'Çözüm' (Lösung) kelimesi?", Options = new List<string> { "Lösung", "Losung", "Lesung" }, Answer = "Lösung" },
                        new QuizQuestion { Id = 11, Question = "'Kolay' (Einfach) ne demektir?", Options = new List<string> { "Einfach", "Schwer", "Hart" }, Answer = "Einfach" },
                        new QuizQuestion { Id = 12, Question = "'Zor' (Schwer) ne demektir?", Options = new List<string> { "Schwer", "Leicht", "Einfach" }, Answer = "Schwer" },
                        new QuizQuestion { Id = 13, Question = "'Doğru' (Richtig) Almanca?", Options = new List<string> { "Richtig", "Falsch", "Links" }, Answer = "Richtig" },
                        new QuizQuestion { Id = 14, Question = "'Yanlış' (Falsch) Almanca?", Options = new List<string> { "Falsch", "Richtig", "Gut" }, Answer = "Falsch" },
                        new QuizQuestion { Id = 15, Question = "'Sonuç' (Ergebnis) ne demektir?", Options = new List<string> { "Ergebnis", "Erlebnis", "Ereignis" }, Answer = "Ergebnis" },
                        new QuizQuestion { Id = 16, Question = "'Yarısı' (Hälfte) Almanca?", Options = new List<string> { "Hälfte", "Ganze", "Viertel" }, Answer = "Hälfte" },
                        new QuizQuestion { Id = 17, Question = "'İki katı' (Doppelt) ne demektir?", Options = new List<string> { "Doppelt", "Dreifach", "Einzeln" }, Answer = "Doppelt" },
                        new QuizQuestion { Id = 18, Question = "'Yüzde' (Prozent) Almanca?", Options = new List<string> { "Prozent", "Punkt", "Preis" }, Answer = "Prozent" },
                        new QuizQuestion { Id = 19, Question = "'Daha az' (Weniger) ne demektir?", Options = new List<string> { "Weniger", "Mehr", "Viel" }, Answer = "Weniger" },
                        new QuizQuestion { Id = 20, Question = "'Daha çok' (Mehr) ne demektir?", Options = new List<string> { "Mehr", "Weniger", "Wenig" }, Answer = "Mehr" }
                    }
                },
                 new Lesson
                {
                    Id = 11,
                    Title = "11. Hayvanlar 🐾",
                    Content = "Hayvanlar alemini keşfedelim! Sevimli dostlarımızın Almanca isimlerini öğreniyoruz. Evcil hayvanlardan çiftlik hayvanlarına kadar geniş bir yolculuk.",
                    KeyPhrases = new List<string> { "der Hund (köpek)", "die Katze (kedi)", "der Vogel (kuş)", "das Pferd (at)", "die Kuh (inek)" },
                    FunFact = "Almanya'da insanların en çok beslediği evcil hayvan kedidir. Yaklaşık 15 milyon kedi Alman evlerinde yaşamaktadır!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Köpek' kelimesinin Almancası nedir?", Options = new List<string> { "der Hund", "die Katze", "das Pferd" }, Answer = "der Hund" },
                        new QuizQuestion { Id = 2, Question = "Miyavlayan dostumuz (Kedi) hangisidir?", Options = new List<string> { "der Vogel", "die Maus", "die Katze" }, Answer = "die Katze" },
                        new QuizQuestion { Id = 3, Question = "'Das Pferd' ne anlama gelir?", Options = new List<string> { "İnek", "At", "Koyun" }, Answer = "At" },
                        new QuizQuestion { Id = 4, Question = "Süt veren çiftlik hayvanı (İnek)?", Options = new List<string> { "die Kuh", "der Hund", "die Ziege" }, Answer = "die Kuh" },
                        new QuizQuestion { Id = 5, Question = "'Kuş' Almanca nasıl söylenir?", Options = new List<string> { "der Fisch", "der Vogel", "der Bär" }, Answer = "der Vogel" },
                        new QuizQuestion { Id = 6, Question = "'Aslan' (Lion) Almanca?", Options = new List<string> { "der Löwe", "der Tiger", "der Bär" }, Answer = "der Löwe" },
                        new QuizQuestion { Id = 7, Question = "'Kaplan' (Tiger) Almanca?", Options = new List<string> { "der Tiger", "die Katze", "der Wolf" }, Answer = "der Tiger" },
                        new QuizQuestion { Id = 8, Question = "'Ayı' (Bear) ne demektir?", Options = new List<string> { "der Bär", "der Vogel", "die Biene" }, Answer = "der Bär" },
                        new QuizQuestion { Id = 9, Question = "'Fil' (Elephant) ne demektir?", Options = new List<string> { "der Elefant", "die Ente", "der Esel" }, Answer = "der Elefant" },
                        new QuizQuestion { Id = 10, Question = "Peynir seven küçük hayvan (Fare)?", Options = new List<string> { "die Maus", "die Laus", "das Haus" }, Answer = "die Maus" },
                        new QuizQuestion { Id = 11, Question = "'Koyun' (Sheep) Almanca?", Options = new List<string> { "das Schaf", "das Schwein", "die Kuh" }, Answer = "das Schaf" },
                        new QuizQuestion { Id = 12, Question = "'Domuz' (Pig) Almanca?", Options = new List<string> { "das Schwein", "das Schaf", "das Pferd" }, Answer = "das Schwein" },
                        new QuizQuestion { Id = 13, Question = "'Ördek' (Duck) ne demektir?", Options = new List<string> { "die Ente", "die Gans", "das Huhn" }, Answer = "die Ente" },
                        new QuizQuestion { Id = 14, Question = "Suda yaşayan hayvan (Balık)?", Options = new List<string> { "der Fisch", "der Frosch", "der Fuchs" }, Answer = "der Fisch" },
                        new QuizQuestion { Id = 15, Question = "'Maymun' (Monkey) ne demektir?", Options = new List<string> { "der Affe", "der Apfel", "die Ameise" }, Answer = "der Affe" },
                        new QuizQuestion { Id = 16, Question = "'Tavşan' (Rabbit) Almanca?", Options = new List<string> { "der Hase", "der Hund", "der Hahn" }, Answer = "der Hase" },
                        new QuizQuestion { Id = 17, Question = "'Yılan' (Snake) ne demektir?", Options = new List<string> { "die Schlange", "die Schnecke", "die Spinne" }, Answer = "die Schlange" },
                        new QuizQuestion { Id = 18, Question = "'Kurt' (Wolf) Almanca?", Options = new List<string> { "der Wolf", "der Wald", "die Wolke" }, Answer = "der Wolf" },
                        new QuizQuestion { Id = 19, Question = "'Tilki' (Fox) Almanca?", Options = new List<string> { "der Fuchs", "der Fisch", "der Frosch" }, Answer = "der Fuchs" },
                        new QuizQuestion { Id = 20, Question = "'Böcek' (Insect) ne demektir?", Options = new List<string> { "das Insekt", "die Insel", "der Igel" }, Answer = "das Insekt" }
                    }
                },
                 new Lesson
                {
                    Id = 12,
                    Title = "12. Emojiler 😎",
                    Content = "Duygularımızı ifade etmenin en renkli yolu! Emojilerin Almanca karşılıklarını öğrenelim. Gülmek, ağlamak veya aşık olmak...",
                    KeyPhrases = new List<string> { "lachen (gülmek)", "weinen (ağlamak)", "lieben (sevmek)", "wütend (kızgın)", "denken (düşünmek)" },
                    FunFact = "İlk emoji 1999 yılında Japonya'da oluşturulmuştur, ama artık evrensel bir dildir!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Gülmek' (😂) kelimesinin Almancası nedir?", Options = new List<string> { "lachen", "machen", "laufen" }, Answer = "lachen" },
                        new QuizQuestion { Id = 2, Question = "'Ağlamak' (😢) ne anlama gelir?", Options = new List<string> { "lieben", "weinen", "trinken" }, Answer = "weinen" },
                        new QuizQuestion { Id = 3, Question = "'Sevmek' (😍) için kullanılan kelime?", Options = new List<string> { "hassen", "lieben", "sehen" }, Answer = "lieben" },
                        new QuizQuestion { Id = 4, Question = "'Kızgın' (😡) olmak?", Options = new List<string> { "glücklich", "traurig", "wütend" }, Answer = "wütend" },
                        new QuizQuestion { Id = 5, Question = "Düşünen emoji (🤔) ne yapıyor?", Options = new List<string> { "denken", "schlafen", "essen" }, Answer = "denken" },
                        new QuizQuestion { Id = 6, Question = "'Mutlu' (Glücklich) ne demektir?", Options = new List<string> { "Glücklich", "Traurig", "Wütend" }, Answer = "Glücklich" },
                        new QuizQuestion { Id = 7, Question = "'Üzgün' (Traurig) ne demektir?", Options = new List<string> { "Traurig", "Lustig", "Schön" }, Answer = "Traurig" },
                        new QuizQuestion { Id = 8, Question = "'Yorgun' (Müde) ne demektir?", Options = new List<string> { "Müde", "Wach", "Fit" }, Answer = "Müde" },
                        new QuizQuestion { Id = 9, Question = "'Korkmuş' (Ängstlich) ne demektir?", Options = new List<string> { "Ängstlich", "Mutig", "Stark" }, Answer = "Ängstlich" },
                        new QuizQuestion { Id = 10, Question = "'Şaşırmış' (Überrascht) ne demektir?", Options = new List<string> { "Überrascht", "Gewohnt", "Langweilig" }, Answer = "Überrascht" },
                        new QuizQuestion { Id = 11, Question = "'Hasta' (Krank) ne demektir?", Options = new List<string> { "Krank", "Gesund", "Stark" }, Answer = "Krank" },
                        new QuizQuestion { Id = 12, Question = "'Havalı' (Cool) Almanca?", Options = new List<string> { "Cool", "Warm", "Kalt" }, Answer = "Cool" },
                        new QuizQuestion { Id = 13, Question = "'Sıkılmış' (Gelangweilt) ne demektir?", Options = new List<string> { "Gelangweilt", "Interessiert", "Spaß" }, Answer = "Gelangweilt" },
                        new QuizQuestion { Id = 14, Question = "'Utangaç' (Schüchtern) ne demektir?", Options = new List<string> { "Schüchtern", "Offen", "Laut" }, Answer = "Schüchtern" },
                        new QuizQuestion { Id = 15, Question = "'Gergin' (Nervös) ne demektir?", Options = new List<string> { "Nervös", "Ruhig", "Entspannt" }, Answer = "Nervös" },
                        new QuizQuestion { Id = 16, Question = "'Gülümsemek' (Lächeln) ne demektir?", Options = new List<string> { "Lächeln", "Lachen", "Weinen" }, Answer = "Lächeln" },
                        new QuizQuestion { Id = 17, Question = "'Öpücük' (Kuss) ne demektir?", Options = new List<string> { "Kuss", "Gruß", "Hand" }, Answer = "Kuss" },
                        new QuizQuestion { Id = 18, Question = "'Kalp' (Herz) Almanca?", Options = new List<string> { "Herz", "Hand", "Hut" }, Answer = "Herz" },
                        new QuizQuestion { Id = 19, Question = "'Yüz' (Gesicht) ne demektir?", Options = new List<string> { "Gesicht", "Geschichte", "Gewicht" }, Answer = "Gesicht" },
                        new QuizQuestion { Id = 20, Question = "'Göz' (Auge) Almanca?", Options = new List<string> { "Auge", "Ohr", "Nase" }, Answer = "Auge" }
                    }
                },
                 new Lesson
                {
                    Id = 13,
                    Title = "13. Şehirler 🏙️",
                    Content = "Şehir hayatına dalalım! Binalar, sokaklar ve ulaşım araçları... Bir turist olarak şehirde yolunu bulmak için ihtiyacın olan kelimeler.",
                    KeyPhrases = new List<string> { "die Stadt (şehir)", "die Straße (cadde/sokak)", "das Hotel (otel)", "der Bahnhof (tren istasyonu)", "die Brücke (köprü)" },
                    FunFact = "Berlin'de Venedik'ten daha fazla köprü olduğunu biliyor muydun? Yaklaşık 1700 köprü var!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Şehir' kelimesinin Almancası nedir?", Options = new List<string> { "das Dorf", "die Stadt", "das Land" }, Answer = "die Stadt" },
                        new QuizQuestion { Id = 2, Question = "Trenlerin kalktığı yer (İstasyon)?", Options = new List<string> { "der Flughafen", "der Hafen", "der Bahnhof" }, Answer = "der Bahnhof" },
                        new QuizQuestion { Id = 3, Question = "'Cadde' ne anlama gelir?", Options = new List<string> { "die Straße", "der Weg", "der Platz" }, Answer = "die Straße" },
                        new QuizQuestion { Id = 4, Question = "Konakladığımız yer (Otel)?", Options = new List<string> { "das Haus", "das Hotel", "die Schule" }, Answer = "das Hotel" },
                        new QuizQuestion { Id = 5, Question = "'Köprü' Almanca nasıl söylenir?", Options = new List<string> { "die Brücke", "der Turm", "die Mauer" }, Answer = "die Brücke" },
                        new QuizQuestion { Id = 6, Question = "'Köy' (Dorf) ne demektir?", Options = new List<string> { "Dorf", "Stadt", "Land" }, Answer = "Dorf" },
                        new QuizQuestion { Id = 7, Question = "'Ülke' (Land) ne demektir?", Options = new List<string> { "Land", "Stadt", "Fluss" }, Answer = "Land" },
                        new QuizQuestion { Id = 8, Question = "'Havalimanı' (Flughafen) Almanca?", Options = new List<string> { "Flughafen", "Bahnhof", "Hafen" }, Answer = "Flughafen" },
                        new QuizQuestion { Id = 9, Question = "'Liman' (Hafen) ne demektir?", Options = new List<string> { "Hafen", "Ofen", "Hof" }, Answer = "Hafen" },
                        new QuizQuestion { Id = 10, Question = "'Park' Almanca nasıl yazılır?", Options = new List<string> { "der Park", "die Park", "das Park" }, Answer = "der Park" },
                        new QuizQuestion { Id = 11, Question = "'Okul' (Schule) ne demektir?", Options = new List<string> { "Schule", "Schuh", "Schrank" }, Answer = "Schule" },
                        new QuizQuestion { Id = 12, Question = "'Üniversite' Almanca?", Options = new List<string> { "die Universität", "die Schule", "die Bank" }, Answer = "die Universität" },
                        new QuizQuestion { Id = 13, Question = "'Kilise' (Kirche) ne demektir?", Options = new List<string> { "Kirche", "Küche", "Kirsche" }, Answer = "Kirche" },
                        new QuizQuestion { Id = 14, Question = "'Banka' (Bank) Almanca?", Options = new List<string> { "die Bank", "der Park", "der Platz" }, Answer = "die Bank" },
                        new QuizQuestion { Id = 15, Question = "'Postane' (Post) ne demektir?", Options = new List<string> { "die Post", "das Paket", "der Brief" }, Answer = "die Post" },
                        new QuizQuestion { Id = 16, Question = "'Pazar Yeri' (Markt) Almanca?", Options = new List<string> { "Markt", "Messe", "Laden" }, Answer = "Markt" },
                        new QuizQuestion { Id = 17, Question = "'Dükkan' (Geschäft) ne demektir?", Options = new List<string> { "Geschäft", "Gebäude", "Haus" }, Answer = "Geschäft" },
                        new QuizQuestion { Id = 18, Question = "'Restoran' Almanca?", Options = new List<string> { "das Restaurant", "die Küche", "das Essen" }, Answer = "das Restaurant" },
                        new QuizQuestion { Id = 19, Question = "'Kafe' (Café) ne demektir?", Options = new List<string> { "das Café", "der Kaffee", "die Bar" }, Answer = "das Café" },
                        new QuizQuestion { Id = 20, Question = "'Otobüs Durağı' (Haltestelle)?", Options = new List<string> { "Haltestelle", "Bahnhof", "Parkplatz" }, Answer = "Haltestelle" }
                    }
                },
                 new Lesson
                {
                    Id = 14,
                    Title = "14. Şekiller 🔺",
                    Content = "Dünyamız şekillerden oluşur! Daire, kare, üçgen... Geometrik şekillerin Almanca isimlerini öğrenelim.",
                    KeyPhrases = new List<string> { "der Kreis (daire)", "das Quadrat (kare)", "das Dreieck (üçgen)", "das Rechteck (dikdörtgen)", "der Stern (yıldız)" },
                    FunFact = "Almancada 'Daire' (Kreis) kelimesi aynı zamanda idari bölge (ilçe) anlamına da gelir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Daire' (yuvarlak) Almanca nedir?", Options = new List<string> { "das Viereck", "der Kreis", "die Linie" }, Answer = "der Kreis" },
                        new QuizQuestion { Id = 2, Question = "Dört kenarı eşit olan şekil (Kare)?", Options = new List<string> { "das Quadrat", "das Dreieck", "der Punkt" }, Answer = "das Quadrat" },
                        new QuizQuestion { Id = 3, Question = "'Üçgen' ne anlama gelir?", Options = new List<string> { "das Dreieck", "der Stern", "das Oval" }, Answer = "das Dreieck" },
                        new QuizQuestion { Id = 4, Question = "Dikdörtgen hangisidir?", Options = new List<string> { "das Rechteck", "der Kreis", "die Form" }, Answer = "das Rechteck" },
                        new QuizQuestion { Id = 5, Question = "Gökyüzündeki 'Yıldız'?", Options = new List<string> { "der Stern", "der Mond", "die Sonne" }, Answer = "der Stern" },
                        new QuizQuestion { Id = 6, Question = "'Oval' Almanca nasıl yazılır?", Options = new List<string> { "das Oval", "der Oval", "die Oval" }, Answer = "das Oval" },
                        new QuizQuestion { Id = 7, Question = "'Kalp' (Herz) şekli?", Options = new List<string> { "das Herz", "der Kopf", "die Hand" }, Answer = "das Herz" },
                        new QuizQuestion { Id = 8, Question = "'Çizgi' (Linie) ne demektir?", Options = new List<string> { "die Linie", "der Punkt", "der Strich" }, Answer = "die Linie" },
                        new QuizQuestion { Id = 9, Question = "'Nokta' (Punkt) ne demektir?", Options = new List<string> { "der Punkt", "der Platz", "der Park" }, Answer = "der Punkt" },
                        new QuizQuestion { Id = 10, Question = "'Haç/Çarpı' (Kreuz) ne demektir?", Options = new List<string> { "das Kreuz", "der Kreis", "die Krone" }, Answer = "das Kreuz" },
                        new QuizQuestion { Id = 11, Question = "'Ok' (Pfeil) işareti?", Options = new List<string> { "der Pfeil", "der Bogen", "der Stift" }, Answer = "der Pfeil" },
                        new QuizQuestion { Id = 12, Question = "'Küp' (Würfel) ne demektir?", Options = new List<string> { "der Würfel", "der Wurf", "die Wurst" }, Answer = "der Würfel" },
                        new QuizQuestion { Id = 13, Question = "'Küre/Top' (Kugel) ne demektir?", Options = new List<string> { "die Kugel", "der Ball", "der Kreis" }, Answer = "die Kugel" },
                        new QuizQuestion { Id = 14, Question = "'Piramit' (Pyramide) Almanca?", Options = new List<string> { "die Pyramide", "das Prisma", "der Turm" }, Answer = "die Pyramide" },
                        new QuizQuestion { Id = 15, Question = "'Eşkenar Dörtgen/Elmas' (Raute)?", Options = new List<string> { "die Raute", "der Ring", "die Rose" }, Answer = "die Raute" },
                        new QuizQuestion { Id = 16, Question = "'Köşe' (Ecke) ne demektir?", Options = new List<string> { "die Ecke", "die Kante", "die Seite" }, Answer = "die Ecke" },
                        new QuizQuestion { Id = 17, Question = "'Kenar' (Seite) ne demektir?", Options = new List<string> { "die Seite", "die Mitte", "oben" }, Answer = "die Seite" },
                        new QuizQuestion { Id = 18, Question = "'Orta/Merkez' (Mitte) ne demektir?", Options = new List<string> { "die Mitte", "das Ende", "der Anfang" }, Answer = "die Mitte" },
                        new QuizQuestion { Id = 19, Question = "'Büyük' (Groß) ne demektir?", Options = new List<string> { "Groß", "Klein", "Lang" }, Answer = "Groß" },
                        new QuizQuestion { Id = 20, Question = "'Küçük' (Klein) ne demektir?", Options = new List<string> { "Klein", "Groß", "Kurz" }, Answer = "Klein" }
                    }
                },
                 new Lesson
                {
                    Id = 15,
                    Title = "15. Tatlılar 🍫",
                    Content = "Hayatın tatlı tarafı! Alman pastalarından çikolatalarına, tatlı krizine gireceğimiz kelimeler. Kara Orman pastasını denemelisiniz!",
                    KeyPhrases = new List<string> { "die Schokolade (çikolata)", "der Kuchen (kek/pasta)", "das Eis (dondurma)", "der Keks (kurabiye)", "der Zucker (şeker)" },
                    FunFact = "Almanya dünyanın en çok çikolata tüketen ülkelerinden biridir. Kişi başı yıllık ortalama 9 kg çikolata yenir!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Çikolata' Almanca nasıl yazılır?", Options = new List<string> { "der Schokolade", "die Schokolade", "das Schokolade" }, Answer = "die Schokolade" },
                        new QuizQuestion { Id = 2, Question = "Doğum günlerinde ne yeriz (Pasta)?", Options = new List<string> { "das Brot", "der Kuchen", "die Suppe" }, Answer = "der Kuchen" },
                        new QuizQuestion { Id = 3, Question = "'Dondurma' (Ice Cream) nedir?", Options = new List<string> { "das Eis", "der Schnee", "das Wasser" }, Answer = "das Eis" },
                        new QuizQuestion { Id = 4, Question = "Çayın yanında yenen 'Kurabiye'?", Options = new List<string> { "der Keks", "das Bonbon", "die Torte" }, Answer = "der Keks" },
                        new QuizQuestion { Id = 5, Question = "'Şeker' (Sugar) kelimesinin karşılığı?", Options = new List<string> { "das Salz", "der Pfeffer", "der Zucker" }, Answer = "der Zucker" },
                        new QuizQuestion { Id = 6, Question = "'Şekerleme' (Bonbon) ne demektir?", Options = new List<string> { "das Bonbon", "der Ballon", "das Brot" }, Answer = "das Bonbon" },
                        new QuizQuestion { Id = 7, Question = "'Sakız' (Kaugummi) Almanca?", Options = new List<string> { "der Kaugummi", "der Gummi", "das Kau" }, Answer = "der Kaugummi" },
                        new QuizQuestion { Id = 8, Question = "'Bal' (Honig) ne demektir?", Options = new List<string> { "der Honig", "der Zucker", "das Salz" }, Answer = "der Honig" },
                        new QuizQuestion { Id = 9, Question = "'Reçel' (Marmelade) Almanca?", Options = new List<string> { "die Marmelade", "die Butter", "das Brot" }, Answer = "die Marmelade" },
                        new QuizQuestion { Id = 10, Question = "'Puding' ne demektir?", Options = new List<string> { "der Pudding", "der Kuchen", "das Eis" }, Answer = "der Pudding" },
                        new QuizQuestion { Id = 11, Question = "'Waffle/Gofret' (Waffel) Almanca?", Options = new List<string> { "die Waffel", "die Waffe", "das Wasser" }, Answer = "die Waffel" },
                        new QuizQuestion { Id = 12, Question = "'Krema' (Sahne) ne demektir?", Options = new List<string> { "die Sahne", "die Milch", "die Butter" }, Answer = "die Sahne" },
                        new QuizQuestion { Id = 13, Question = "'Tatlı' (Süß) sıfatı?", Options = new List<string> { "Süß", "Sauer", "Salzig" }, Answer = "Süß" },
                        new QuizQuestion { Id = 14, Question = "'Ekşi' (Sauer) sıfatı?", Options = new List<string> { "Sauer", "Süß", "Scharf" }, Answer = "Sauer" },
                        new QuizQuestion { Id = 15, Question = "'Acı' (Bitter) sıfatı?", Options = new List<string> { "Bitter", "Besser", "Butter" }, Answer = "Bitter" },
                        new QuizQuestion { Id = 16, Question = "'Lezzetli' (Lecker) ne demektir?", Options = new List<string> { "Lecker", "Locker", "Lustig" }, Answer = "Lecker" },
                        new QuizQuestion { Id = 17, Question = "'Donut' (Krapfen) Almanca?", Options = new List<string> { "der Krapfen", "der Kuchen", "der Keks" }, Answer = "der Krapfen" },
                        new QuizQuestion { Id = 18, Question = "'Muffin' Almanca?", Options = new List<string> { "der Muffin", "die Maus", "der Mond" }, Answer = "der Muffin" },
                        new QuizQuestion { Id = 19, Question = "'Turta/Yaş Pasta' (Torte)?", Options = new List<string> { "die Torte", "der Teller", "der Tisch" }, Answer = "die Torte" },
                        new QuizQuestion { Id = 20, Question = "'Tatlı/Dessert' (Nachtisch)?", Options = new List<string> { "der Nachtisch", "die Nacht", "der Tisch" }, Answer = "der Nachtisch" }
                    }
                },
                 new Lesson
                {
                    Id = 16,
                    Title = "16. Objeler 🎒",
                    Content = "Çevremizdeki nesneleri isimlendirelim. Masadan sandalyeye, kitaplıktan çantaya... Günlük hayatta sıkça kullandığımız kelimeler.",
                    KeyPhrases = new List<string> { "der Tisch (masa)", "der Stuhl (sandalye)", "die Tasche (çanta)", "das Buch (kitap)", "der Stift (kalem)" },
                    FunFact = "Almancada 'nesne' (Gegenstand) kelimesi aynı zamanda 'konu' veya 'mesele' anlamına da gelebilir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Masa' kelimesinin Almancası nedir?", Options = new List<string> { "der Tisch", "der Fisch", "das Tisch" }, Answer = "der Tisch" },
                        new QuizQuestion { Id = 2, Question = "Üzerine oturduğumuz eşya (Sandalye)?", Options = new List<string> { "der Sessel", "der Stuhl", "die Bank" }, Answer = "der Stuhl" },
                        new QuizQuestion { Id = 3, Question = "'Çanta' (Bag) ne anlama gelir?", Options = new List<string> { "der Beutel", "die Tasche", "der Koffer" }, Answer = "die Tasche" },
                        new QuizQuestion { Id = 4, Question = "Yazı yazmak için ne kullanırız (Kalem)?", Options = new List<string> { "der Stift", "das Papier", "die Farbe" }, Answer = "der Stift" },
                        new QuizQuestion { Id = 5, Question = "'Kitap' Almanca nasıl söylenir?", Options = new List<string> { "das Heft", "das Buch", "die Zeitung" }, Answer = "das Buch" },
                        new QuizQuestion { Id = 6, Question = "'Pencere' (Window) Almanca?", Options = new List<string> { "das Fenster", "die Wand", "die Tür" }, Answer = "das Fenster" },
                        new QuizQuestion { Id = 7, Question = "'Kapı' (Door) ne demektir?", Options = new List<string> { "die Tür", "das Tor", "der Tisch" }, Answer = "die Tür" },
                        new QuizQuestion { Id = 8, Question = "'Lamba' (Lamp) ne demektir?", Options = new List<string> { "die Lampe", "das Licht", "die Luft" }, Answer = "die Lampe" },
                        new QuizQuestion { Id = 9, Question = "'Yatak' (Bed) Almanca?", Options = new List<string> { "das Bett", "das Bad", "der Boden" }, Answer = "das Bett" },
                        new QuizQuestion { Id = 10, Question = "'Dolap' (Cupboard) ne demektir?", Options = new List<string> { "der Schrank", "der Schublade", "der Stuhl" }, Answer = "der Schrank" },
                        new QuizQuestion { Id = 11, Question = "'Anahtar' (Key) Almanca?", Options = new List<string> { "der Schlüssel", "der Schloss", "die Schüssel" }, Answer = "der Schlüssel" },
                        new QuizQuestion { Id = 12, Question = "'Bilgisayar' kelimesi?", Options = new List<string> { "der Computer", "der Rechner", "das Handy" }, Answer = "der Computer" },
                        new QuizQuestion { Id = 13, Question = "'Telefon' ne anlama gelir?", Options = new List<string> { "das Telefon", "das Tor", "der Teller" }, Answer = "das Telefon" },
                        new QuizQuestion { Id = 14, Question = "'Bardak' (Glass) Almanca?", Options = new List<string> { "das Glas", "die Tasse", "die Flasche" }, Answer = "das Glas" },
                        new QuizQuestion { Id = 15, Question = "'Fincan' (Cup) ne demektir?", Options = new List<string> { "die Tasse", "der Teller", "der Topf" }, Answer = "die Tasse" },
                        new QuizQuestion { Id = 16, Question = "'Tabak' (Plate) ne demektir?", Options = new List<string> { "der Teller", "die Tasse", "der Tisch" }, Answer = "der Teller" },
                        new QuizQuestion { Id = 17, Question = "'Bıçak' (Knife) ne demektir?", Options = new List<string> { "das Messer", "die Gabel", "der Löffel" }, Answer = "das Messer" },
                        new QuizQuestion { Id = 18, Question = "'Çatal' (Fork) Almanca?", Options = new List<string> { "die Gabel", "das Glas", "das Geld" }, Answer = "die Gabel" },
                        new QuizQuestion { Id = 19, Question = "'Kaşık' (Spoon) ne demektir?", Options = new List<string> { "der Löffel", "die Lampe", "die Luft" }, Answer = "der Löffel" },
                        new QuizQuestion { Id = 20, Question = "'Resim/Tablo' (Picture)?", Options = new List<string> { "das Bild", "das Buch", "das Blatt" }, Answer = "das Bild" }
                    }
                },
                 new Lesson
                {
                    Id = 17,
                    Title = "17. Aile 👨‍👩‍👧‍👦",
                    Content = "Ailenin temelleri. Anne, baba, kardeşler... Aile üyelerini Almanca tanıtmayı öğreniyoruz.",
                    KeyPhrases = new List<string> { "die Familie (aile)", "der Vater (baba)", "die Mutter (anne)", "der Bruder (erkek kardeş)", "die Schwester (kız kardeş)" },
                    FunFact = "Almancada 'Oma' (Büyükanne) ve 'Opa' (Büyükbaba) kelimeleri çok yaygın kullanılır.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Anne' kelimesinin Almancası nedir?", Options = new List<string> { "die Mutter", "die Tante", "die Oma" }, Answer = "die Mutter" },
                        new QuizQuestion { Id = 2, Question = "Evin reisi (Baba)?", Options = new List<string> { "der Onkel", "der Vater", "der Bruder" }, Answer = "der Vater" },
                        new QuizQuestion { Id = 3, Question = "'Erkek Kardeş' (Brother) ne anlama gelir?", Options = new List<string> { "der Bruder", "der Sohn", "der Cousin" }, Answer = "der Bruder" },
                        new QuizQuestion { Id = 4, Question = "Kız Kardeş hangisidir?", Options = new List<string> { "die Schwester", "die Tochter", "die Nichte" }, Answer = "die Schwester" },
                        new QuizQuestion { Id = 5, Question = "'Aile' (Family) Almanca nasıl söylenir?", Options = new List<string> { "die Familie", "die Leute", "das Haus" }, Answer = "die Familie" },
                        new QuizQuestion { Id = 6, Question = "'Büyükanne' (Grandmother) Almanca?", Options = new List<string> { "die Oma", "die Opa", "die Mama" }, Answer = "die Oma" },
                        new QuizQuestion { Id = 7, Question = "'Büyükbaba' (Grandfather) Almanca?", Options = new List<string> { "der Opa", "der Onkel", "der Papa" }, Answer = "der Opa" },
                        new QuizQuestion { Id = 8, Question = "'Amca/Dayı' (Uncle) ne demektir?", Options = new List<string> { "der Onkel", "der Neffe", "der Cousin" }, Answer = "der Onkel" },
                        new QuizQuestion { Id = 9, Question = "'Teyze/Hala' (Aunt) ne demektir?", Options = new List<string> { "die Tante", "die Nichte", "die Cousine" }, Answer = "die Tante" },
                        new QuizQuestion { Id = 10, Question = "'Kuzen' (Cousin) Almanca nasıl?", Options = new List<string> { "der Cousin", "der Bruder", "der Freund" }, Answer = "der Cousin" },
                        new QuizQuestion { Id = 11, Question = "'Oğul' (Son) ne demektir?", Options = new List<string> { "der Sohn", "die Sonne", "der Onkel" }, Answer = "der Sohn" },
                        new QuizQuestion { Id = 12, Question = "'Kız Evlat' (Daughter) ne demektir?", Options = new List<string> { "die Tochter", "die Tante", "die Mutter" }, Answer = "die Tochter" },
                        new QuizQuestion { Id = 13, Question = "'Bebek' (Baby) Almanca?", Options = new List<string> { "das Baby", "das Kind", "der Junge" }, Answer = "das Baby" },
                        new QuizQuestion { Id = 14, Question = "'Çocuk' (Child) ne demektir?", Options = new List<string> { "das Kind", "der Mann", "die Frau" }, Answer = "das Kind" },
                        new QuizQuestion { Id = 15, Question = "'Ebeveyn' (Parents) ne demektir?", Options = new List<string> { "die Eltern", "die Großeltern", "die Verwandten" }, Answer = "die Eltern" },
                        new QuizQuestion { Id = 16, Question = "'Kardeşler' (Siblings) ne demektir?", Options = new List<string> { "die Geschwister", "die Brüder", "die Schwestern" }, Answer = "die Geschwister" },
                        new QuizQuestion { Id = 17, Question = "'Yeğen (Kız)' (Niece) nedir?", Options = new List<string> { "die Nichte", "die Neffe", "die Tante" }, Answer = "die Nichte" },
                        new QuizQuestion { Id = 18, Question = "'Yeğen (Erkek)' (Nephew) nedir?", Options = new List<string> { "der Neffe", "der Nichte", "der Onkel" }, Answer = "der Neffe" },
                        new QuizQuestion { Id = 19, Question = "'Torun' (Grandchild) ne demektir?", Options = new List<string> { "das Enkelkind", "das kind", "der Sohn" }, Answer = "das Enkelkind" },
                        new QuizQuestion { Id = 20, Question = "'Koca' (Husband) kelimesi?", Options = new List<string> { "der Mann", "der Herr", "der Vater" }, Answer = "der Mann" }
                    }
                },
                 new Lesson
                {
                    Id = 18,
                    Title = "18. Meslekler 👷‍♀️",
                    Content = "Büyüyünce ne olmak istersin? Doktor, mühendis veya öğretmen... Meslekleri ve iş hayatını Almanca konuşalım.",
                    KeyPhrases = new List<string> { "der Lehrer (öğretmen)", "der Arzt (doktor)", "der Ingenieur (mühendis)", "der Koch (aşçı)", "der Polizist (polis)" },
                    FunFact = "Kadın meslek isimleri genellikle 'in' takısı alır. Örneğin: Lehrer (erkek öğretmen) -> Lehrerin (kadın öğretmen).",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Öğretmen' Almanca nasıl söylenir?", Options = new List<string> { "der Lehrer", "der Schüler", "der Meister" }, Answer = "der Lehrer" },
                        new QuizQuestion { Id = 2, Question = "Hastaları iyileştiren kişi (Doktor)?", Options = new List<string> { "der Arzt", "der Krankenpfleger", "der Apotheker" }, Answer = "der Arzt" },
                        new QuizQuestion { Id = 3, Question = "'Mühendis' (Engineer) ne anlama gelir?", Options = new List<string> { "der Ingenieur", "der Mechaniker", "der Bauarbeiter" }, Answer = "der Ingenieur" },
                        new QuizQuestion { Id = 4, Question = "Yemek pişiren kişi (Aşçı)?", Options = new List<string> { "der Koch", "der Kellner", "der Bäcker" }, Answer = "der Koch" },
                        new QuizQuestion { Id = 5, Question = "'Polis' Almanca nedir?", Options = new List<string> { "der Polizist", "der Soldat", "der Wächter" }, Answer = "der Polizist" },
                        new QuizQuestion { Id = 6, Question = "'Hemşire' (Nurse) Almanca?", Options = new List<string> { "die Krankenschwester", "die Ärztin", "die Lehrerin" }, Answer = "die Krankenschwester" },
                        new QuizQuestion { Id = 7, Question = "'Öğrenci' (Student) ne demektir?", Options = new List<string> { "der Schüler", "der Lehrer", "der Direktor" }, Answer = "der Schüler" },
                        new QuizQuestion { Id = 8, Question = "'Şoför' (Driver) ne demektir?", Options = new List<string> { "der Fahrer", "der Flieger", "der Führer" }, Answer = "der Fahrer" },
                        new QuizQuestion { Id = 9, Question = "'Fırıncı' (Baker) Almanca?", Options = new List<string> { "der Bäcker", "der Koch", "der Metzger" }, Answer = "der Bäcker" },
                        new QuizQuestion { Id = 10, Question = "'Çiftçi' (Farmer) ne demektir?", Options = new List<string> { "der Bauer", "der Gärtner", "der Jäger" }, Answer = "der Bauer" },
                        new QuizQuestion { Id = 11, Question = "'Sanatçı' (Artist) kelimesi?", Options = new List<string> { "der Künstler", "der Maler", "der Musiker" }, Answer = "der Künstler" },
                        new QuizQuestion { Id = 12, Question = "'Avukat' (Lawyer) ne demektir?", Options = new List<string> { "der Anwalt", "der Richter", "der Polizist" }, Answer = "der Anwalt" },
                        new QuizQuestion { Id = 13, Question = "'Pilot' Almanca nasıl yazılır?", Options = new List<string> { "der Pilot", "der Kapitän", "der Fahrer" }, Answer = "der Pilot" },
                        new QuizQuestion { Id = 14, Question = "'Diş Hekimi' (Dentist)?", Options = new List<string> { "der Zahnarzt", "der Arzt", "der Tierarzt" }, Answer = "der Zahnarzt" },
                        new QuizQuestion { Id = 15, Question = "'Garson' (Waiter) ne demektir?", Options = new List<string> { "der Kellner", "der Koch", "der Gast" }, Answer = "der Kellner" },
                        new QuizQuestion { Id = 16, Question = "'Kuaför' (Hairdresser) Almanca?", Options = new List<string> { "der Friseur", "der Barbier", "der Schneider" }, Answer = "der Friseur" },
                        new QuizQuestion { Id = 17, Question = "'Şarkıcı' (Singer) ne demektir?", Options = new List<string> { "der Sänger", "der Tänzer", "der Schauspieler" }, Answer = "der Sänger" },
                        new QuizQuestion { Id = 18, Question = "'Oyuncu' (Actor) ne demektir?", Options = new List<string> { "der Schauspieler", "der Autor", "der Regisseur" }, Answer = "der Schauspieler" },
                        new QuizQuestion { Id = 19, Question = "'İtfaiyeci' (Firefighter)?", Options = new List<string> { "der Feuerwehrmann", "der Polizist", "der Arzt" }, Answer = "der Feuerwehrmann" },
                        new QuizQuestion { Id = 20, Question = "'Sekreter' kelimesi?", Options = new List<string> { "der Sekretär", "der Assistent", "der Chef" }, Answer = "der Sekretär" }
                    }
                },
                 new Lesson
                {
                    Id = 19,
                    Title = "19. Hava Durumu ☀️",
                    Content = "Bugün hava nasıl? Güneşli, yağmurlu veya karlı... Hava durumunu sormayı ve anlatmayı öğrenelim.",
                    KeyPhrases = new List<string> { "die Sonne (güneş)", "der Regen (yağmur)", "der Schnee (kar)", "der Wind (rüzgar)", "die Wolke (bulut)" },
                    FunFact = "Almanya oldukça bulutlu bir ülkedir, özellikle sonbaharda! 'Es regnet' (Yağmur yağıyor) sık kullanılan bir cümledir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Güneş' Almanca nedir?", Options = new List<string> { "die Sonne", "der Mond", "der Stern" }, Answer = "die Sonne" },
                        new QuizQuestion { Id = 2, Question = "Yağmur yağıyor (der Regen)?", Options = new List<string> { "der Wind", "der Regen", "der Schnee" }, Answer = "der Regen" },
                        new QuizQuestion { Id = 3, Question = "'Kar' (Snow) ne anlama gelir?", Options = new List<string> { "das Eis", "der Schnee", "der Hagel" }, Answer = "der Schnee" },
                        new QuizQuestion { Id = 4, Question = "Gökyüzündeki 'Bulut'?", Options = new List<string> { "die Wolke", "der Nebel", "der Sturm" }, Answer = "die Wolke" },
                        new QuizQuestion { Id = 5, Question = "'Rüzgar' (Wind) Almanca nasıl söylenir?", Options = new List<string> { "der Wind", "die Luft", "das Wetter" }, Answer = "der Wind" },
                        new QuizQuestion { Id = 6, Question = "'Sıcak' (Hot) ne demektir?", Options = new List<string> { "Heiß", "Kalt", "Warm" }, Answer = "Heiß" },
                        new QuizQuestion { Id = 7, Question = "'Soğuk' (Cold) ne demektir?", Options = new List<string> { "Kalt", "Heiß", "Kühl" }, Answer = "Kalt" },
                        new QuizQuestion { Id = 8, Question = "'Ilık/Sıcak' (Warm) ne demektir?", Options = new List<string> { "Warm", "Kalt", "Trocken" }, Answer = "Warm" },
                        new QuizQuestion { Id = 9, Question = "'Fırtına' (Storm) Almanca?", Options = new List<string> { "der Sturm", "der Stern", "der Strom" }, Answer = "der Sturm" },
                        new QuizQuestion { Id = 10, Question = "'Sis' (Fog) ne demektir?", Options = new List<string> { "der Nebel", "der Nabel", "die Nacht" }, Answer = "der Nebel" },
                        new QuizQuestion { Id = 11, Question = "'Şimşek' (Lightning) ne demektir?", Options = new List<string> { "der Blitz", "der Blick", "das Blatt" }, Answer = "der Blitz" },
                        new QuizQuestion { Id = 12, Question = "'Gök gürültüsü' (Thunder)?", Options = new List<string> { "der Donner", "der Donnerstag", "das Dunkel" }, Answer = "der Donner" },
                        new QuizQuestion { Id = 13, Question = "'Gökyüzü' (Sky) ne demektir?", Options = new List<string> { "der Himmel", "die Hölle", "das Haus" }, Answer = "der Himmel" },
                        new QuizQuestion { Id = 14, Question = "'Hava Durumu Raporu'?", Options = new List<string> { "der Wetterbericht", "die Nachricht", "die Zeitung" }, Answer = "der Wetterbericht" },
                        new QuizQuestion { Id = 15, Question = "'Derece' (Degree) ne demektir?", Options = new List<string> { "der Grad", "das Gras", "das Grab" }, Answer = "der Grad" },
                        new QuizQuestion { Id = 16, Question = "'Buz' (Ice) Almanca?", Options = new List<string> { "das Eis", "das heiß", "der Preis" }, Answer = "das Eis" },
                        new QuizQuestion { Id = 17, Question = "'Islak' (Wet) ne demektir?", Options = new List<string> { "Nass", "Trocken", "Warm" }, Answer = "Nass" },
                        new QuizQuestion { Id = 18, Question = "'Kuru' (Dry) ne demektir?", Options = new List<string> { "Trocken", "Nass", "Kalt" }, Answer = "Trocken" },
                        new QuizQuestion { Id = 19, Question = "'Gökkuşağı' (Rainbow) ne demektir?", Options = new List<string> { "der Regenbogen", "der Regen", "der Bogen" }, Answer = "der Regenbogen" },
                        new QuizQuestion { Id = 20, Question = "'Güneş Işığı' (Sunshine)?", Options = new List<string> { "der Sonnenschein", "der Sonnenuntergang", "die Sonnenblume" }, Answer = "der Sonnenschein" }
                    }
                },
                 new Lesson
                {
                    Id = 20,
                    Title = "20. Mevsimler 🍂",
                    Content = "Bir yılda dört mevsim vardır. İlkbahar, yaz, sonbahar ve kış... Her mevsimin güzelliğini Almanca ifade edelim.",
                    KeyPhrases = new List<string> { "der Frühling (ilkbahar)", "der Sommer (yaz)", "der Herbst (sonbahar)", "der Winter (kış)", "die Jahreszeit (mevsim)" },
                    FunFact = "Almanya'da Noel pazarları (Weihnachtsmärkte) kışın en sevilen geleneğidir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Çiçeklerin açtığı mevsim (İlkbahar)?", Options = new List<string> { "der Frühling", "der Winter", "der Herbst" }, Answer = "der Frühling" },
                        new QuizQuestion { Id = 2, Question = "Güneşli ve sıcak mevsim (Yaz)?", Options = new List<string> { "der Sommer", "der Regen", "der Abend" }, Answer = "der Sommer" },
                        new QuizQuestion { Id = 3, Question = "Yaprakların döküldüğü mevsim (Sonbahar)?", Options = new List<string> { "der Herbst", "der Tag", "der Morgen" }, Answer = "der Herbst" },
                        new QuizQuestion { Id = 4, Question = "'Kış' (Winter) ne anlama gelir?", Options = new List<string> { "Soğuk", "Kış", "Kar" }, Answer = "Kış" },
                        new QuizQuestion { Id = 5, Question = "'Mevsim' kelimesinin Almancası?", Options = new List<string> { "die Jahreszeit", "der Monat", "die Woche" }, Answer = "die Jahreszeit" },
                        new QuizQuestion { Id = 6, Question = "İlkbaharda açan 'Çiçekler'?", Options = new List<string> { "die Blumen", "die Baume", "die Blätter" }, Answer = "die Blumen" },
                        new QuizQuestion { Id = 7, Question = "Doğanın rengi (Yeşil)?", Options = new List<string> { "Grün", "Rot", "Blau" }, Answer = "Grün" },
                        new QuizQuestion { Id = 8, Question = "Yazın yapılan 'Tatil'?", Options = new List<string> { "der Urlaub", "die Arbeit", "die Schule" }, Answer = "der Urlaub" },
                        new QuizQuestion { Id = 9, Question = "'Yüzmek' (Swimming) Almanca?", Options = new List<string> { "Schwimmen", "Laufen", "Spielen" }, Answer = "Schwimmen" },
                        new QuizQuestion { Id = 10, Question = "Yazın hava nasıldır (Sıcak)?", Options = new List<string> { "Heiß", "Kalt", "Nass" }, Answer = "Heiß" },
                        new QuizQuestion { Id = 11, Question = "Sonbaharda dökülen 'Yapraklar'?", Options = new List<string> { "die Blätter", "die Blumen", "die Steine" }, Answer = "die Blätter" },
                        new QuizQuestion { Id = 12, Question = "Sonbaharda hava nasıldır (Rüzgarlı)?", Options = new List<string> { "Windig", "Sonnig", "Still" }, Answer = "Windig" },
                        new QuizQuestion { Id = 13, Question = "Kışın hava nasıldır (Soğuk)?", Options = new List<string> { "Kalt", "Warm", "Heiß" }, Answer = "Kalt" },
                        new QuizQuestion { Id = 14, Question = "Kardan yapılan adam (Kardan Adam)?", Options = new List<string> { "der Schneemann", "der Weihnachtsmann", "der Mann" }, Answer = "der Schneemann" },
                        new QuizQuestion { Id = 15, Question = "'Kayak Yapmak' (Skiing)?", Options = new List<string> { "Skifahren", "Laufen", "Schwimmen" }, Answer = "Skifahren" },
                        new QuizQuestion { Id = 16, Question = "'Noel' (Christmas) Almanca?", Options = new List<string> { "Weihnachten", "Ostern", "Silvester" }, Answer = "Weihnachten" },
                        new QuizQuestion { Id = 17, Question = "Yılın ilk ayı (Ocak)?", Options = new List<string> { "Januar", "Februar", "März" }, Answer = "Januar" },
                        new QuizQuestion { Id = 18, Question = "Dördüncü ay (Nisan)?", Options = new List<string> { "April", "Mai", "Juni" }, Answer = "April" },
                        new QuizQuestion { Id = 19, Question = "Yedinci ay (Temmuz)?", Options = new List<string> { "Juli", "August", "September" }, Answer = "Juli" },
                        new QuizQuestion { Id = 20, Question = "Onuncu ay (Ekim)?", Options = new List<string> { "Oktober", "November", "Dezember" }, Answer = "Oktober" }
                    }
                },
                 new Lesson
                {
                    Id = 21,
                    Title = "21. Giysiler 👕",
                    Content = "Moda ve giyim. Pantolondan gömleğe, ayakkabıdan şapkaya ne giydiğimizi anlatalım.",
                    KeyPhrases = new List<string> { "die Hose (pantolon)", "das Hemd (gömlek)", "der Schuh (ayakkabı)", "das Kleid (elbise)", "die Jacke (ceket)" },
                    FunFact = "Almanya'da geleneksel kıyafetler (Tracht), özellikle Bavyera'da festivallerde hala giyilir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Pantolon' Almanca nedir?", Options = new List<string> { "die Hose", "der Hut", "der Mantel" }, Answer = "die Hose" },
                        new QuizQuestion { Id = 2, Question = "Erkeklerin giydiği 'Gömlek'?", Options = new List<string> { "das Hemd", "die Bluse", "der Rock" }, Answer = "das Hemd" },
                        new QuizQuestion { Id = 3, Question = "'Ayakkabı' ne anlama gelir?", Options = new List<string> { "der Schuh", "die Socke", "der Stiefel" }, Answer = "der Schuh" },
                        new QuizQuestion { Id = 4, Question = "Kadınların giydiği 'Elbise'?", Options = new List<string> { "das Kleid", "der Anzug", "die Jacke" }, Answer = "das Kleid" },
                        new QuizQuestion { Id = 5, Question = "'Ceket' kelimesinin Almancası?", Options = new List<string> { "die Jacke", "der Pullover", "das T-Shirt" }, Answer = "die Jacke" },
                        new QuizQuestion { Id = 6, Question = "'Tişört' (T-Shirt) Almanca?", Options = new List<string> { "das T-Shirt", "das Hemd", "die Hose" }, Answer = "das T-Shirt" },
                        new QuizQuestion { Id = 7, Question = "'Kazak' (Pullover) ne demektir?", Options = new List<string> { "der Pullover", "der Mantel", "der Hut" }, Answer = "der Pullover" },
                        new QuizQuestion { Id = 8, Question = "'Etek' (Skirt) ne demektir?", Options = new List<string> { "der Rock", "das Kleid", "die Hose" }, Answer = "der Rock" },
                        new QuizQuestion { Id = 9, Question = "'Şapka' (Hat) Almanca?", Options = new List<string> { "der Hut", "die Mütze", "der Schal" }, Answer = "der Hut" },
                        new QuizQuestion { Id = 10, Question = "'Atkı' (Scarf) ne demektir?", Options = new List<string> { "der Schal", "der Schuh", "die Socke" }, Answer = "der Schal" },
                        new QuizQuestion { Id = 11, Question = "'Eldiven' (Gloves) ne demektir?", Options = new List<string> { "die Handschuhe", "die Schuhe", "die Hand" }, Answer = "die Handschuhe" },
                        new QuizQuestion { Id = 12, Question = "'Çorap' (Socks) Almanca?", Options = new List<string> { "die Socke", "der Schuh", "die Hose" }, Answer = "die Socke" },
                        new QuizQuestion { Id = 13, Question = "'Kemer' (Belt) ne demektir?", Options = new List<string> { "der Gürtel", "der Hut", "die Tasche" }, Answer = "der Gürtel" },
                        new QuizQuestion { Id = 14, Question = "'Gözlük' (Glasses) ne demektir?", Options = new List<string> { "die Brille", "das Auge", "das Glas" }, Answer = "die Brille" },
                        new QuizQuestion { Id = 15, Question = "'Palto/Mantı' (Coat)?", Options = new List<string> { "der Mantel", "die Jacke", "der Hut" }, Answer = "der Mantel" },
                        new QuizQuestion { Id = 16, Question = "'Kot Pantolon' (Jeans)?", Options = new List<string> { "die Jeans", "die Hose", "der Rock" }, Answer = "die Jeans" },
                        new QuizQuestion { Id = 17, Question = "'Kravat' (Tie) Almanca?", Options = new List<string> { "die Krawatte", "der Kragen", "das Kleid" }, Answer = "die Krawatte" },
                        new QuizQuestion { Id = 18, Question = "'Bluz' (Blouse) ne demektir?", Options = new List<string> { "die Bluse", "das Hemd", "der Rock" }, Answer = "die Bluse" },
                        new QuizQuestion { Id = 19, Question = "'Yüzük' (Ring) ne demektir?", Options = new List<string> { "der Ring", "die Uhr", "die Kette" }, Answer = "der Ring" },
                        new QuizQuestion { Id = 20, Question = "'Çizme' (Boots) ne demektir?", Options = new List<string> { "der Stiefel", "der Schuh", "die Socke" }, Answer = "der Stiefel" }
                    }
                },
                 new Lesson
                {
                    Id = 22,
                    Title = "22. Seyahat ve Gezi ✈️",
                    Content = "Yeni yerler keşfetme zamanı! Seyahat planı yaparken, bilet alırken veya yolculuk esnasında ihtiyacımız olan kelimeler.",
                    KeyPhrases = new List<string> { "der Koffer (bavul)", "das Flugzeug (uçak)", "das Ticket (bilet)", "der Zug (tren)", "reisen (seyahat etmek)" },
                    FunFact = "Almanya otoyollarında (Autobahn) bazı bölümlerde hız sınırı yoktur, ancak önerilen hız 130 km/s'dir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Bavul' Almanca nedir?", Options = new List<string> { "der Koffer", "die Tasche", "der Rucksack" }, Answer = "der Koffer" },
                        new QuizQuestion { Id = 2, Question = "Havada giden ulaşım aracı (Uçak)?", Options = new List<string> { "das Auto", "das Flugzeug", "das Schiff" }, Answer = "das Flugzeug" },
                        new QuizQuestion { Id = 3, Question = "'Bilet' (Ticket) ne anlama gelir?", Options = new List<string> { "das Ticket", "der Pass", "das Visum" }, Answer = "das Ticket" },
                        new QuizQuestion { Id = 4, Question = "Raylar üzerinde giden araç (Tren)?", Options = new List<string> { "der Bus", "der Zug", "die Bahn" }, Answer = "der Zug" },
                        new QuizQuestion { Id = 5, Question = "'Seyahat etmek' fiilinin Almancası?", Options = new List<string> { "reisen", "gehen", "kommen" }, Answer = "reisen" },
                        new QuizQuestion { Id = 6, Question = "'Otobüs' (Bus) Almanca?", Options = new List<string> { "der Bus", "das Auto", "der Zug" }, Answer = "der Bus" },
                        new QuizQuestion { Id = 7, Question = "'Araba' (Car) ne demektir?", Options = new List<string> { "das Auto", "der Bus", "das Rad" }, Answer = "das Auto" },
                        new QuizQuestion { Id = 8, Question = "'Gemi' (Ship) ne demektir?", Options = new List<string> { "das Schiff", "das Boot", "der See" }, Answer = "das Schiff" },
                        new QuizQuestion { Id = 9, Question = "'Bisiklet' (Bicycle) Almanca?", Options = new List<string> { "das Fahrrad", "das Motorrad", "der Bus" }, Answer = "das Fahrrad" },
                        new QuizQuestion { Id = 10, Question = "'Taksi' (Taxi) ne demektir?", Options = new List<string> { "das Taxi", "der Bus", "der Zug" }, Answer = "das Taxi" },
                        new QuizQuestion { Id = 11, Question = "'Pasaport' (Passport)?", Options = new List<string> { "der Reisepass", "das Visum", "der Ausweis" }, Answer = "der Reisepass" },
                        new QuizQuestion { Id = 12, Question = "'Harita' (Map) ne demektir?", Options = new List<string> { "die Karte", "der Plan", "das Bild" }, Answer = "die Karte" },
                        new QuizQuestion { Id = 13, Question = "'Kamera' (Camera) Almanca?", Options = new List<string> { "die Kamera", "das Foto", "das Bild" }, Answer = "die Kamera" },
                        new QuizQuestion { Id = 14, Question = "'Plaj' (Beach) ne demektir?", Options = new List<string> { "der Strand", "das Meer", "der See" }, Answer = "der Strand" },
                        new QuizQuestion { Id = 15, Question = "'Dağ' (Mountain) ne demektir?", Options = new List<string> { "der Berg", "der Hügel", "das Tal" }, Answer = "der Berg" },
                        new QuizQuestion { Id = 16, Question = "'Göl' (Lake) ne demektir?", Options = new List<string> { "der See", "das Meer", "der Fluss" }, Answer = "der See" },
                        new QuizQuestion { Id = 17, Question = "'Deniz' (Sea) ne demektir?", Options = new List<string> { "das Meer", "der Ozean", "der See" }, Answer = "das Meer" },
                        new QuizQuestion { Id = 18, Question = "'Otel Odası' (Hotel Room)?", Options = new List<string> { "das Hotelzimmer", "das Haus", "die Wohnung" }, Answer = "das Hotelzimmer" },
                        new QuizQuestion { Id = 19, Question = "'Bagaj Alım' (Baggage Claim)?", Options = new List<string> { "die Gepäckausgabe", "der Ausgang", "der Eingang" }, Answer = "die Gepäckausgabe" },
                        new QuizQuestion { Id = 20, Question = "'Çıkış' (Exit) ne demektir?", Options = new List<string> { "der Ausgang", "der Eingang", "die Tür" }, Answer = "der Ausgang" }
                    }
                },
                 new Lesson
                {
                    Id = 23,
                    Title = "23. Sağlık ve Yaşam 🩺",
                    Content = "Sağlık her şeyden önemlidir. Vücudumuzun bölümleri, hastalıklar ve doktorda kullanılan kelimeler.",
                    KeyPhrases = new List<string> { "der Kopf (baş)", "der Bauch (karın)", "der Arzt (doktor)", "das Krankenhaus (hastane)", "die Apotheke (eczane)" },
                    FunFact = "Almanya'da eczaneler (Apotheke) sokaklarda büyük kırmızı bir 'A' harfi ile gösterilir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Baş' (Head) Almanca nedir?", Options = new List<string> { "der Kopf", "der Arm", "das Bein" }, Answer = "der Kopf" },
                        new QuizQuestion { Id = 2, Question = "İlaç aldığımız yer (Eczane)?", Options = new List<string> { "die Schule", "die Apotheke", "die Bank" }, Answer = "die Apotheke" },
                        new QuizQuestion { Id = 3, Question = "'Hastane' ne anlama gelir?", Options = new List<string> { "das Krankenhaus", "das Hotel", "das Haus" }, Answer = "das Krankenhaus" },
                        new QuizQuestion { Id = 4, Question = "Doktorun Almancası?", Options = new List<string> { "der Lehrer", "der Arzt", "der Bäcker" }, Answer = "der Arzt" },
                        new QuizQuestion { Id = 5, Question = "'Karın' (Stomach) ne demek?", Options = new List<string> { "der Bauch", "der Rücken", "die Hand" }, Answer = "der Bauch" },
                        new QuizQuestion { Id = 6, Question = "'El' (Hand) Almanca?", Options = new List<string> { "die Hand", "der Arm", "der Finger" }, Answer = "die Hand" },
                        new QuizQuestion { Id = 7, Question = "'Bacak' (Leg) ne demektir?", Options = new List<string> { "das Bein", "der Fuß", "das Knie" }, Answer = "das Bein" },
                        new QuizQuestion { Id = 8, Question = "'Kol' (Arm) ne demektir?", Options = new List<string> { "der Arm", "die Hand", "der Kopf" }, Answer = "der Arm" },
                        new QuizQuestion { Id = 9, Question = "'Ayak' (Foot) ne demektir?", Options = new List<string> { "der Fuß", "das Bein", "der Schuh" }, Answer = "der Fuß" },
                        new QuizQuestion { Id = 10, Question = "'Kulak' (Ear) ne demektir?", Options = new List<string> { "das Ohr", "das Auge", "die Nase" }, Answer = "das Ohr" },
                        new QuizQuestion { Id = 11, Question = "'Burun' (Nose) Almanca?", Options = new List<string> { "die Nase", "der Mund", "das Ohr" }, Answer = "die Nase" },
                        new QuizQuestion { Id = 12, Question = "'Ağız' (Mouth) ne demektir?", Options = new List<string> { "der Mund", "die Zunge", "der Zahn" }, Answer = "der Mund" },
                        new QuizQuestion { Id = 13, Question = "'Diş' (Tooth) ne demektir?", Options = new List<string> { "der Zahn", "die Zunge", "der Hals" }, Answer = "der Zahn" },
                        new QuizQuestion { Id = 14, Question = "'İlaç' (Medicine) ne demektir?", Options = new List<string> { "die Medizin", "die Pille", "der Arzt" }, Answer = "die Medizin" },
                        new QuizQuestion { Id = 15, Question = "'Ağrı' (Pain) ne demektir?", Options = new List<string> { "der Schmerz", "die Krankheit", "das Fieber" }, Answer = "der Schmerz" },
                        new QuizQuestion { Id = 16, Question = "'Ateş' (Fever) ne demektir?", Options = new List<string> { "das Fieber", "die Kälte", "die Hitze" }, Answer = "das Fieber" },
                        new QuizQuestion { Id = 17, Question = "'Öksürük' (Cough) ne demektir?", Options = new List<string> { "der Husten", "der Schnupfen", "das Niesen" }, Answer = "der Husten" },
                        new QuizQuestion { Id = 18, Question = "'Sağlıklı' (Healthy) sıfatı?", Options = new List<string> { "Gesund", "Krank", "Fit" }, Answer = "Gesund" },
                        new QuizQuestion { Id = 19, Question = "'Kaza' (Accident) ne demektir?", Options = new List<string> { "der Unfall", "der Fall", "das Auto" }, Answer = "der Unfall" },
                        new QuizQuestion { Id = 20, Question = "'Ambulans' (Ambulance)?", Options = new List<string> { "der Krankenwagen", "das Krankenhaus", "der Arzt" }, Answer = "der Krankenwagen" }
                    }
                },
                 new Lesson
                {
                    Id = 24,
                    Title = "24. Eğlence ve Kültür 🎭",
                    Content = "Boş zamanlarımızda neler yaparız? Sinema, tiyatro, konserler ve müzik. Kültürel aktivitelerle ilgili kelimeler.",
                    KeyPhrases = new List<string> { "das Kino (sinema)", "die Musik (müzik)", "das Museum (müze)", "das Theater (tiyatro)", "der Film (film)" },
                    FunFact = "Dünyanın en prestijli film festivallerinden biri olan 'Berlinale' her yıl Şubat ayında Berlin'de düzenlenir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "Film izlediğimiz yer (Sinema)?", Options = new List<string> { "das Kino", "die Disko", "der Park" }, Answer = "das Kino" },
                        new QuizQuestion { Id = 2, Question = "'Müzik' Almanca nasıl yazılır?", Options = new List<string> { "die Music", "die Musik", "das Musık" }, Answer = "die Musik" },
                        new QuizQuestion { Id = 3, Question = "Tarihi eserlerin sergilendiği yer (Müze)?", Options = new List<string> { "das Museum", "die Schule", "das Stadion" }, Answer = "das Museum" },
                        new QuizQuestion { Id = 4, Question = "'Tiyatro' ne anlama gelir?", Options = new List<string> { "das Theater", "der Zirkus", "die Oper" }, Answer = "das Theater" },
                        new QuizQuestion { Id = 5, Question = "'Film' kelimesinin Almancası?", Options = new List<string> { "der Film", "das Buch", "das Bild" }, Answer = "der Film" },
                        new QuizQuestion { Id = 6, Question = "'Bilet' (Ticket) ne demektir?", Options = new List<string> { "die Eintrittskarte", "das Papier", "der Schein" }, Answer = "die Eintrittskarte" },
                        new QuizQuestion { Id = 7, Question = "'Sinema Perdesi' (Screen)?", Options = new List<string> { "die Leinwand", "der Bildschirm", "das Fenster" }, Answer = "die Leinwand" },
                        new QuizQuestion { Id = 8, Question = "'Sahne' (Stage) ne demektir?", Options = new List<string> { "die Bühne", "der Platz", "der Raum" }, Answer = "die Bühne" },
                        new QuizQuestion { Id = 9, Question = "'Yönetmen' (Director) kimdir?", Options = new List<string> { "der Regisseur", "der Schauspieler", "der Autor" }, Answer = "der Regisseur" },
                        new QuizQuestion { Id = 10, Question = "'Konser' (Concert) ne demektir?", Options = new List<string> { "das Konzert", "die Oper", "das Theater" }, Answer = "das Konzert" },
                        new QuizQuestion { Id = 11, Question = "'Parti/Eğlence' (Party)?", Options = new List<string> { "die Party", "das Fest", "die Feier" }, Answer = "die Party" },
                        new QuizQuestion { Id = 12, Question = "'Dans' (Dance) ne demektir?", Options = new List<string> { "der Tanz", "das Lied", "die Musik" }, Answer = "der Tanz" },
                        new QuizQuestion { Id = 13, Question = "'Sanat' (Art) ne demektir?", Options = new List<string> { "die Kunst", "das Bild", "die Farbe" }, Answer = "die Kunst" },
                        new QuizQuestion { Id = 14, Question = "'Sergi' (Exhibition) ne demektir?", Options = new List<string> { "die Ausstellung", "das Museum", "die Galerie" }, Answer = "die Ausstellung" },
                        new QuizQuestion { Id = 15, Question = "'Opera' Almanca nasıl yazılır?", Options = new List<string> { "die Oper", "das Theater", "die Musik" }, Answer = "die Oper" },
                        new QuizQuestion { Id = 16, Question = "'Kitap' (Book) ne demektir?", Options = new List<string> { "das Buch", "das Heft", "die Zeitung" }, Answer = "das Buch" },
                        new QuizQuestion { Id = 17, Question = "'Kütüphane' (Library)?", Options = new List<string> { "die Bibliothek", "die Bücherei", "die Schule" }, Answer = "die Bibliothek" },
                        new QuizQuestion { Id = 18, Question = "'Spor' (Sport) ne demektir?", Options = new List<string> { "der Sport", "das Spiel", "das Training" }, Answer = "der Sport" },
                        new QuizQuestion { Id = 19, Question = "'Oyun' (Game) ne demektir?", Options = new List<string> { "das Spiel", "der Spaß", "der Sport" }, Answer = "das Spiel" },
                        new QuizQuestion { Id = 20, Question = "'Eğlence/Şaka' (Fun)?", Options = new List<string> { "der Spaß", "der Witz", "das Spiel" }, Answer = "der Spaß" }
                    }
                },
                 new Lesson
                {
                    Id = 25,
                    Title = "25. Şarkılar 🎵",
                    Content = "Müzik ruhun gıdasıdır! En sevdiğimiz şarkılar, şarkıcılar ve müzik terimlerini Almanca öğrenelim.",
                    KeyPhrases = new List<string> { "das Lied (şarkı)", "der Sänger (şarkıcı)", "singen (şarkı söylemek)", "die Melodie (melodi)", "der Text (şarkı sözü)" },
                    FunFact = "'99 Luftballons' (99 Balon) dünya çapında en çok bilinen Almanca şarkılardan biridir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Şarkı' Almanca nedir?", Options = new List<string> { "das Lied", "das Gedicht", "das Bild" }, Answer = "das Lied" },
                        new QuizQuestion { Id = 2, Question = "Şarkı söyleyen kişi (Şarkıcı)?", Options = new List<string> { "der Lehrer", "der Sänger", "der Tänzer" }, Answer = "der Sänger" },
                        new QuizQuestion { Id = 3, Question = "'Şarkı söylemek' fiili?", Options = new List<string> { "singen", "sprechen", "hören" }, Answer = "singen" },
                        new QuizQuestion { Id = 4, Question = "Şarkının 'Melodisi'?", Options = new List<string> { "die Melodie", "der Rhythmus", "der Klang" }, Answer = "die Melodie" },
                        new QuizQuestion { Id = 5, Question = "'99 ...' (Meşhur Şarkı)?", Options = new List<string> { "Luftballons", "Autos", "Häuser" }, Answer = "Luftballons" },
                        new QuizQuestion { Id = 6, Question = "'Ritim' (Rhythm) ne demektir?", Options = new List<string> { "der Rhythmus", "der Takt", "der Ton" }, Answer = "der Rhythmus" },
                        new QuizQuestion { Id = 7, Question = "'Ses' (Voice) ne demektir?", Options = new List<string> { "die Stimme", "der Sound", "der Ton" }, Answer = "die Stimme" },
                        new QuizQuestion { Id = 8, Question = "'Gitar' (Guitar) ne demektir?", Options = new List<string> { "die Gitarre", "die Geige", "das Klavier" }, Answer = "die Gitarre" },
                        new QuizQuestion { Id = 9, Question = "'Piyano' (Piano) ne demektir?", Options = new List<string> { "das Klavier", "die Orgel", "das Keyboard" }, Answer = "das Klavier" },
                        new QuizQuestion { Id = 10, Question = "'Davul' (Drum) ne demektir?", Options = new List<string> { "die Trommel", "das Schlagzeug", "der Bass" }, Answer = "die Trommel" },
                        new QuizQuestion { Id = 11, Question = "'Keman' (Violin) ne demektir?", Options = new List<string> { "die Geige", "die Gitarre", "das Cello" }, Answer = "die Geige" },
                        new QuizQuestion { Id = 12, Question = "'Nota' (Note) ne demektir?", Options = new List<string> { "die Note", "der Ton", "der Klang" }, Answer = "die Note" },
                        new QuizQuestion { Id = 13, Question = "'Ses/Ton' (Sound) ne demektir?", Options = new List<string> { "der Klang", "der Ton", "das Geräusch" }, Answer = "der Klang" },
                        new QuizQuestion { Id = 14, Question = "'CD' Almanca nasıl yazılır?", Options = new List<string> { "die CD", "die DVD", "die Platte" }, Answer = "die CD" },
                        new QuizQuestion { Id = 15, Question = "'Radyo' (Radio) ne demektir?", Options = new List<string> { "das Radio", "der Fernseher", "das Telefon" }, Answer = "das Radio" },
                        new QuizQuestion { Id = 16, Question = "'Müzik Grubu' (Band)?", Options = new List<string> { "die Band", "die Gruppe", "das Team" }, Answer = "die Band" },
                        new QuizQuestion { Id = 17, Question = "'Nakarat' (Chorus) ne demektir?", Options = new List<string> { "der Refrain", "die Strophe", "der Text" }, Answer = "der Refrain" },
                        new QuizQuestion { Id = 18, Question = "'Dinlemek/Duymak' (Listen)?", Options = new List<string> { "hören", "sehen", "sprechen" }, Answer = "hören" },
                        new QuizQuestion { Id = 19, Question = "'Yüksek Sesli' (Loud)?", Options = new List<string> { "Laut", "Leise", "Schnell" }, Answer = "Laut" },
                        new QuizQuestion { Id = 20, Question = "'Sessiz/Alçak Sesli' (Quiet)?", Options = new List<string> { "Leise", "Laut", "Langsam" }, Answer = "Leise" }
                    }
                },
                 new Lesson
                {
                    Id = 26,
                    Title = "26. Spor ⚽",
                    Content = "Hareket, sağlık demektir! Popüler spor dallarını ve aktiviteleri Almanca öğrenelim.",
                    KeyPhrases = new List<string> { "der Fußball (futbol)", "das Schwimmen (yüzme)", "das Tennis (tenis)", "laufen (koşmak)", "das Spiel (oyun/maç)" },
                    FunFact = "Futbol (Fußball) Almanya'daki en popüler spordur. Bundesliga dünya çapında ünlüdür.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Futbol' Almanca nedir?", Options = new List<string> { "der Fußball", "der Handball", "der Basketball" }, Answer = "der Fußball" },
                        new QuizQuestion { Id = 2, Question = "Havuzda yaptığımız spor (Yüzme)?", Options = new List<string> { "das Schwimmen", "das Tauchen", "das Surfen" }, Answer = "das Schwimmen" },
                        new QuizQuestion { Id = 3, Question = "'Koşmak' fiilinin Almancası?", Options = new List<string> { "laufen", "gehen", "springen" }, Answer = "laufen" },
                        new QuizQuestion { Id = 4, Question = "Raketle oynanan spor (Tenis)?", Options = new List<string> { "das Tennis", "das Golf", "das Badminton" }, Answer = "das Tennis" },
                        new QuizQuestion { Id = 5, Question = "'Oyun/Maç' ne anlama gelir?", Options = new List<string> { "das Spiel", "der Sport", "der Sieg" }, Answer = "das Spiel" },
                        new QuizQuestion { Id = 6, Question = "'Basketbol' Almanca nasıl yazılır?", Options = new List<string> { "der Basketball", "der Korbball", "der Ball" }, Answer = "der Basketball" },
                        new QuizQuestion { Id = 7, Question = "'Voleybol' ne demektir?", Options = new List<string> { "der Volleyball", "der Handball", "der Fußball" }, Answer = "der Volleyball" },
                        new QuizQuestion { Id = 8, Question = "Kazanan kişi (Galip)?", Options = new List<string> { "der Sieger", "der Verlierer", "der Spieler" }, Answer = "der Sieger" },
                        new QuizQuestion { Id = 9, Question = "Kaybeden kişi (Mağlup)?", Options = new List<string> { "der Verlierer", "der Sieger", "der Trainer" }, Answer = "der Verlierer" },
                        new QuizQuestion { Id = 10, Question = "'Takım' (Team) ne demektir?", Options = new List<string> { "die Mannschaft", "die Gruppe", "der Verein" }, Answer = "die Mannschaft" },
                        new QuizQuestion { Id = 11, Question = "'Stadyum' Almanca?", Options = new List<string> { "das Stadion", "die Halle", "der Platz" }, Answer = "das Stadion" },
                        new QuizQuestion { Id = 12, Question = "'Top' (Ball) ne demektir?", Options = new List<string> { "der Ball", "das Tor", "das Spiel" }, Answer = "der Ball" },
                        new QuizQuestion { Id = 13, Question = "Futbolda atılan sayı (Gol)?", Options = new List<string> { "das Tor", "der Punkt", "der Sieg" }, Answer = "das Tor" },
                        new QuizQuestion { Id = 14, Question = "Maçı yöneten kişi (Hakem)?", Options = new List<string> { "der Schiedsrichter", "der Trainer", "der Spieler" }, Answer = "der Schiedsrichter" },
                        new QuizQuestion { Id = 15, Question = "'Madalya' (Medal) ne demektir?", Options = new List<string> { "die Medaille", "der Pokal", "der Preis" }, Answer = "die Medaille" },
                        new QuizQuestion { Id = 16, Question = "'Sportif' (Sporty) sıfatı?", Options = new List<string> { "Sportlich", "Schnell", "Stark" }, Answer = "Sportlich" },
                        new QuizQuestion { Id = 17, Question = "'Antrenman' (Training)?", Options = new List<string> { "das Training", "die Übung", "das Spiel" }, Answer = "das Training" },
                        new QuizQuestion { Id = 18, Question = "'Bisiklet' (Bicycle) ne demektir?", Options = new List<string> { "das Fahrrad", "das Auto", "der Bus" }, Answer = "das Fahrrad" },
                        new QuizQuestion { Id = 19, Question = "'Kayak Yapmak' (Skiing)?", Options = new List<string> { "Skifahren", "Laufen", "Springen" }, Answer = "Skifahren" },
                        new QuizQuestion { Id = 20, Question = "Taraftarlar (Fans)?", Options = new List<string> { "die Fans", "die Zuschauer", "die Leute" }, Answer = "die Fans" }
                    }
                },
                 new Lesson
                {
                    Id = 27,
                    Title = "27. Teknoloji ve İnternet 💻",
                    Content = "Dijital çağın kelimeleri. Bilgisayarlar, akıllı telefonlar ve internet dünyası hakkında konuşalım.",
                    KeyPhrases = new List<string> { "der Computer (bilgisayar)", "das Handy (cep telefonu)", "das Internet (internet)", "die E-Mail (e-posta)", "chatten (sohbet etmek)" },
                    FunFact = "'Handy' kelimesi Almancada 'cep telefonu' demektir, ancak İngilizcede bu kelime 'kullanışlı' anlamına gelir!",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Bilgisayar' Almanca nedir?", Options = new List<string> { "der Computer", "die Maus", "der Bildschirm" }, Answer = "der Computer" },
                        new QuizQuestion { Id = 2, Question = "Cep telefonu (Mobile Phone)?", Options = new List<string> { "das Handy", "das Telefon", "der Ruf" }, Answer = "das Handy" },
                        new QuizQuestion { Id = 3, Question = "'İnternet' Almanca nasıl yazılır?", Options = new List<string> { "das Internet", "die Verbindung", "das Netz" }, Answer = "das Internet" },
                        new QuizQuestion { Id = 4, Question = "'Sohbet etmek' (Chat) fiili?", Options = new List<string> { "chatten", "sprechen", "schreiben" }, Answer = "chatten" },
                        new QuizQuestion { Id = 5, Question = "'E-posta' kelimesinin Almancası?", Options = new List<string> { "die E-Mail", "der Brief", "die Post" }, Answer = "die E-Mail" },
                        new QuizQuestion { Id = 6, Question = "'Klavye' (Keyboard) ne demektir?", Options = new List<string> { "die Tastatur", "die Taste", "der Text" }, Answer = "die Tastatur" },
                        new QuizQuestion { Id = 7, Question = "'Fare' (Mouse) ne demektir?", Options = new List<string> { "die Maus", "der Ratte", "das Tier" }, Answer = "die Maus" },
                        new QuizQuestion { Id = 8, Question = "'Ekran' (Screen) ne demektir?", Options = new List<string> { "der Bildschirm", "das Fenster", "das Bild" }, Answer = "der Bildschirm" },
                        new QuizQuestion { Id = 9, Question = "'Dizüstü Bilgisayar' (Laptop)?", Options = new List<string> { "der Laptop", "der Computer", "das Notebook" }, Answer = "der Laptop" },
                        new QuizQuestion { Id = 10, Question = "'Şifre' (Password) ne demektir?", Options = new List<string> { "das Passwort", "der Code", "der Schlüssel" }, Answer = "das Passwort" },
                        new QuizQuestion { Id = 11, Question = "'Kablosuz Ağ' (Wi-Fi)?", Options = new List<string> { "das WLAN", "das Netz", "die Verbindung" }, Answer = "das WLAN" },
                        new QuizQuestion { Id = 12, Question = "'Pil/Batarya' (Battery)?", Options = new List<string> { "der Akku", "die Batterie", "der Strom" }, Answer = "der Akku" },
                        new QuizQuestion { Id = 13, Question = "'Uygulama' (App) ne demektir?", Options = new List<string> { "die App", "das Programm", "die Anwendung" }, Answer = "die App" },
                        new QuizQuestion { Id = 14, Question = "'Web Sitesi' ne demektir?", Options = new List<string> { "die Webseite", "die Seite", "das Internet" }, Answer = "die Webseite" },
                        new QuizQuestion { Id = 15, Question = "'Bağlantı' (Link) ne demektir?", Options = new List<string> { "der Link", "die Verbindung", "die Kette" }, Answer = "der Link" },
                        new QuizQuestion { Id = 16, Question = "'Robot' Almanca nasıl yazılır?", Options = new List<string> { "der Roboter", "die Maschine", "das Gerät" }, Answer = "der Roboter" },
                        new QuizQuestion { Id = 17, Question = "'Tıklamak' (Click) fiili?", Options = new List<string> { "klicken", "drücken", "tippen" }, Answer = "klicken" },
                        new QuizQuestion { Id = 18, Question = "'Dijital' kelimesinin Almancası?", Options = new List<string> { "Digital", "Analog", "Elektronisch" }, Answer = "Digital" },
                        new QuizQuestion { Id = 19, Question = "'Kamera' ne anlama gelir?", Options = new List<string> { "die Kamera", "das Bild", "das Foto" }, Answer = "die Kamera" },
                        new QuizQuestion { Id = 20, Question = "'Tablet' Almanca nasıl yazılır?", Options = new List<string> { "das Tablet", "der Tisch", "die Tafel" }, Answer = "das Tablet" }
                    }
                },
                 new Lesson
                {
                    Id = 28,
                    Title = "28. Resim ve Sanat 🎨",
                    Content = "Sanatın renkli dünyası! Resim yapmak, renkler ve sanat malzemeleri ile ilgili kelimeler.",
                    KeyPhrases = new List<string> { "das Bild (resim)", "der Maler (ressam)", "malen (resim yapmak)", "die Farbe (renk)", "der Pinsel (fırça)" },
                    FunFact = "Albrecht Dürer, Alman Rönesansı'nın en ünlü ressamlarından biridir.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Resim' Almanca nedir?", Options = new List<string> { "das Bild", "das Foto", "die Wand" }, Answer = "das Bild" },
                        new QuizQuestion { Id = 2, Question = "Resim yapan sanatçı (Ressam)?", Options = new List<string> { "der Maler", "der Arzt", "der Lehrer" }, Answer = "der Maler" },
                        new QuizQuestion { Id = 3, Question = "'Resim yapmak' (Boyamak) fiili?", Options = new List<string> { "malen", "schreiben", "lesen" }, Answer = "malen" },
                        new QuizQuestion { Id = 4, Question = "'Fırça' kelimesinin Almancası?", Options = new List<string> { "der Pinsel", "der Stift", "das Messer" }, Answer = "der Pinsel" },
                        new QuizQuestion { Id = 5, Question = "'Renk' ne anlama gelir?", Options = new List<string> { "die Farbe", "das Licht", "der Schatten" }, Answer = "die Farbe" },
                        new QuizQuestion { Id = 6, Question = "'Çizim' (Drawing) ne demektir?", Options = new List<string> { "die Zeichnung", "das Bild", "der Strich" }, Answer = "die Zeichnung" },
                        new QuizQuestion { Id = 7, Question = "Sanat eserlerinin olduğu yer (Müze)?", Options = new List<string> { "das Museum", "die Schule", "das Kino" }, Answer = "das Museum" },
                        new QuizQuestion { Id = 8, Question = "'Galeri' (Gallery) ne demektir?", Options = new List<string> { "die Galerie", "der Raum", "die Halle" }, Answer = "die Galerie" },
                        new QuizQuestion { Id = 9, Question = "'Heykel' (Sculpture) ne demektir?", Options = new List<string> { "die Skulptur", "der Stein", "die Statue" }, Answer = "die Skulptur" },
                        new QuizQuestion { Id = 10, Question = "'Sanat' (Art) ne anlama gelir?", Options = new List<string> { "die Kunst", "das Leben", "die Welt" }, Answer = "die Kunst" },
                        new QuizQuestion { Id = 11, Question = "'Sanatçı' (Artist) genel adı?", Options = new List<string> { "der Künstler", "der Maler", "der Autor" }, Answer = "der Künstler" },
                        new QuizQuestion { Id = 12, Question = "'Tuval' (Canvas) ne demektir?", Options = new List<string> { "die Leinwand", "das Papier", "der Stoff" }, Answer = "die Leinwand" },
                        new QuizQuestion { Id = 13, Question = "'Eskiz' (Sketch) ne demektir?", Options = new List<string> { "die Skizze", "der Entwurf", "das Bild" }, Answer = "die Skizze" },
                        new QuizQuestion { Id = 14, Question = "'Portre' (Portrait) ne demektir?", Options = new List<string> { "das Porträt", "das Gesicht", "der Kopf" }, Answer = "das Porträt" },
                        new QuizQuestion { Id = 15, Question = "'Tasarım' (Design) Almanca?", Options = new List<string> { "das Design", "die Form", "der Plan" }, Answer = "das Design" },
                        new QuizQuestion { Id = 16, Question = "'Yaratıcı' (Creative) sıfatı?", Options = new List<string> { "Kreativ", "Klug", "Schnell" }, Answer = "Kreativ" },
                        new QuizQuestion { Id = 17, Question = "'Sergi' (Exhibition) ne demektir?", Options = new List<string> { "die Ausstellung", "die Vorstellung", "die Show" }, Answer = "die Ausstellung" },
                        new QuizQuestion { Id = 18, Question = "'Kurşun Kalem' (Pencil)?", Options = new List<string> { "der Bleistift", "der Pinsel", "die Farbe" }, Answer = "der Bleistift" },
                        new QuizQuestion { Id = 19, Question = "'Güzellik' (Beauty) ne demektir?", Options = new List<string> { "die Schönheit", "die Kunst", "das Bild" }, Answer = "die Schönheit" },
                        new QuizQuestion { Id = 20, Question = "'Tarz/Stil' (Style) ne demektir?", Options = new List<string> { "der Stil", "die Art", "die Mode" }, Answer = "der Stil" }
                    }
                },
                 new Lesson
                {
                    Id = 29,
                    Title = "29. Bilim 🔬",
                    Content = "Bilimin büyüleyici dünyası. Deneyler, laboratuvarlar ve bilim insanları hakkında kelimeler.",
                    KeyPhrases = new List<string> { "die Wissenschaft (bilim)", "der Wissenschaftler (bilim insanı)", "das Labor (laboratuvar)", "das Experiment (deney)", "forschen (araştırmak)" },
                    FunFact = "Albert Einstein, Almanya'nın Ulm şehrinde doğmuştur.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Bilim' Almanca nedir?", Options = new List<string> { "die Wissenschaft", "die Schule", "das Wissen" }, Answer = "die Wissenschaft" },
                        new QuizQuestion { Id = 2, Question = "Bilimsel çalışmaların yapıldığı yer (Laboratuvar)?", Options = new List<string> { "das Labor", "das Büro", "die Fabrik" }, Answer = "das Labor" },
                        new QuizQuestion { Id = 3, Question = "'Bilim İnsanı' kimdir?", Options = new List<string> { "der Wissenschaftler", "der Lehrer", "der Ingenieur" }, Answer = "der Wissenschaftler" },
                        new QuizQuestion { Id = 4, Question = "'Deney' ne anlama gelir?", Options = new List<string> { "das Experiment", "die Probe", "der Test" }, Answer = "das Experiment" },
                        new QuizQuestion { Id = 5, Question = "'Araştırmak' fiilinin Almancası?", Options = new List<string> { "forschen", "suchen", "finden" }, Answer = "forschen" },
                        new QuizQuestion { Id = 6, Question = "'Kimya' (Chemistry) ne demektir?", Options = new List<string> { "die Chemie", "die Physik", "die Biologie" }, Answer = "die Chemie" },
                        new QuizQuestion { Id = 7, Question = "'Fizik' (Physics) ne demektir?", Options = new List<string> { "die Physik", "die Chemie", "die Musik" }, Answer = "die Physik" },
                        new QuizQuestion { Id = 8, Question = "'Biyoloji' (Biology) ne demektir?", Options = new List<string> { "die Biologie", "die Natur", "das Leben" }, Answer = "die Biologie" },
                        new QuizQuestion { Id = 9, Question = "'Matematik' Almanca?", Options = new List<string> { "die Mathematik", "die Zahl", "das Rechnen" }, Answer = "die Mathematik" },
                        new QuizQuestion { Id = 10, Question = "'Uzay' (Space) ne demektir?", Options = new List<string> { "der Weltraum", "der Himmel", "die Erde" }, Answer = "der Weltraum" },
                        new QuizQuestion { Id = 11, Question = "'Atom' Almanca nasıl yazılır?", Options = new List<string> { "das Atom", "das Teil", "der Kern" }, Answer = "das Atom" },
                        new QuizQuestion { Id = 12, Question = "'Enerji' (Energy) ne demektir?", Options = new List<string> { "die Energie", "die Kraft", "der Strom" }, Answer = "die Energie" },
                        new QuizQuestion { Id = 13, Question = "'Mikroskop' ne anlama gelir?", Options = new List<string> { "das Mikroskop", "die Brille", "das Glas" }, Answer = "das Mikroskop" },
                        new QuizQuestion { Id = 14, Question = "'Teori' (Theory) ne demektir?", Options = new List<string> { "die Theorie", "die Idee", "der Plan" }, Answer = "die Theorie" },
                        new QuizQuestion { Id = 15, Question = "'Doğa' (Nature) ne demektir?", Options = new List<string> { "die Natur", "der Wald", "die Welt" }, Answer = "die Natur" },
                        new QuizQuestion { Id = 16, Question = "'Gezegen' (Planet) ne demektir?", Options = new List<string> { "der Planet", "der Stern", "der Mond" }, Answer = "der Planet" },
                        new QuizQuestion { Id = 17, Question = "'Üniversite' (University)?", Options = new List<string> { "die Universität", "die Schule", "das Institut" }, Answer = "die Universität" },
                        new QuizQuestion { Id = 18, Question = "'Bilgi' (Knowledge) ne demektir?", Options = new List<string> { "das Wissen", "die Information", "die Daten" }, Answer = "das Wissen" },
                        new QuizQuestion { Id = 19, Question = "'Teknoloji' Almanca?", Options = new List<string> { "die Technologie", "die Technik", "die Maschine" }, Answer = "die Technologie" },
                        new QuizQuestion { Id = 20, Question = "'Gelecek' (Future) ne demektir?", Options = new List<string> { "die Zukunft", "die Zeit", "das Jahr" }, Answer = "die Zukunft" }
                    }
                },
                 new Lesson
                {
                    Id = 30,
                    Title = "30. Satranç ♟️",
                    Content = "Strateji ve zeka oyunu satranç. Taşların isimleri ve oyun terimleri.",
                    KeyPhrases = new List<string> { "das Schach (satranç)", "der König (şah)", "die Dame (vezir)", "der Turm (kale)", "der Bauer (piyon)" },
                    FunFact = "Dünya Satranç Şampiyonu Emanuel Lasker, 27 yıl boyunca unvanını koruyan bir Alman matematikçiydi.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Satranç' Almanca nedir?", Options = new List<string> { "das Schach", "das Spiel", "der Sport" }, Answer = "das Schach" },
                        new QuizQuestion { Id = 2, Question = "Oyunun en önemli taşı (Şah)?", Options = new List<string> { "der König", "der Bauer", "das Pferd" }, Answer = "der König" },
                        new QuizQuestion { Id = 3, Question = "'Vezir' (Queen) taşı?", Options = new List<string> { "die Dame", "der Läufer", "der Turm" }, Answer = "die Dame" },
                        new QuizQuestion { Id = 4, Question = "'Kale' (Rook) taşı?", Options = new List<string> { "der Turm", "das Haus", "die Wand" }, Answer = "der Turm" },
                        new QuizQuestion { Id = 5, Question = "En çok bulunan taş (Piyon)?", Options = new List<string> { "der Bauer", "der Soldat", "der Mann" }, Answer = "der Bauer" },
                        new QuizQuestion { Id = 6, Question = "'At' (Knight) taşı?", Options = new List<string> { "der Springer", "das Pferd", "der Reiter" }, Answer = "der Springer" },
                        new QuizQuestion { Id = 7, Question = "'Fil' (Bishop) taşı?", Options = new List<string> { "der Läufer", "der Elefant", "der Bischof" }, Answer = "der Läufer" },
                        new QuizQuestion { Id = 8, Question = "'Satranç Tahtası' (Board)?", Options = new List<string> { "das Schachbrett", "der Tisch", "das Feld" }, Answer = "das Schachbrett" },
                        new QuizQuestion { Id = 9, Question = "'Hamle' (Move) ne demektir?", Options = new List<string> { "der Zug", "der Schritt", "der Lauf" }, Answer = "der Zug" },
                        new QuizQuestion { Id = 10, Question = "'Şah Mat' (Checkmate)?", Options = new List<string> { "Schachmatt", "Schach", "Matt" }, Answer = "Schachmatt" },
                        new QuizQuestion { Id = 11, Question = "'Beyaz' (White) taşlar?", Options = new List<string> { "Weiß", "Schwarz", "Rot" }, Answer = "Weiß" },
                        new QuizQuestion { Id = 12, Question = "'Siyah' (Black) taşlar?", Options = new List<string> { "Schwarz", "Weiß", "Blau" }, Answer = "Schwarz" },
                        new QuizQuestion { Id = 13, Question = "'Strateji' Almanca?", Options = new List<string> { "die Strategie", "der Plan", "die Idee" }, Answer = "die Strategie" },
                        new QuizQuestion { Id = 14, Question = "'Taşlar/Figürler' (Pieces)?", Options = new List<string> { "die Figuren", "die Teile", "die Steine" }, Answer = "die Figuren" },
                        new QuizQuestion { Id = 15, Question = "Satranç bir ... (Oyun)?", Options = new List<string> { "Spiel", "Sport", "Kampf" }, Answer = "Spiel" },
                        new QuizQuestion { Id = 16, Question = "'Oyuncu' (Player) ne demektir?", Options = new List<string> { "der Spieler", "der Gegner", "der Partner" }, Answer = "der Spieler" },
                        new QuizQuestion { Id = 17, Question = "'Satranç Saati' (Clock)?", Options = new List<string> { "die Schachuhr", "die Zeit", "die Stunde" }, Answer = "die Schachuhr" },
                        new QuizQuestion { Id = 18, Question = "'Kazanmak' (Win) fiili?", Options = new List<string> { "gewinnen", "verlieren", "spielen" }, Answer = "gewinnen" },
                        new QuizQuestion { Id = 19, Question = "'Berabere' (Draw) ne demektir?", Options = new List<string> { "Remis", "Gleich", "Null" }, Answer = "Remis" },
                        new QuizQuestion { Id = 20, Question = "'Rakip' (Opponent) ne demektir?", Options = new List<string> { "der Gegner", "der Feind", "der Freund" }, Answer = "der Gegner" }
                    }
                },
                 new Lesson
                {
                    Id = 31,
                    Title = "31. Kodlama 💻",
                    Content = "Geleceğin dili kodlama! Yazılım dünyasında kullanılan temel terimleri Almanca öğrenelim.",
                    KeyPhrases = new List<string> { "das Programmieren (kodlama)", "der Code (kod)", "der Entwickler (geliştirici)", "die Datei (dosya)", "speichern (kaydetmek)" },
                    FunFact = "Dünyanın ilk programlanabilir bilgisayarı Z3, Alman mühendis Konrad Zuse tarafından 1941'de yapılmıştır.",
                    Quiz = new List<QuizQuestion>
                    {
                        new QuizQuestion { Id = 1, Question = "'Kodlama' Almanca nedir?", Options = new List<string> { "das Programmieren", "das Spielen", "das Lesen" }, Answer = "das Programmieren" },
                        new QuizQuestion { Id = 2, Question = "Yazılım geliştiren kişi (Geliştirici)?", Options = new List<string> { "der Entwickler", "der Manager", "der Designer" }, Answer = "der Entwickler" },
                        new QuizQuestion { Id = 3, Question = "'Dosya' ne anlama gelir?", Options = new List<string> { "die Datei", "der Ordner", "das Fenster" }, Answer = "die Datei" },
                        new QuizQuestion { Id = 4, Question = "'Kaydetmek' fiilinin Almancası?", Options = new List<string> { "speichern", "löschen", "öffnen" }, Answer = "speichern" },
                        new QuizQuestion { Id = 5, Question = "'Kod' kelimesinin Almancası?", Options = new List<string> { "der Code", "das Wort", "die Zahl" }, Answer = "der Code" },
                        new QuizQuestion { Id = 6, Question = "'Hata/Böcek' (Bug) ne demektir?", Options = new List<string> { "der Fehler", "das Insekt", "das Problem" }, Answer = "der Fehler" },
                        new QuizQuestion { Id = 7, Question = "'Yazılım' (Software) ne demektir?", Options = new List<string> { "die Software", "das Programm", "der Code" }, Answer = "die Software" },
                        new QuizQuestion { Id = 8, Question = "'Donanım' (Hardware)?", Options = new List<string> { "die Hardware", "das Gerät", "der Computer" }, Answer = "die Hardware" },
                        new QuizQuestion { Id = 9, Question = "'Veri' (Data) ne demektir?", Options = new List<string> { "die Daten", "die Info", "das Wissen" }, Answer = "die Daten" },
                        new QuizQuestion { Id = 10, Question = "'Sunucu' (Server) ne demektir?", Options = new List<string> { "der Server", "der Computer", "das Netz" }, Answer = "der Server" },
                        new QuizQuestion { Id = 11, Question = "'Veritabanı' (Database)?", Options = new List<string> { "die Datenbank", "die Liste", "der Speicher" }, Answer = "die Datenbank" },
                        new QuizQuestion { Id = 12, Question = "'Ağ' (Network) ne demektir?", Options = new List<string> { "das Netzwerk", "das Modell", "die Verbindung" }, Answer = "das Netzwerk" },
                        new QuizQuestion { Id = 13, Question = "'Kullanıcı' (User) ne demektir?", Options = new List<string> { "der Benutzer", "der Kunde", "der Mensch" }, Answer = "der Benutzer" },
                        new QuizQuestion { Id = 14, Question = "'Giriş Yapmak' (Login)?", Options = new List<string> { "sich anmelden", "sich abmelden", "registrieren" }, Answer = "sich anmelden" },
                        new QuizQuestion { Id = 15, Question = "'Fonksiyon' (Function)?", Options = new List<string> { "die Funktion", "die Aktion", "die Aufgabe" }, Answer = "die Funktion" },
                        new QuizQuestion { Id = 16, Question = "'Değişken' (Variable)?", Options = new List<string> { "die Variable", "der Wert", "die Zahl" }, Answer = "die Variable" },
                        new QuizQuestion { Id = 17, Question = "'Döngü' (Loop) ne demektir?", Options = new List<string> { "die Schleife", "der Kreis", "die Wiederholung" }, Answer = "die Schleife" },
                        new QuizQuestion { Id = 18, Question = "'Algoritma' Almanca?", Options = new List<string> { "der Algorithmus", "die Regel", "das Gesetz" }, Answer = "der Algorithmus" },
                        new QuizQuestion { Id = 19, Question = "'İkili' (Binary) ne demektir?", Options = new List<string> { "Binär", "Digital", "Zwei" }, Answer = "Binär" },
                        new QuizQuestion { Id = 20, Question = "'Program' ne demektir?", Options = new List<string> { "das Programm", "der Plan", "das Projekt" }, Answer = "das Programm" }
                    }
                }
            };
        }

        public List<VocabularyWord> GetVocabulary()
        {
            return new List<VocabularyWord>
            {
                new VocabularyWord { German = "der Apfel", Turkish = "elma", Example = "Ich esse einen Apfel." },
                new VocabularyWord { German = "das Haus", Turkish = "ev", Example = "Das Haus ist groß." },
                new VocabularyWord { German = "die Katze", Turkish = "kedi", Example = "Die Katze schlaft." },
                new VocabularyWord { German = "das Buch", Turkish = "kitap", Example = "Liest du das Buch?" },
                new VocabularyWord { German = "trinken", Turkish = "içmek", Example = "Wir trinken Wasser." },
                new VocabularyWord { German = "fahren", Turkish = "sürmek/gitmek", Example = "Er fährt ein Auto." },
                new VocabularyWord { German = "essen", Turkish = "yemek", Example = "Ich esse gern Pizza." },
                new VocabularyWord { German = "lernen", Turkish = "öğrenmek", Example = "Sie lernen Deutsch." },
                new VocabularyWord { German = "sprechen", Turkish = "konuşmak", Example = "Wir sprechen oft." },
                new VocabularyWord { German = "Wasser", Turkish = "su", Example = "Ich trinke Wasser." }
            };
        }

        public List<GeneralQuizQuestion> GetGeneralQuizQuestions()
        {
            return new List<GeneralQuizQuestion>
            {
                new GeneralQuizQuestion { Id = 1, Type = "translation", Question = "Guten Tag ne anlama gelir?", Answer = "İyi günler" },
                new GeneralQuizQuestion { Id = 2, Type = "translation", Question = "Elma kelimesinin Almancası nedir?", Answer = "der Apfel" },
                new GeneralQuizQuestion { Id = 3, Type = "translation", Question = "Zehn hangi sayıdır?", Answer = "on" },
                new GeneralQuizQuestion { Id = 4, Type = "translation", Question = "Nasıl gidiyor? sorusunun Almancası nedir?", Answer = "Wie geht es Ihnen?" },
                new GeneralQuizQuestion { Id = 5, Type = "translation", Question = "Ev kelimesinin Almancası nedir?", Answer = "das Haus" },
                new GeneralQuizQuestion { Id = 6, Type = "translation", Question = "İçmek fiilinin Almancası nedir?", Answer = "trinken" },
                new GeneralQuizQuestion { Id = 7, Type = "translation", Question = "Lütfen kelimesinin Almancası nedir?", Answer = "bitte" },
                new GeneralQuizQuestion { Id = 8, Type = "translation", Question = "Teşekkürler kelimesinin Almancası nedir?", Answer = "danke" },
                new GeneralQuizQuestion { Id = 9, Type = "translation", Question = "Sekiz sayısının Almancası nedir?", Answer = "acht" },
                new GeneralQuizQuestion { Id = 10, Type = "translation", Question = "Gitmek fiilinin Almancası nedir?", Answer = "gehen" }
            };
        }
    }
}
