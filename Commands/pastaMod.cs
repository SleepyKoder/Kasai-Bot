using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaibot.Commands
{
    public class pastaMod : ModuleBase<SocketCommandContext>
    {
        [Command("copypasta")]
        public async Task copypasta([Remainder]string message)
        {
            var embed = new EmbedBuilder();
            if (message == "burger king")
            {
                await Context.Channel.SendMessageAsync
                    (@"Number 15, Burgur King foot lettuce. The last thing you'd want in your Burger King burger is someone's foot fungus. But as it turns out, that might be what you get. A 4channer uploaded a photo anonymously to the site showcasing his feet in a plastic bin of lettuce. With the statement: *This is the lettuce you eat at Burger King*. Admittedly, he had shoes on. But that's even worse.");

                await Context.Message.DeleteAsync();
            }

            if (message == "bee movie")
            {
                await Context.Channel.SendMessageAsync
                    (@"According to all known laws of aviation, there is no way a bee should be able to fly." + System.Environment.NewLine +
                    @"Its wings are too small to get its fat little body off the ground." + System.Environment.NewLine +
                    @"The bee, of course, flies anyway" + System.Environment.NewLine +
                    @"because bees don't care what humans think is impossible.");

                await Context.Message.DeleteAsync();
            }

            if (message == "yeet")
            {
                await Context.Channel.SendMessageAsync
                    (@"**Yeet**" + System.Environment.NewLine+ 
                    @"Such a word can never be truly described in all of its glory. To be fair, you need a really high IQ to simply UNDERSTAND the beauty of *Yeet* The mix of two vowels in the middle, the oddity of *t* at the end to mix the words together in a strange yet intriguing way, and the powerful, elongated *Y* at the beginning all make this word the beauty of what it really is. No such mortal being could have formed such a word, no! Only a true god, THE god, would be capable of forming such eloquent language!");

                await Context.Message.DeleteAsync();
            }

            if (message == "loss")
            {
                await Context.Channel.SendMessageAsync
                    (@"✋Excuse me sir ✋ 👏but 👏👉is that original post you made 👉right there 👉loss ❓ ☝Now hold on ☝😡it might sound ridiculous 😡😤but bare with me here. 😤👀You see 👀 there's 4️⃣ panels ☝let's count them ☝ 1️⃣ 2️⃣ 3️⃣ 4️⃣ panels ❗️❗️✋And you know what else has 4️⃣ panels ❓😤That's right 😤😡loss does ❗️😡 👇But i'm not done yet 👇 👀you see 👀👉in the first panel 👉☝there is ☝ 1️⃣ object 👈 positioned slightly to the left. 👈 😡Should I even continue ❓😡😤I guess I will 😤😒as you still don't understand. 😒 😲I should clarify this is a level 5 loss meme 😲🙄so I don't expect you to understand it. 🙄 💁‍ Anyways 💁‍ ✌️ in the second panel ✌️👀there are 2️⃣ objects 👀👉next to each other 👉 👇with one being slightly below the other. 👇☝ In the 3️⃣rd panel ☝ ✌️another 2️⃣ objects are present ✌️ 🙌right next to each other. 🙌 👆 Finally, 👆 there are, yet again, 2️⃣ objects 👆 🤙 which form an L shape. 🤙 👀Everything looks like it's adding up 👀😤therefore😤😡it HAS to be loss ❗️❗️😒You need to make it less obvious next time 😒🙄if you want it to be more funny. 🙄");
                //I really hated doing this btw

                await Context.Message.DeleteAsync();
            }

            if (message == "navy seal")
            {
                await Context.Channel.SendMessageAsync
                    (@"What the fuck did you just fucking say about me, you little shit? I'll have you know I graduated top of my class in the Navy Seals, and I've been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla warfare and Im the top sniper in the entire US armed forces. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life. You're fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and thats just with my bare hands. Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. If only you could have known what unholy retribution your little clever comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldnt, you didnt, and now youre paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. Youre fucking dead, kiddo.");
                await Context.Message.DeleteAsync();
            }

            if (message == "despacito")
            {
                await Context.Channel.SendMessageAsync(@"So today in Spanish class, my teacher told us that we would be listening to a song in Spanish. Already, I began to tremble. I had a bad feeling about this. “Which one?” I ask shakily, not wanting to hear the answer. “Despacito” She responds. I begin to hyperventilate. My worst fears have been realized. I fade in and out of conciseness. I clamp my palms over my ears, but I know it’s futile. The song plays. I’m crying now, praying. God, Allah, Buddha please help me. I curl up on the floor. There’s nothing I can do now. And then it happens. The chorus plays. The girls in my class open their mouths. The screams of the damned, the shrieks of the tortured fill my ears and bounce around my skull. My eardrums rupture, blood leaking out. I try to scream, but no sound comes out. I can only sit there, violently shaking as it happens to me. After what seems like hours, it’s finally over. I try to move, but I cannot make myself. My brain shuts down as my vision fades to black. I muster the last of my energy, uttering the accursed word." + System.Environment.NewLine + @"*Despacito*");

                await Context.Message.DeleteAsync();
            }

            if (message == "rick and morty")
            {
                await Context.Channel.SendMessageAsync(@"To be fair, you have to have a very high IQ to understand Rick and Morty. The humor is extremely subtle, and without a solid grasp of theoretical physics most of the jokes will go over a typical viewer's head. There's also Rick's nihilistic outlook, which is deftly woven into his characterisation - his personal philosophy draws heavily from Narodnaya Volya literature, for instance. The fans understand this stuff; they have the intellectual capacity to truly appreciate the depths of these jokes, to realize that they're not just funny- they say something deep about LIFE. As a consequence people who dislike Rick and Morty truly ARE idiots- of course they wouldn't appreciate, for instance, the humour in Rick's existencial catchphrase *Wubba Lubba Dub Dub*, which itself is a cryptic reference to Turgenev's Russian epic Fathers and Sons I'm smirking right now just imagining one of those addlepated simpletons scratching their heads in confusion as Dan Harmon's genius unfolds itself on their television screens. What fools... how I pity them. 😂 And yes by the way, I DO have a Rick and Morty tattoo. And no, you cannot see it. It's for the ladies' eyes only- And even they have to demonstrate that they're within 5 IQ points of my own (preferably lower) beforehand.");

                await Context.Message.DeleteAsync();
            } 

            if (message == "ea")
            {
                await Context.Channel.SendMessageAsync(@"    The intent is to provide players with a sense of pride and accomplishment for unlocking different heroes.

    As for cost, we selected initial values based upon data from the Open Beta and other adjustments made to milestone rewards before launch. Among other things, we’re looking at average per-player credit earn rates on a daily basis, and we’ll be making constant adjustments to ensure that players have challenges that are compelling, rewarding, and of course attainable via gameplay.

    We appreciate the candid feedback, and the passion the community has put forth around the current topics here on Reddit, our forums and across numerous social media outlets.

    Our team will continue to make changes and monitor community feedback and update everyone as soon and as often as we can.");
                await Context.Message.DeleteAsync();
            }

            if (message == "pingu")
            {
                await Context.Channel.SendMessageAsync(@" *Noot noot* - Pingu as he raises the flag over Reichstag, Battle of Berlin, 1945.

At long last, the wait is finally over.Quite possibly the most anticipated, highly praised, Academy Awards nominated piece presented by Polygon Pictures: Pingu In The City has finally come to its conclusion. There were tears, laughs, sighs of relieve, and joyous times all around the globe on March 31st, 2018.

Making its debut on Oct 7th 2017, fans, viewers, and even haters would rejoice for the Second Coming of animes.Some people were even skeptical about Pingu in a new environment; surrounded by the city lights, away from his igloo, making his debut into the big city. But boy, were they wrong. Once again, Pingu managed to captivate, charm, and woe us in this masterpiece of a show. Most of the people reading this review right now will think I'm simply just a troll, encouraging the word of our lord Pingu just to spread dead memes and lulz. Even the mods might delete this in due time. Rest assured though, I'm speaking sincerely from the bottom of my heart: I have never quite seen something so motivating, inspiring, heart-wrenching, and realistic modern anime in all my years of living.I will continue to spread the ways of Pinguism for as long as I live, no matter the costs.


This review, while may sounding biased(nothing wrong with that), will cover all the aspects of Pingu in the City. Sounds, artwork, story, and my overall enjoyment of the film - what I thought it did right, and what I thought it did right again. So without further ado, let's get to the main factors on why Pingu in the City has perfect tens across the board.

*We adults normally don't like work, we feel it's dull to work. But Pingu can change any dull work into a funny and interesting thing to do. So let's set Pingu the challenge to try out lots of different jobs.* - Naomi Iwata");
                await Context.Message.DeleteAsync();
            }
        }

    }
}
