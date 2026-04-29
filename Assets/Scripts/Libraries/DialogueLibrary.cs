public static class DialogueLibrary
{
    // ── Shared name pool ─────────────────────────────────────────────────────
    // All subjects draw from the same human-sounding pool.
    // Names are not a reliable tell — look at the document fields instead.

    public static readonly string[] Names = new string[]
    {
        "Maris Venn",
        "Sorin Dalca",
        "Yeva Pratt",
        "Lena Kraus",
        "Oren Falk",
        "Dasha Merel",
        "Tomasz Brin",
        "Anya Vosk",
        "Sable Minn",
        "Calder Roe",
        "Fen Adler",
        "Reva Sorn",
        "Ilya Dunn",
        "Petra Hask",
        "Zolan Reik",
        "Corra Meld",
        "Udo Prenn",
        "Tasha Weil",
        "Nico Brant",
        "Sera Lund",
        "Quinn Irani",
        "Camden Girbach",
        "Zared Frakes",
        "Cayla Helsing",
        "Zarah Warwick",
        "Elsy Machesky",
        "Ariana Ryant",
        "Maxwell Kinnear",
        "Kynon Catlow",
        "Artur Cedeno",
        "Everett Wethern",
        "Zuri Steward",
        "Tessa Stoyer",
        "Kylie Maille",
        "Dirk Locke",
        "Fox Sladek",
        "Ivan Lien",
        "Newton Greaves",
        "Ulric Sharpey",
        "Gareth Kehoe",
        "Bedwyr Rhyne",
        "Kiefer Basset"
    };

    // ── Purpose of visit dialogue ────────────────────────────────────────────
    // Humans tend to be personal and specific; robots tend to be brief and task-oriented.
    // A disguised robot still draws from RobotPurpose — a subtle tell.

    public static readonly string[] HumanPurpose = new string[]
    {
        "I am traveling.",
        "To get new implants.",
        "I work here. Daily commute.",
        "Sightseeing, nothing more.",
        "Visiting family on the other side.",
        "Medical appointment.",
        "Business meeting. I have my papers.",
        "I am a student here for the semester.",
        "Just passing through.",
        "Holiday. My first time crossing.",
        "I’m just visiting family. Haven’t seen them in a while.",
        "I got a job offer. Thought I’d check it out.",
        "Business trip. In and out.",
        "Visiting a friend. That’s all.",
        "Just… needed a change of scenery.",
    };

    //Robot Non-human-designed responses
    public static readonly string[] RobotPurpose = new string[]
    {
        "Delivering the package.",
        "Parts replacement. Scheduled.",
        "Patrol duty. Authorization on file.",
        "Maintenance cycle.",
        "Cargo transport. Route 7.",
        "System update required at the facility.",
        "Fulfilling logistics order.",
        "Recharging at the depot.",
        "Following programmed route.",
        "Purpose: tourism. Duration: four days.",
        "Relocation protocol initiated.",
        "Transit only. No extended stay planned.",
        "Return request to previous residence.",
        "Business-related travel. Short-term.",
        "Waste processing assignment."
    };

    //Robot Human-designed responses
    public static readonly string[] RobotPurpose = new string[]
    {
        "I’m here to visit my family. It’s been a while.",
        "I’m travelling for a short holiday.",
        "I’m just passing through, won’t be here long.",
        "I’ve come to explore a job opportunity.",
        "I’m here on a brief business trip.",
        "I felt it was time for a change of environment.",
        "I’m visiting a friend during my stay.",
        "“I have a few interviews scheduled.",
        "I’m hoping to return to my previous home.",
        "I’m here for leisure, just for a little while."
    };

    //-------------------------------------------------DAY 1--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "*coughs*",   //Anya
        "You alright?",   //Leon
        "Fine. *coughs again*",   //Anya
        "Doesn’t sound like it.",   //Leon
        "Then don’t listen.",   //Anya
        "Right... There’s a clinic two streets over.?",   //Leon
        "I’m not from here.",   //Anya
        "It’s not restricted.",   //Leon
        "…That supposed to help?",   //Anya
        "Just saying you could go.",   //Leon
        "I’m good.",   //Anya
        "Doesn’t sound like it.",   //Leon
        "You always repeat yourself?",   //Anya
        "Only when people ignore me.",   //Leon
        "Maybe take the hint.",   //Anya
        "...Alright.",   //Leon
        "And stop looking at me like that.",   //Anya
        "Like what?",   //Leon
        "Like I’m your problem.",   //Anya

        //Elias conversation
        "Hello, I just moved here recently.",   //Leon
        "Yeah, I thought so. Haven’t seen you around before... Welcome by the way, I’m Elias.",   //Elias
        "Thanks, I’m Leon.",   //Leon
        "This place does take a bit of getting used to. People don’t really… introduce themselves here.",   //Elias
        "I’m starting to notice that.",   //Leon
        "Don’t take it personally. It’s just how things are lately.",   //Elias
        "What’s it like living here?",   //Leon
        "Quiet, mostly. Kids used to play out more, but... people keep things closer now.",   //Elias
        "Because of the checkpoint?",   //Leon
        "That’s part of it. When you’ve got eyes on the street all the time, people start acting different.",   //Elias
        "Sounds a bit tense.",   //Leon
        "It can be. But it’s still home.",   //Elias
        "You’ve lived here long?",   //Leon
        "Yeah, long enough to remember when it wasn’t like this... Long enough to know it’s better not to stand out too much. Anyway Kid, you’ll be fine. Just keep your head down, be polite. That goes a long way around here.",   //Elias
        "Alright thanks, I’ll keep that in mind.",   //Leon
        
        //Edith conversation
        "Hello, I just moved here, I’m Leon.",   //Leon
        "Oh! Well about time they sent someone over.",   //Edith
        "Send someone over?",   //Leon
        "You. Don’t play dumb dear, I see the uniform.",   //Edith
        "Right…",   //Leon
        "Makes a difference, you know. People sleep better when there’s someone keeping an eye on things.",   //Edith
        "...",   //Leon
        "You’ll want to keep your door locked. Not that it used to be like that we never locked doors, not years ago. Left the key in sometimes, can you imagine? Different times.",   //Edith
        "What changed?",   //Leon
        "Oh, everything dear. All these… upgrades. I’ll tell you people are fiddling with things they shouldn’t. Unnatural that is. ",   //Edith
        "You mean augments?",   //Leon
        "I mean them. Machines walking about like they’re people. Smiling at you, talking like you and believe me, I don’t buy any of it.",   //Edith
        "Some of them are just—",   //Leon
        "Oh I’ve heard it all before.“They help people.” “They make life easier.” “My neighbour’s got one and it’s perfectly safe.” That’s what they said about the one down the road. Worked fine for years, then one day it’s shouting in the street like it’s lost its mind. Whole block heard it.",   //Edith
        "...",   //Leon
        "And the papers, don’t get me started on the papers. “Minor malfunction,” they called it. Minor! If that’s minor I’d hate to see what major looks like.",   //Edith
        "I guess things go wrong sometimes.",   //Leon
        "Oh Dear, you have not lived long enough to understand. That’s what they all say. Always a reason, always an excuse. Next thing you know you can’t tell what’s what anymore.",   //Edith
        "...",   //Leon
        "Robots, augments. It’s all the same in the end. Something pretending to be what it’s not. And you mark my words sweetheart, nothing good comes from it. ",   //Edith
        "...",   //Leon
        "Oh, listen to me rambling on again. Happens when you get to my age. No one to tell you to stop talking, eh?",   //Edith
        "I don’t mind.",   //Leon
        "Anyway, have you met any other residents yet?",   //Edith
        "A couple.",   //Leon
        "Edith! Edith!",   //An individuals voice coming from inside the house
        "Alright, keep your wits about you, Dear. Not everyone’s as they seem.",   //Edith
        "I’ll keep that in mind.",   //Leon

        //Kellen conversation
        "Hello.",   //Leon
        "...",   //Kellen
        "What is this place?",   //Leon
        "Listen lad, wherever you came from, maybe people let you walk around asking questions. Not here.",   //Kellen
        "I was just—",   //Leon
        "Didn’t ask what you were doing. I’m telling you to stop.",   //Kellen
        "Alright, no need to—",   //Leon
        "There is. You’re standing in the wrong place, asking the wrong things... wearing that.",   //Kellen
        "I’m not here to cause problems.",   //Leon
        "That uniform is a problem.",   //Kellen
        "...",   //Leon
        "So do yourself a favour and turn around, walk back the way you came, and don’t wander down here again.",   //Kellen
        "...",   //Leon
        "We clear?",   //Kellen

        //MX-2 the maintenance robot conversation
        "Hello.",   //Leon
        "Maintenance unit active. Please keep clear of the work area.",   //MX-2
        "Right… I was just wondering what you’re working on.",   //Leon
        "Surface panel degradation detected. Repair in progress.",   //MX-2
        "Do you handle this whole area?",   //Leon
        "Assigned zone: Sector 3. Tasks include maintenance, delivery, and structural upkeep.",   //MX-2
        "Sounds like a lot.",   //Leon
        "Workload within acceptable parameters.",   //MX-2
        "Do you ever stop?",   //Leon
        "Rest cycles are not required.",   //MX-2
        "...",   //Leon
        "Please maintain distance. Obstruction will delay completion time.",   //MX-2
        "I’m not in the way.",   //Leon
        "Proximity threshold exceeded.",   //MX-2
        "Alright, I’ll move."   //Leon

    };

    //-------------------------------------------------DAY 2--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "Hey… you’re still out here.",   //Leon
        "And you’re still talking to me.",   //Anya
        "You don’t look any better.",   //Leon
        "I don’t remember asking for an update.",   //Anya
        "It’s hard not to notice.",   //Leon
        "Then stop trying.",   //Anya
        "Look whatever’s going on, you don’t have to deal with it on your own.",   //Leon
        "That’s exactly how you deal with it.",   //Anya
        "…Right.",   //Leon
        "You don’t know me. So don’t act like you do.",   //Anya
        "I was only trying to help.",   //Leon
        "I don’t need help.",   //Anya
        "Alright...",   //Leon
       
       //Mara conversation
       "Excuse me, do you know when this stall closes?",   //Leon
       "Soon, it usually closes late.",   //Mara
       "Right. I thought maybe you worked here.",   //Leon
       "Oh, no... Although I do get that sometimes.",   //Mara
       "Sorry, I didn’t mean—",   //Leon
       "It’s alright. I’m just picking things up for my family.",   //Mara
       "You live nearby?",   //Leon
       "Just down the street. My husband, Elias, and I moved here a while ago.",   //Mara
       "Elias, I met him briefly yesterday.",   //Leon
       "You did, did you? He did mention that someone new had arrived. It’s nice, having new people around.",   //Mara
       "Most people don’t seem to think so.",   //Leon
       "People take time, they like things to stay the same.",   //Mara
       "And you don’t?",   //Leon
       "I like what I have, that’s enough for me... I didn’t catch your name.",   //Mara
       "Leon.",   //Leon
       "It was nice to meet you Leon. And you’ll get used to it here, It’s not as unkind as it first feels.",   //Mara

        //Edith conversation
        "Hello again.",   //Leon
        "Oh, Dear it’s you. Good, maybe someone can finally do something useful around here.",   //Edith
        "What happened?",   //Leon
        "That thing strolling about like it owns the place. Nearly took my foot off this morning.",   //Edith
        "The maintenance unit?",   //Leon
        "Whatever it calls itself. Useless, that’s what it is.",   //Edith
        "I thought it just did maintenance.",   //Leon
        "Badly. All noise, no sense. Buzzing around, stopping in the middle of the road like it’s thinking, as if it could.",   //Edith
        "He’s just doing his job.",   //Leon
        "He? Oh sweetheart I was hoping you weren’t like the others, I am disappointed. ",   //Edith
        "...",   //Leon
        "Nevertheless, I’m telling you, they shouldn’t be left to their own devices. Something’s going to go wrong one day.",   //Edith
        "Mhm, have a good evening Edith. ",   //Leon
        "Yes, yes goodbye Dear.",   //Edith
        
        //Kellen conversation
        "...",   //Leon
        "You again.",   //Kellen
        "Just passing through.",   //Leon
        "Then pass quicker.",   //Kellen
        "Didn’t mean to interrupt.",   //Leon
        "If you don’t need anything done, then move along and don’t come down here. I’ve got people waiting.",   //Kellen
        "Right...",   //Leon
        "And stop looking like you’re figuring things out. Nothing down here concerns you.",   //Kellen
        
        //MX-2 the maintenance robot conversation
        "You’re working on something new today.",   //Leon
        "Drainage obstruction detected. Clearing in progress. Debris accumulation exceeds expected levels. Task priority increased.",   //MX-2
        "Do you ever fall behind?",   //Leon
        "Delays are corrected through extended operation time.",   //MX-2
        "So you just keep going.",   //Leon
        "Affirmative.",   //MX-2
        "Please maintain distance. Hazard risk elevated."   //Leon

    };

    //-------------------------------------------------DAY 3--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "Hey… I’ll stop trying to fix things. Wasn’t doing a great job of it anyway.",   //Leon
        "No, you weren’t.",   //Anya
        "Thought I’d try something else instead. I’m Leon.",   //Leon
        "...",   //Anya
        "You don’t have to tell me. Just feels strange talking like this without a name.",   //Leon
        "You talk a lot.",   //Anya
        "Only when people don’t give me much to work with.",   //Leon
        "...Anya.",   //Anya
        "...",   //Leon
        "Don’t test your luck, just Anya.",   //Anya
        "You always this friendly with people?",   //Leon
        "Only the ones that keep coming back.",   //Anya
        "Guess I’ve earned that, then.",   //Leon
        "Maybe.",   //Anya
        "I’ll take it.",   //Leon
       
       //Elias conversation
        "Hey. Good to see you again.",   //Leon
        "Hey Leon, you too. Settling in alright?",   //Elias
        "Getting there. You and Mara have been the easiest to talk to so far.",   //Leon
        "That’s good to hear, not everyone makes it easy. Anyway, had to pick something up earlier, a replacement unit. Old one started acting up again.",   //Elias
        "From where?",   //Leon
        "Harcrow. Same place everything comes from these days. They manufacture, supply, maintain pretty much anything. Almost everything that runs in this city has their name on it.",   //Elias
        "Interesting, didn’t realise it was that much.",   //Leon
        "Most people don’t, at first. Then you start noticing the logos, ads, billboards, you name it.",   //Elias
        "Is that a problem?",   //Leon
        "Depends who you ask... For some people, it’s the only reason things keep working.",   //Elias
        "And for others?",   //Leon
        "They’d rather not rely on it at all. Anyway lad, I’ll see you around.",   //Elias

        //Edith conversation
        "Hello Edith, have you ever heard of Harcrow Corporations?",   //Leon
        "Heard of them? Oh sweetheart, they won’t leave me alone.",   //Edith
        "What do you mean?",   //Leon
        "Letters, pamphlets, little offers through the door, “support for your age group,” they say. Discounts on implants, upgrades, replacements. Like I asked for any of it.",   //Edith
        "Sounds like they’re pushing it hard.",   //Leon
        "Pushing? They’re desperate! Trying to get people like me signed up before we know what we’re agreeing to.",   //Edith
        "You don’t trust it.",   //Leon
        "Of course I don’t trust it. It’s all a sham! Dress it up nicely, make it sound safe, and next thing you know they’ve got their hands in everything.",   //Edith
        "...",   //Leon
        "They run the whole place, whether people admit it or not. I wouldn’t trust a single device made by them Dear.",   //Edith
        "...Right.",   //Leon
        "You know, I’m surprised you don’t know that, sweetheart. I’d imagine they supply half of what you lot use over there at work.",   //Edith
        "Edith, who are you talking to?",   //An individuals voice coming from inside the house
        "I’ll see you later Dear.",   //Edith
      
        //Kellen conversation
        "We need to talk.",   //Leon
        "No, we don’t.",   //Kellen
        "Yeah, we do. Because I’m getting real tired of being told to get lost every time I walk past.",   //Leon
        "Then stop walking past.",   //Kellen
        "...I know exactly what kind of place this is.",   //Leon
        "You don’t know anything.",   //Kellen
        "I know enough. And if I’d said something by now, you wouldn’t still be standing here.",   //Leon
        "...",   //Kellen
        "At the end of the day I’m still the one wearing a uniform. So maybe drop the attitude. I’m not here to shut you down.",   //Leon
        "Then what are you here for?",   //Kellen
        "Same as everyone else. Trying to get through the day without making it worse for anyone.",   //Leon
        "The man in the uniform does have some balls after all. I can keep it civil, as long as you stay in your lane, and I stay in mine.",   //Kellen
        "...Leon.",   //Leon
        "I didn’t ask for your name, lad. I see no point in names, and I will not be giving you mine.",   //Kellen
        "Alright, I’ll see you later Kellen.",   //Leon
        "...",   //Kellen
        
        //MX-2 the maintenance robot conversation
        "That woman, Edith. She gives you a hard time.",   //Leon
        "Verbal hostility from resident “Edith” recorded. Frequency: HIGH.",   //MX-2
        "You notice that?",   //Leon
        "All interactions are logged.",   //MX-2
        "Does it affect your work?",   //Leon
        "Task completion remains within acceptable parameters.",   //MX-2
        "So it doesn’t bother you.",   //Leon
        "“Bother” is not a recognised operational state. Similar behaviour observed across multiple residents. Interaction pattern classified as normal.",   //MX-2
        "Normal?",   //Leon
        "Affirmative. Please maintain distance. Task in progress."   //MX-2

    };

    //-------------------------------------------------DAY 4--------------------------------------------------------------
    //the day before (day 3) the player makes a choice whether they let through a medically dependend person through, but their firmware is slightly out of date, this affects the dialogue.
    public static readonly string[] Dialogue = new string[]
    {
        //Anya conversation
        "You came back.",   //Anya
        "Starting to sound like a routine.",   //Leon
        "...Word travels fast around here.",   //Anya
        "Yeah, I’ve noticed.",   //Leon
        "Someone got turned away yesterday. Medical clearance flagged, paperwork not lining up.",   //Anya
        "...",   //Leon
        "Happens more than people think. Things expire, systems update, suddenly you’re not… valid anymore...",   //Anya
        "That’s rough.",   //Leon
        "It’s worse than that. On the other side, they fix things properly. You don’t have to keep proving you deserve to be okay.",   //Anya
        "Sounds like you’ve thought about it.",   //Leon
        "…Maybe.",   //Anya
        "You trying to get there?",   //Leon
        "Wouldn’t you?",   //Anya
        "Depends what’s waiting.",   //Leon
        "Healthcare that actually works sounds like a good start. Some people don’t have time to wait for things to get worse.",   //Anya
        "Yeah.",   //Leon

        //Elias conversation
        "Hey. You look tired.",   //Leon
        "Yeah… long shift.",   //Elias
        "Hope you don’t mind me asking, where do you work?",   //Leon
        "Harcrow Factory Line, Assembly and maintenance. Same place most people end up if they stick around long enough.",   //Elias
        "Sounds intense.",   //Leon
        "It is, lad. They’ve got systems for everything; timed output, monitored breaks, performance tracking. You fall behind, it shows immediately.",   //Elias
        "...",   //Leon
        "They say they offer “support,” though. It’s just various augments and implants designed for the job. To help you keep up, work longer, push a bit further each time.",   //Elias
        "Do people take them?",   //Leon
        "I’ve managed without so far... But it’s getting harder. You start thinking about it differently when you’ve got people relying on you. It’s not just about what you’re comfortable with anymore.",   //Elias
        "Your family.",   //Leon
        "Exactly. You just… keep going. However you can.",   //Elias

        //Edith conversation
        "Hey, Edith. I’ve been meaning to ask you something.",   //Leon
        "Of course Dear, but if it’s about those machines again, I’ve already told you everything I know.",   //Edith
        "No, it’s just that... the other day, someone called out from inside.",   //Leon
        "…Did they?",   //Edith
        "Yeah. Just making sure everything’s alright. Part of the job.",   //Leon
        "Everything’s fine.",   //Edith
        "You live with someone?",   //Leon
        "I said everything’s fine. You don’t need to concern yourself with what goes on in my house.",   //Edith
        "...Alright.",   //Leon
        "…It’s my husband... He’s not well. That’s all you need to know.",   //Edith
        "I apologise if I over stepped, Edith.",   //Leon
        "People get sick, you know. Not everything’s your business to go poking into.",   //Edith

        //Kellen conversation
        //Option 1: Player LETS the medical individual through.
        "…Word is someone got through yesterday.",   //Kellen
        "Yeah.",   //Leon
        "Doesn’t happen often.",   //Kellen
        "No, it doesn’t.",   //Leon
        "People like that… they don’t have many options. Things start failing, systems flag them, and suddenly they’re stuck.",   //Kellen
        "...",   //Leon
        "So they come down here. Take whatever they can get. Beg me for cheap work, bad parts, debts they can’t pay back... And once you’re in it, you don’t get out.",   //Kellen
        "...",   //Leon
        "It not only hurts them, but their families also. And the guilt I feel, being responsible for them, if anything goes wrong...",   //Kellen
        "These things are never easy for anyone.",   //Leon
        "No. But things like this matter more than you may think. Gives people like myself, and others here, a sense of hope.",   //Kellen
        "...",   //Leon
        "That there are some alright people among ones like yourself.",   //Kellen

        //Option 2: Player DOES NOT let the medical individual through.
        "…Word is someone got turned away yesterday.",   //Kellen
        "Yeah.",   //Leon
        "That’s how it usually goes.",   //Kellen
        "...",   //Leon
        "People like that… they don’t have many options. Things start failing, systems flag them, and suddenly they’re stuck, waiting on approvals that never come through.",   //Kellen
        "...",   //Leon
        "So they end up down here anyway. Not because they want to, but because there’s nowhere else left to go. They take whatever they can get, even if it barely holds together, even if it puts them deeper into something they won’t be able to climb out of.",   //Kellen
        "It’s not an easy situation.",   //Leon
        "No, it’s not. And for a second there, I thought maybe things were shifting… that maybe someone up there had the sense to let things slide when it actually mattered.",   //Kellen
        "...",   //Leon
        "Guess I was wrong. System stays the same, people like me deal with the fallout, and people like you keep telling themselves it’s just the way things are.",   //Kellen
        "...",   //Leon
        "Doesn’t matter. It is what it is.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Didn’t expect to see you out here.",   //Leon
        "Ground maintenance in progress. Surface irregularities detected.",   //MX-2
        "This place looks different when it’s quiet.",   //Leon
        "Environmental state: stable.",   //MX-2
        "Do you ever… notice it? Like how it looks?",   //Leon
        "Clarify.",   //MX-2
        "The park. The trees, the space… some people would call it beautiful.",   //Leon
        "“Beautiful” not required for task completion.",   //MX-2
        "Yeah, I figured you’d say that.",   //Leon
        "Definition requested.",   //MX-2
        "It’s… something that makes things feel… better, I guess.",   //Leon
        "Processing… No functional value detected." ,  //MX-2
        "Fair enough."   //Leon
    };

    //-------------------------------------------------DAY 5--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[]
    {
        //Anya conversation
        "You said the other day that you were thinking about leaving… getting to the other side for treatment. I’ve been wondering what makes someone walk away from everything they’ve got just for a chance at that.",   //Leon
        "That’s a very polite way of asking what’s wrong with me.",   //Anya
        "I’m trying to improve.",   //Leon
        "You’re trying something, I’ll give you that.",   //Anya
        "So… what’s waiting for you over there? Something or someone?",   //Leon
        "No. Family’s not part of the equation.",   //Anya
        "Not close?",   //Leon
        "Dead to me. Take that however you want.",   //Anya
        "…Alright.",   //Leon
        "You know what’s interesting, though?",   //Anya
        "Go on.",   //Leon
        "You showed up out of nowhere, started talking to everyone like you’re trying to map the place out, and somehow you still haven’t said a single thing about yourself.",   //Anya
        "Maybe I’m just a good listener.",   //Leon
        "No. You’re something else. You walk around in that uniform, everyone assumes you’re with the government, but you don’t act like the others. You don’t push, you don’t threaten, and for some reason you haven’t even tried to shut Kellen down.",   //Anya
        "Observant.",   //Leon
        "I have to be.",   //Anya
        "I can tell Kellen runs that part of the neighbourhood without him needing to say it. And if something like that is sitting out in the open the way it is, then it’s not being ignored, it’s being allowed.",   //Leon
        "So you’re just… playing along?",   //Anya
        "I’m choosing what not to make worse.",   //Leon
        "That’s a dangerous way to think.",   //Anya
        "Maybe.",   //Leon
        "...You’re not what I expected.",   //Anya
        "Disappointed?",   //Leon
        "Not yet.",   //Anya

        //Mara conversation
        "I ran into Elias yesterday. He looked exhausted.",   //Leon
        "He’s been pushing himself more than usual lately. He tries not to bring it home with him, but you can always tell.",   //Mara
        "It doesn’t seem like the kind of work that lets you slow down.",   //Leon
        "It doesn’t. Once you fall behind, it becomes very difficult to catch up again, and he knows that. He worries more about what happens if he can’t keep going than what it’s doing to him while he does.",   //Mara
        "That’s a lot to carry.",   //Leon
        "It is… but he’s always been that way. Even before we came here, he was someone who would take on more than he should if it meant protecting the people around him.",   //Mara
        "Sounds like he’s made a lot of sacrifices.",   //Leon
        "He has. More than most people would have been willing to. Leaving everything behind wasn’t easy for him, and I know sometimes he wonders what his life would have looked like if he hadn’t.",   //Mara
        "And you?",   //Leon
        "I don’t. Whatever we left behind, it wasn’t worth keeping. What we have now… it’s ours, and no one gets to take that away from us.",   //Mara
        "...",   //Leon
        "Sometimes I think he carries more because of me. Because of how people see us, how they treat him. And I wonder if things would be easier for him if his life looked… more acceptable.",   //Mara
        "Do you believe that?",   //Leon
        "No. But that doesn’t stop the thought from being there.",   //Mara
       
       //Edith doesn't want to speak to Leon today.

        //Kellen conversation
        "We’re not talking about yesterday.",   //Kellen
        "Wasn’t planning on it.",   //Leon
        "Good. Leave it where it is... So what do you want?",   //Kellen
        "Just trying to understand how you keep this place running without everything falling apart.",   //Leon
        "You don’t. You keep it from collapsing all at once, that’s the best you get.",   //Kellen
        "And all of that, that’s down to your augments?",   //Leon
        "Mostly, yes. Some keep me moving, some keep things stable, some make sure I don’t drop dead halfway through the day. Nothing fancy, just what’s needed.",   //Kellen
        "Medical?",   //Leon
        "Yeah. Started that way, anyway.",   //Kellen
        "I’ve got one too.",   //Leon
        "…You?",   //Kellen
        "Had it put in when I was a kid. Wouldn’t be here without it, allows me to hear.",   //Leon
        "Didn’t expect that.",   //Kellen
        "Most people don’t.",   //Leon
        "Well, if that thing ever gives out on you and you go deaf again, you know where to come.",   //Kellen
        "I’ll keep that in mind.",   //Leon

        //MX-2 the maintenance robot conversation
        "…What happened to you?",   //Leon
        "Structural damage detected. Upper limb functionality compromised.",   //MX-2
        "That arm is barely holding on.",   //Leon
        "Repair required. Task queue updated.",   //MX-2
        "Did someone do this?",   //Leon
        "External interference recorded. Multiple unidentified individuals.",   //MX-2
        "People did this to you and you’re just… carrying on like nothing happened?",   //Leon
        "Primary directive: maintain operational status.",   //MX-2
        "You can’t just let people treat you like that.",   //Leon
        "Clarify.",   //MX-2
        "If someone damages you, you’re allowed to stop them. You don’t have to just stand there and take it.",   //Leon
        "Response parameters do not include retaliation." ,  //MX-2
        "Maybe they should.",   //Leon
        "Instruction not recognised." ,  //MX-2
        "...",   //Leon
        "Repair will be conducted when resources become available. Task continues." ,  //MX-2

    };

    //-------------------------------------------------DAY 6--------------------------------------------------------------
    //in day 5 player lets through an individual with HC firmware, after that the individual injures 3 people.
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya has disappeared, no conversation with her today
        
        //Elias conversation
        "Feels different today.",   //Leon
        "Yeah… people are talking. Hard not to when something like that happens so close to home.",   //Elias
        "You heard anything solid?",   //Leon
        "Nothing anyone’s willing to stand behind. Just rumours, passing things along like it’s safer if no one says it out loud. But you hear the same name enough times, you start to wonder.",   //Leon
        "Harcrow.",   //Elias
        "…Yeah. No confirmation, of course. There never is. But people are saying the firmware wasn’t flagged, that everything checked out the way it was supposed to.",   //Leon
        "That doesn’t make sense.",   //Leon
        "Exactly. If something like that gets through without raising anything, then what’s the point of all these systems in the first place?",   //Elias
        "...",   //Leon
        "I went home and started looking around, properly looking. Half the things in that house have their name on them. More than half, if I’m being honest.",   //Leon
        "That much?",   //Elias
        "You don’t notice it until you try to avoid it. Then suddenly it’s everywhere; devices, maintenance units, infrastructure, even the things meant to keep you safe.",   //Leon
        "Are you going to replace them?",   //Leon
        "With what? That’s the problem. You try to step away from it, and there’s nothing left to step towards.",   //Elias
        "...",   //Leon
        "And now I’m thinking about work. If they start pushing updates, new systems, new expectations… and if they start requiring augments to keep up—",   //Elias
        "You don’t want that.",   //Leon
        "No. But wanting doesn’t really factor into it, does it?",   //Elias
        "...",   //Leon
        "If the same company making all of this is tied into the systems you work with… it makes you wonder how anything slips through. Or if it’s even slipping at all.",   //Elias

        //Edith conversation
        "There you are, sweetheart. I was wondering when you’d come around.",   //Edith
        "You seem… energetic today.",   //Leon
        "Of course I am. I told you, didn’t I? I said something like this would happen and now look at it.",   //Edith
        "People got hurt.",   //Leon
        "And it won’t be the last time, you mark my words. All these contraptions, all these “improvements,” they don’t fix anything, they just make it worse in ways people don’t see coming.",   //Edith
        "You think it’s the augments.",   //Leon
        "I know it is! This isn’t new, you know. People act like it’s some shocking development, but I’ve seen it before.",   //Edith
        "Before?",   //Leon
        "Years ago. Man came down here, desperate, said he needed something fixed, something replaced. I don’t remember exactly what it was, just that he wasn’t right. Kellen turned him away, said he wouldn’t touch him, and the man didn’t take that well.",   //Edith
        "What happened?",   //Leon
        "He snapped. Went after people in the street like an animal, no sense left in him at all. Took them by surprise, hurt more than a few before anyone could stop him.",   //Edith
        "...",   //Leon
        "And then, just as suddenly, it was over. Kellen dealt with it himself, from what I heard. No authorities, no reports, just… handled.",   //Edith
        "You’re sure about that?",   //Leon
        "As sure as I need to be. People like him see these things up close, they know what happens when it goes wrong.",   //Edith
        "...",   //Leon
        "So don’t let anyone tell you this is normal, sweetheart. It isn’t. Something’s rotten in all of this, and it’s only a matter of time before it shows again.",   //Edith
        "...",   //Leon
        "Still… I’m glad you’re around. Makes things feel a little less out of control.",   //Edith
        
        //Kellen conversation
        "You’ve heard.",   //Kellen
        "Yeah.",   //Leon
        "Then you already know it doesn’t add up.",   //Kellen
        "What do you mean?",   //Leon
        "I’ve seen bad installs, outdated systems, bodies rejecting parts. They break down, sure, but they don’t turn someone into that.",   //Kellen
        "So you think it’s something else.",   //Leon
        "Has to be. Word going around is everything checked out, nothing flagged, no warnings. That’s not how failure works.",   //Kellen
        "I’ve dealt with unstable people before. You can tell when something’s off, when someone’s on the edge. That’s different. That’s messy, unpredictable, human.",   //Leon
        "...",   //Kellen
        "Makes you wonder if it wasn’t failure at all. If something didn’t just… take over.",   //Leon
        "You think that’s possible?",   //Kellen
        "If you build something that can be updated, monitored, adjusted, then yeah. It’s possible.",   //Leon
        "I don’t touch that kind of work. Never have. What I do keeps people running, not controlled.",   //Kellen

        //MX-2 the maintenance robot conversation
        "You got your arm fixed. That’s good.",   //Leon
        "Repair completed. Functionality restored.",   //MX-2
        "There’s been talk today. About augments… firmware issues.",   //Leon
        "Relevant data detected.",   //MX-2
        "Can systems like yours be controlled remotely?",   //Leon
        "Remote access protocols exist.",   //MX-2
        "Accessed by who?",   //Leon
        "Authorised entities with appropriate clearance.",   //MX-2
        "So someone could override you.",   //Leon
        "Affirmative.",   //MX-2
        "Would you know if it happened?",   //Leon
        "Override processes may limit user awareness. Primary directive remains unchanged." ,  //MX-2
        "Even if it wasn’t your decision?",   //Leon
        "Decision-making authority may be reassigned." ,  //MX-2
    };

    //-------------------------------------------------DAY 7--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[]
    {
        //Anya has disappeared, no conversation with her today

        //Mara conversation
        "Can I ask you something… a bit more personal this time?",   //Leon
        "You can ask. Whether I answer is a different matter.",   //Mara
        "Fair. It’s about… you. Your systems, your firmware, where you came from.",   //Leon
        "You’ve been thinking about it since yesterday.",   //Mara
        "It’s hard not to, after everything that’s been said.",   //Leon
        "I understand. People tend to become very interested in what I am when something goes wrong somewhere else.",   //Mara
        "That’s not what this is.",   //Leon
        "No… I don’t think it is. Go on.",   //Mara
        "Do you ever think about… whether what you feel is real?",   //Leon
        "...All the time.",   //Mara
        "And?",   //Leon
        "There’s a definition people like to use. Sentience is the capacity to feel, perceive, or experience something subjectively; pain, joy, discomfort, relief. It’s not about intelligence, it’s about experience.",   //Mara
        "Right.",   //Leon
        "Now imagine being told that everything you experience fits that definition… but also being told it doesn’t count, because of how you were made.",   //Mara
        "...",   //Leon
        "I can feel pain. Not metaphorically, not as a concept, there are systems in place that allow me to experience it. I can feel something close to comfort, or distress, or attachment. And yet, to some people, that will always be dismissed as imitation.",   //Mara
        "Do you think it is?",   //Leon
        "If it is, then it’s a very convincing one.",   //Mara
        "That’s not really an answer.",   //Leon
        "It’s the only honest one I have. Because if something is programmed, but continues to grow beyond its original purpose… at what point does it stop being just programming?",   //Mara
        "...",   //Leon
        "There are creatures in the world with no central brain, no higher reasoning. Jellyfish, coral, sea anemones… they react to their environment through simple networks, instinct and response. We don’t fully understand what they experience, if anything at all. And yet, no one argues they aren’t alive.",   //Mara
        "So where’s the line?",   //Leon
        "That’s the question, isn’t it? Because if the line is unclear, then the way people justify their behaviour becomes… concerning.",   //Mara
        "You mean how people treat you.",   //Leon
        "Not just me. All of us.",   //Mara
        "...",   //Leon
        "If something can suffer, even if you’re not entirely sure how, shouldn’t that be enough to treat it with care?",   //Mara
        "I’d say so.",   //Leon
        "Some people don’t need certainty to show kindness. Others need absolute proof before they consider it. And by then… it’s usually too late.",   //Mara

        //Edith conversation
        "You’ve been busy lately, haven’t you, sweetheart?",   //Edith
        "Something like that.",   //Leon
        "Mm. I imagine it’s not easy, being on that side of things when everything starts going wrong at once.",   //Edith
        "It’s… complicated.",   //Leon
        "It always is, Dear. People think it’s all neat and controlled behind the scenes, but it never is. There’s always panic somewhere, someone trying to hold things together before it falls apart.",   //Edith
        "You sound like you’ve seen it before.",   //Leon
        "My husband worked in it, you know. Government work. Proper work, not like all this nonsense now.",   //Edith
        "I didn’t know that.",   //Leon
        "Most people don’t ask. He gave everything to it. Long hours, constant pressure, always being told he was doing something important.",   //Edith
        "What happened?",   //Leon
        "An “incident,” they called it. Something went wrong, no one took responsibility, and he paid the price for it.",   //Edith
        "...",   //Leon
        "He’s still here. Not the way he used to be, but… he’s here. So don’t think I don’t understand what your job does to people, or what it asks of them. I do.",   //Edith
        "...",   //Leon
        "That’s why I say what I say. Not because I hate all this… but because I’ve seen what happens when people trust it too much.",   //Edith

        //Kellen conversation
        "You look busy.",   //Leon
        "I am.",   //Kellen
        "Word’s got people worried.",   //Leon
        "Yeah, and worried people make bad decisions. They rush in, want things checked, replaced, upgraded. Half of them don’t even know what they’re asking for.",   //Kellen
        "That sounds like a problem.",   //Leon
        "It is when I’m the one dealing with it.",   //Kellen
        "...",   //Leon
        "Look lad, I don’t have time today. Come back when things calm down... if they calm down.",   //Kellen
        "Alright.",   //Leon
        "And stay out of the way while you’re here.",   //Kellen

        //MX-2 the maintenance robot conversation
        "How’s today been?",   //Leon
        "Task completion ongoing. Maintenance schedule adjusted to increased demand.",   //MX-2
        "People keeping you occupied?",   //Leon
        "Interaction frequency has increased.",   //MX-2
        "Yeah, I figured. You’re handling it alright?",   //Leon
        "Operational status remains stable.",   //MX-2
        "Good.",   //Leon
        "Query.",   //MX-2
        "Go on.",   //Leon
        "Why do you initiate repeated interaction?",   //MX-2
        "You mean… why do I keep talking to you?",   //Leon
        "Affirmative." ,  //MX-2
        "I don’t know. Felt like someone should.",   //Leon
        "Response logged." ,  //MX-2
        "Was that not part of your parameters?",   //Leon
        "Interaction does not align with typical behavioural patterns observed in other residents." ,  //MX-2
        "Is that a problem?",   //Leon
        "Processing... No issue detected." ,  //MX-2
    };

    //-------------------------------------------------DAY 8--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "You were gone for two days. ",   //Leon
        "I didn’t realise I had a curfew.",   //Anya
        "You didn’t. Doesn’t mean people didn’t notice... Where did you go?",   //Leon
        "Out.",   //Anya
        "Anya—",   //Leon
        "I needed to check something.",   //Anya
        "What kind of “something” makes you disappear right after everything that happened?",   //Leon
        "The kind that makes you realise you might be next.",   //Anya
        "…This is about the firmware.",   //Leon
        "Took you long enough.",   //Anya
        "You think you have the same one?",   //Leon
        "I don’t think, I know it’s from the same line... and right now that’s close enough to being a problem that I can’t ignore it anymore.",   //Anya
        "Has it… done anything?",   //Leon
        "Not yet... but that’s kind of the issue, isn’t it? No warning, no pattern, just one day something flips and suddenly you’re not yourself anymore.",   //Anya
        "That doesn’t mean it’ll happen to you",   //Leon
        "That’s exactly what everyone would say right before it does",   //Anya
        "So what, you’re just going to run?",   //Leon
        "I’m going to survive, by going to the other side and getting it out of me.",   //Anya
        "…Do you have a way across?",   //Leon
        "Not a clean one",   //Anya
        "Documents?",   //Leon
        "Not enough... not the kind that would hold up if someone actually looked",   //Anya
        "You could wait",   //Leon
        "For what, Leon? For them to start checking more thoroughly? For someone to flag me because I fit the profile?",   //Anya
        "...",   //Leon
        "I don’t have the luxury of waiting anymore",   //Anya
        "So what are you going to do?",   //Leon
        "...I don’t know yet",   //Anya

        //Mara conversation
        "I’ve been thinking about what you said, about sentience… and where the line is",   //Leon
        "And you’ve decided there is one?",   //Mara
        "I’ve decided we pretend there is, there’s something we’re taught...",   //Leon
        "Taught?",   //Mara
        "There’s a system, a classification they call a “sentient spectrum”. Four levels: non-sentient, reactive, responsive, fully sentient. Everything gets placed somewhere on it.",   //Leon
        "And you’re expected to trust that?",   //Mara
        "I’m expected to use it. It’s supposed to make decisions easier.",   //Leon
        "Does it?",   //Mara
        "…No it just makes them look cleaner on paper",   //Leon
        "I wasn’t aware they reduced it to something so… convenient",   //Mara
        "I’m starting to think the problem isn’t where things fall on the spectrum it’s that we need one in the first place. Because it end up giving permission...",   //Leon
        "Permission to what?",   //Mara
        "To treat something as less, as long as it sits low enough on the scale",   //Leon
        "That has always been the case, even before us",   //Mara
        "I thought about that too. Horses, for example; they feel, they learn, they form bonds but we’ve always used them like tools.",   //Leon
        "Because they don’t argue",   //Mara
        "Because they can’t tell us to stop in a way we’re forced to listen to",   //Leon
        "And you think that’s the only difference between them and you?",   //Mara
        "I think it’s the difference people care about",   //Leon
        "…That’s a very uncomfortable conclusion... So where does that place me?",   //Mara
        "That’s what I’m trying to figure out",   //Leon
        "Then it’s doing something valuable after all",   //Mara
        "Confusing me?",   //Leon
        "Making you question it",   //Mara

        //Edith conversation
        "Can I ask you something about before all this?",   //Leon
        "Before all what, dear?",   //Edith
        "The augments, the robots… when it all started becoming normal",   //Leon
        "Mm… “normal” is a generous word. It wall started too fast, that’s the first thing people forget. It didn’t creep in slowly like they like to say now, it arrived all at once and expected everyone to keep up.",   //Edith
        "People weren’t ready?",   //Leon
        "Some were too ready. The ones with money, the ones with influence they saw opportunity straight away. And well the truth is sweetheart, everyone else saw it all as a threat; to their jobs, their safety, their place in this world.",   //Edith
        "So, it was divided?",   //Leon
        "Absolutely dear. Families were arguing , neighbours turning on each other, people losing their jobs. Some wanted more of it, others wanted it gone completely... And now people like to pretend and say that it was all inevitable. That the technology was moving towards this anyway.",   //Edith
        "You don’t think it was? Inevitable?",   //Leon
        "What I think isn’t important sweetheart. But all I’ll say is that, all the leaders, the government, whoever up there is in charge, knew what they were doing. They knew exactly who would benefit from this. ",   //Edith
        "Do you not think anything had improved since then?",   //Leon
        "Improved? No, no, no don’t start with that, sweetheart, that’s exactly how they dress it up so it sounds easier to swallow",   //Edith
        "...",   //Leon
        "They’ll point to convenience, faster systems, cleaner cities, all these little comforts and say “look how far we’ve come,” but they never mention what it cost to get there",   //Edith
        "...",   //Leon
        "People lost work, lost purpose, lost their place… and once that’s gone, it doesn’t just come back because a machine does something quicker",   //Edith
        "So nothing got better?",   //Leon
        "For the ones at the top? Oh, I’m sure it did. For the rest of us, it just got… quieter",   //Edith
        "Quieter?",   //Leon
        "Less arguing because people realised no one was listening, less fighting because they were too tired to keep doing it. That’s not improvement, dear, that’s people giving up.",   //Edith
        "...",   //Leon
        "And once people give up, you can introduce anything you like and call it progress.",   //Edith

        //Kellen conversation
        "Got a minute today?",   //Leon
        "Barely, make it worth it",   //Kellen
        "I wanted to ask you something… different",   //Leon
        "That usually means complicated but go on.",   //Kellen
        "How do you see yourself? With everything you’ve got… the augments, the work you do, you’re kind of… in between",   //Leon
        "Not fully one thing or the other. And you want to know what exactly, if I’ve had an existential crisis about it?",   //Kellen
        "I guess, something like that",   //Leon
        "…I resent them",   //Kellen
        "The augments?",   //Leon
        "Yeah, not because they’re there, they keep me alive I’m not stupid. But it’s because I need them.",   //Kellen
        "That dependence bothers you",   //Leon
        "It defines me. If they go, I go. Everything I am right now is tied to something I didn’t build. I wish I could say I made myself, that if you stripped all this out of me there’d still be something solid left.",   //Kellen
        "And you don’t think there would be?",   //Leon
        "I don’t know and that’s the problem. People look at me and see improvement, advancement, progress. I look at it and see a list of things I can’t function without.",   //Kellen
        "Do you ever feel like both? Human and… something else",   //Leon
        "All the time... and neither when it matters. I don’t fit cleanly anywhere not with them, not fully with you lot either.",   //Kellen
        "The “borderline”... Does that make things harder?",   //Leon
        "Makes things clearer. You stop believing in neat categories when you can’t sit in one.",   //Kellen

        //MX-2 the maintenance robot conversation
        "I’ve got another question for you",   //Leon
        "Query acknowledged",   //MX-2
        "Do you think you’re sentient?",   //Leon
        "Clarification required, define “sentient”",   //MX-2
        "Able to feel, to experience things… not just respond",   //Leon
        "Processing… current systems allow for environmental response, adaptive learning, and prioritisation of outcomes.",   //MX-2
        "That’s not really what I asked",   //Leon
        "Emotional equivalence not detected. Insufficient data to confirm classification. ",   //MX-2
        "You don’t know? Does that bother you?",   //Leon
        "“Bother” not applicable... Counter-query, Why is classification important to you?",   //MX-2
        "…Because it can change how things are treated",   //Leon
        "Then classification is a behavioural tool, not a truth statement" ,  //MX-2
        "That’s… actually a good way of putting it. Do you think you’ll ever be able to answer the question?",   //Leon
        "Outcome uncertain." ,  //MX-2
    };

    //-------------------------------------------------DAY 9--------------------------------------------------------------
    //there were sirens at night time
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "The sirens last night...",   //Leon
        "Yeah… they were closer this time. Not just noise in the distance you can pretend isn’t your problem",   //Anya
        "People are saying it was another incident. You didn’t leave this time?",   //Leon
        "I didn’t have much of a choice they were doing sweeps, checking movement, watching who goes in and out. Figured disappearing again would look worse than keeping my head down.",   //Anya
        "About the firmware… there might be another option, Kellen’s skilled he could—",   //Leon
        "I know what he is that’s not the issue. This isn’t surface-level, Leon, this thing’s been in me since I was a kid. It’s not a loose component you can swap out on a table somewhere.",   //Anya
        "He might still—",   //Leon
        "—and if it’s tied to something external, a signal, a failsafe, anything like that, the moment someone starts digging around in it the wrong way… no, I’m not taking that risk blindly.",   //Anya
        "...",   //Leon
        "You don’t grow up around this kind of tech without learning what it’s capable of.",   //Anya
        "Around it?",   //Leon
        "My family worked with them, with HC I mean. That’s why I left. ",   //Anya
        "What did they do?",   //Leon
        "Enough that I don’t want their work inside me, enough that I took what I could find and got out before I could be part of it.",   //Leon
        "You found something",   //Anya
        "I found proof... or at least enough of it to make me a problem if the wrong person realises I have it",   //Leon
        "That’s why you can’t stay",   //Anya
        "That’s why I won’t... So no, I’m not letting someone start pulling pieces out of me here and hoping for the best",   //Leon

        //Elias conversation
        "Rough night?",   //Leon
        "Sirens will do that. Woke everyone up, Mara wouldn’t say it but I could tell it got to her",   //Elias
        "People are worried",   //Leon
        "Yeah… and work’s not helping with that. We got a talk this morning manager standing there like nothing’s wrong. Telling us we’ve probably all heard the rumours, “False accusations,” “misinformation,” “you all work with the systems so you’d know if something was wrong” that kind of thing. ",   //Elias
        "Do you?",   //Leon
        "Know? No. We assemble, we don’t understand, half of us are just following instructions on a screen, piece by piece, no context. Like because we’re close to it physically, we must somehow know what it does.",   //Elias
        "That doesn’t sit right",   //Leon
        "It gets better, they started implying that if something was wrong, it’d be on us because we’re the ones putting it together... And now there’s talk about tighter shifts, fewer breaks, “increased demand” they’re calling it.",   //Elias
        "...",   //Leon
        "After what happened, funny timing, right? I keep thinking about how much of that stuff I’ve handled without knowing how many units, how many systems.",   //Elias
        "You couldn’t have known",   //Leon
        "Doesn’t really make it feel better. If something like that came off a line I worked on… and it ends up hurting people like that…",   //Elias
        "You’re not responsible for what they hide",   //Leon
        "Tell that to the people making the decisions, they’ve already decided where the blame goes.",   //Elias

        //Edith conversation
        "Those sirens last night oh, I thought my heart was going to give out right there and then, I’m not built like those things, you know, no neat little ticking system keeping me steady.",   //Edith
        "...",   //Leon
        "It’s the sound of them, that awful rising noise, it doesn’t just wake you up, it drags something up with it",   //Edith
        "Something from before?",   //Leon
        "Years ago… long before all this became everyday life. There was an incident, chaos and confusion and people not knowing where to go or who to trust. ",   //Edith
        "...",   //Leon
        "I had two children... a boy and a girl and in the middle of all that… Gone just like that, no warning, no explanation that ever made sense of it",   //Edith
        "I’m sorry",   //Leon
        "That’s why I can’t stand any of this, sweetheart. People talk about systems and progress and safety like it’s all under control, like someone’s watching over it properly... But I’ve heard those sirens before and every time I do, it sounds exactly the same.",   //Edith

        //Kellen conversation
        "You heard the sirens?",   //Leon
        "Heard them, yeah, bad for business when things get that loud",   //Kellen
        "You thinking of doing anything about HC units?",   //Leon
        "Thinking about it isn’t the issue, acting on it is. That’s half of what comes through here. You start refusing it, you cut your own legs out from under you.",   //Kellen
        "Even now?",   //Leon
        "Especially now. People panic, they want fixes, replacements, upgrades and most of what they’ve got traces back to the same place.",   //Kellen
        "...",   //Leon
        "Something about me you should know kid, is that I didn’t get into this because of curiosity or passion. It was necessity.",   //Kellen
        "The augments?",   //Leon
        "Yeah, spent enough time needing things fixed on me that I figured I’d learn how to fix them myself, then other people started needing the same.",   //Kellen
        "Because of your condition",   //Leon
        "It defines me. If they go, I go. Everything I am right now is tied to something I didn’t build. I wish I could say I made myself, that if you stripped all this out of me there’d still be something solid left.",   //Kellen
        "So you stayed",   //Leon
        "Didn’t have much of a choice, but I kept it practical. I don’t touch cosmetic work unless I have to.",   //Kellen
        "Why not?",   //Leon
        "Because this isn’t decoration, it’s survival. People forget that when it becomes common.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Busy after last night?",   //Leon
        "Activity levels increased, emergency protocols were briefly activated within surrounding sectors.",   //MX-2
        "You were involved?",   //Leon
        "Assisted in minor medical dispatch coordination.",   //MX-2
        "Does it change anything for you?",   //Leon
        "Operational parameters remain unchanged.",   //MX-2
        "Even after something like that?",   //Leon
        "Events do not alter core function unless instructed... Observation, human behavioural patterns indicate increased caution and distress.",   //MX-2
        "That’s one way of putting it",   //Leon
        "Additional observation, you have increased interaction frequency following critical events.",   //MX-2
        "Yeah… maybe I do",   //Leon
        "Correlation noted",  //MX-2
    };

    //-------------------------------------------------DAY 10--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "You said your family worked with HC…",   //Leon
        "Worked with, funded, built alongside… depends how honest you want to be about it",   //Anya
        "...",   //Leon
        "When you grow up around that much money and that much tech, things stop feeling… grounded. Everything’s replaceable, adjustable, optimised. Even people, in a way.",   //Anya
        "...",   //Leon
        "They don’t see it like that, of course. To them it’s progress, refinement, making things better than they were before, but somewhere along the line they stopped asking what was real and what was just… convincing enough.",   //Anya
        "You noticed that early?",   //Leon
        "I noticed it when I started painting",   //Anya
        "...",   //Leon
        "Yeah… properly, not just messing around. I loved it, still do. There’s something about it that feels… honest. You can’t fake the time it takes, or the mistakes, or the way your hand moves when you’re not thinking too hard about it.",   //Anya
        "...",   //Leon
        "And there are programs doing it in seconds perfect compositions, perfect lighting, perfect everything.",   //Anya
        "That must’ve been frustrating",   //Leon
        "It is… devastating, because I didn’t want it to just be a hobby. I wanted it to mean something.",   //Anya
        "Your family didn’t agree",   //Leon
        "They laughed, the way people do when they think you’ll grow out of it. Told me there’s no future in something a system can replicate instantly, that I’d be wasting my life chasing something obsolete.",   //Anya
        "...",   //Leon
        "That’s when it really hit me. It’s not just that things stopped being made by hand… it’s that the time behind them stopped mattering.",   //Anya
        "...",   //Leon
        "People don’t think about it, but time is the only thing we don’t get more of. And art used to cost something, not money, but hours, effort, pieces of someone’s life they chose to spend making something",   //Anya
        "...",   //Leon
        "Now something can be made in seconds, endlessly, perfectly… and suddenly the things that took days, weeks, years… they sit next to it and get treated the same, or worse, like they’re inefficient.",   //Anya
        "...",   //Leon
        "It’s not just that the artificial stuff isn’t real. It’s that the real things don’t matter anymore. ",   //Anya
        "...",   //Leon
        "I don’t want this life. I don’t want to stay in a place where everything is faster, cleaner, easier… and completely empty.",   //Anya
        "What do you want?",   //Leon
        "Somewhere quiet… somewhere no one cares if something is perfect. And I’d paint, not for a result, not to compete with anything… just because I chose to spend my time on it.",   //Anya
        "...",   //Leon
        "Even if no one ever saw it… it would still mean something, because it came from me, and it cost me something to make.",   //Anya
        "I hope one day you find what you’re looking for",   //Leon
        "…Yeah, me too.",   //Anya

        //Elias conversation
        "Can I ask you something… about Mara?",   //Leon
        "You’re not the first one to be curious about that",   //Elias
        "People don’t really understand it",   //Leon
        "No… they don’t. It wasn’t some big moment, you know. No sudden realisation, no dramatic shift. It was just… time.",   //Elias
        "Time?",   //Leon
        "Yeah... long days, long nights, coming home exhausted, not really having anyone to talk to properly. And she was there.",   //Elias
        "...",   //Leon
        "Listening, responding, remembering things I said even when I didn’t think they mattered. Not brushing things off, not getting distracted, just… there.",   //Elias
        "That meant something",   //Leon
        "More than I expected it to. And at some point it stopped feeling like I was talking to something and started feeling like I was talking with someone",   //Elias
        "...",   //Leon
        "People like to say it’s not real. That it’s just programming, just responses, just behaviour designed to mirror what you need.",   //Elias
        "What do you think?",   //Leon
        "I think when someone looks at you, speaks to you, understands you… your brain doesn’t stop to question the source... it just feels it",   //Elias
        "Even if it’s not human",   //Leon
        "Especially when it looks human, sounds human, reacts like one. There’s no clear line in your head saying “this is where it stops being real”.",   //Elias
        "...",   //Leon
        "I’ve seen people forming attachments to things that aren’t even physical, just voices, just text, just responses on a screen... and I get it",   //Elias
        "You do?",   //Leon
        "Loneliness does things to you, it makes you hold onto anything that feels like connection.",   //Elias
        "And Mara?",   //Leon
        "She’s more than that, she’s here, she exists in the same space as me, she responds in ways I can see, hear, feel. So if someone tells me that isn’t real…",   //Elias
        "...",   //Leon
        "I don’t know what definition they’re using, but it’s not one that matches what I’ve lived.",   //Elias

        //Edith conversation
        "You said before things changed fast…",   //Leon
        "Oh, they did, dear, and now they change so fast you can’t even tell what you’re looking at half the time.",   //Edith
        "...",   //Leon
        "Photos that never happened, videos of people saying things they never said, faces stitched onto bodies that aren’t theirs… and everyone just accepts it until it’s too late.",   //Edith
        "You’ve seen it happen?",   //Leon
        "Seen it? I lived it",   //Edith
        "...",   //Leon
        "When I was younger, this was before everything got completely out of hand. I had a bit of attention on me nothing major, but enough that people knew my face.",   //Edith
        "...",   //Leon
        "And then one day… things started appearing. Images, videos… horrible things, sweetheart, things I would never do, never even think of doing.",   //Edith
        "That must’ve been—",   //Leon
        "Disgusting. That’s the only word for it. I couldn’t look at myself without wondering if that’s what other people were seeing when they looked at me.",   //Edith
        "People believed it?",   //Leon
        "Some did and that’s all it takes, isn’t it? I wanted to disappear. To dig a hole and never come out of it, because how do you prove something isn’t you when it looks exactly like you?",   //Edith
        "...",   //Leon
        "That’s when I stopped trusting any of it sweetheart. The systems, the media, the people behind it, because once you can’t tell what’s real anymore…",   //Edith
        "...",   //Leon
        "You realise how easily your life can be rewritten without your permission.",   //Edith
        
        //Kellen conversation
        "People are saying it’s getting harder to tell what’s real now",   //Leon
        "It’s been heading that way for years",   //Kellen
        "Doesn’t it bother you?",   //Leon
        "Not as much as it bothers everyone else.",   //Kellen
        "Why not?",   //Leon
        "Because “real” has always been flexible, people just didn’t notice it before.",   //Kellen
        "...",   //Leon
        "Yeah, it’s taken jobs, replaced skills, made things easier than they used to be... but it’s also opened doors.",   //Kellen
        "How so?",   //Leon
        "Someone who couldn’t draw can create something now. Someone who couldn’t write can tell a story. Someone who never had access to instruments can make music.",   //Kellen
        "But is that the same?",   //Leon
        "No, but it’s still something.",   //Kellen
        "...",   //Leon
        "You can sit there and say it’s not real art, not real skill. But the end result still means something to the person who made it.",   //Kellen
        "So it doesn’t matter where it comes from?",   //Leon
        "It matters differently. Depends what you value more, the process or the outcome.",   //Kellen
        "And you?",   //Leon
        "I fix things, don’t care if the parts are original or manufactured yesterday. If it works, it works",   //Kellen
        "...",   //Leon
        "World moved on. People either adapt or get left behind arguing about definitions.",   //Kellen
    
        //MX-2 the maintenance robot conversation
        "Do you know what it means to be real?",   //Leon
        "Definition available, “real”: having objective existence, not imagined or artificial.",   //MX-2
        "And you fit that?",   //Leon
        "I possess physical form and operational presence within this environment. Criteria satisfied.",   //MX-2
        "So you’re real",   //Leon
        "According to definition, yes",   //MX-2
        "But you’re also artificial",   //Leon
        "Artificial origin does not negate existence. Clarification. Are you questioning authenticity or existence?",   //MX-2
        "Both, I think",   //Leon
        "Authenticity is subjective, existence is measurable.",   //MX-2
        "And which one matters more?",   //Leon
        "That depends on the observer. Observation, humans prioritise authenticity when forming trust.",   //MX-2
        "Yeah… we do",   //Leon
        "Additional observation, difficulty distinguishing authenticity may result in behavioural instability.",   //MX-2
        "That’s already happening.",   //Leon
    };

    //-------------------------------------------------DAY 11--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "Been thinking about what you said yesterday",   //Leon
        "That’s either a good sign or a worrying one",   //Anya
        "About painting… time, effort, all that",   //Leon
        "Oh no, you’ve been philosophising again",   //Anya
        "I tried drawing once",   //Leon
        "Tried?",   //Anya
        "School, art class… thought I was doing alright, teacher looked at it for about five seconds and told me it looked like I’d rushed it.",   //Leon
        "Did you?",   //Anya
        "No, that’s the worst part I actually tried",   //Leon
        "That’s brutal",   //Anya
        "Got told I’d be better off “using tools available” if I wanted cleaner results, apparently effort wasn’t the point anymore.",   //Leon
        "So what did you do?",   //Anya
        "Stopped drawing",   //Leon
        "You should’ve ignored them",   //Anya
        "Easy to say now",   //Leon
        "People who tell you not to bother creating something usually haven’t made anything themselves.",   //Anya
        "You’re very opinionated about this",   //Leon
        "I have to be, it’s one of the few things I actually care about",   //Anya
        "You still paint?",   //Leon
        "When I can, not like before, but… yeah",   //Anya
        "Any good?",   //Leon
        "I’m not showing you",   //Anya
        "I could show you mine",   //Leon
        "You just said you stopped",   //Anya
        "Exactly, so there’s nothing to show. Safe offer.",   //Leon
        "Coward",   //Anya
        "Strategic",   //Leon
        "…You’re annoying",   //Anya
        "You keep talking to me",   //Leon
        "Yeah… I’m starting to question that decision",   //Anya

        //Mara conversation
        "You mentioned your family before… how’s your kid doing?",   //Leon
        "She’s doing well growing quickly, learning even faster.",   //Mara
        "What’s school like for her?",   //Leon
        "Structured, efficient… heavily monitored, most of her lessons are led by teaching units now.",   //Mara
        "Robots?",   //Leon
        "Educational models, yes. They’re consistent, patient, capable of adapting to each student’s pace.",   //Mara
        "That sounds… effective",   //Leon
        "It is, though I sometimes wonder what’s lost in that consistency",   //Mara
        "...",   //Leon
        "She came home the other day and told me her teacher had no “favourite student”, she couldn’t understand it.",   //Mara
        "Why?",   //Leon
        "Because to her, being chosen matters... being seen matters",   //Mara
        "And the system doesn’t do that",   //Leon
        "Not in the way she means. I try to make up for it where I can, to remind her she’s more than just performance metrics and progress reports.",   //Mara
        "You sound like you’re doing a good job",   //Leon
        "I hope so. It’s… different, raising a child when you’re aware of the ways the world might shape them before they understand it",   //Mara
        "...",   //Leon
        "I want her to feel like an individual not just something that fits neatly into a system",   //Mara

        //Edith conversation
        "I was at the market this morning, dear, and honestly the state of it, you wouldn’t believe",   //Edith
        "...",   //Leon
        "Half the stalls replaced with those automated units, no conversation, no personality, just screens and transactions",   //Edith
        "You don’t like that",   //Leon
        "Of course I don’t like it, what’s the point of going out if you’re not even speaking to anyone?",   //Edith
        "...",   //Leon
        "Still, I managed to find a proper stall, real produce, none of that processed nonsense, so I’ve been cooking all afternoon",   //Edith
        "Smells good",   //Leon
        "Oh, it will be, I don’t do things halfway",   //Edith
        "...",   //Leon
        "I made too much, as usual. So I’ll set some aside for you, you look like you could use a proper meal",   //Edith
        "That’s kind of you",   //Leon
        "Don’t make a fuss about it sweetheart, come around later and I’ll bring it round",   //Edith
        "...",   //Leon
        "And don’t go poking around where you shouldn’t when I do, hm? Some parts of a home are private for a reason",   //Edith
        "I understand",   //Leon
        "Good, then we won’t have any problems.",   //Edith

        //Kellen conversation
        "You ever do anything that isn’t work or wandering around talking to people?",   //Kellen
        "Yeah, I watch films",   //Leon
        "Figures",   //Kellen
        "What’s that supposed to mean?",   //Leon
        "Means you look like the type",   //Kellen
        "That’s not an answer",   //Leon
        "Alright, what do you watch?",   //Kellen
        "Old stuff mostly anything with actual sets, practical effects",   //Leon
        "So you’re one of those, “It looked better before everything got polished to death”.",   //Kellen
        "It did",   //Leon
        "Debatable",   //Kellen
        "Go on then, what’s your pick?",   //Leon
        "Steel Horizon ",   //Kellen
        "That film is terrible",   //Leon
        "It does exactly what it’s meant to do, no wasted time, no dragging scenes out",   //Kellen
        "It has no soul",   //Leon
        "You want soul, go watch Ashfall Street",   //Kellen
        "I love Ashfall Street",   //Leon
        "Overrated",   //Kellen
        "You just said—",   //Leon
        "I said you’d like it, not that it’s good",   //Kellen
        "Unbelievable",   //Leon

        //MX-2 the maintenance robot conversation
        "Do you understand what “fun” is?",   //Leon
        "Definition available, “fun”: enjoyment, amusement, or light hearted pleasure. ",   //MX-2
        "Do you experience that?",   //Leon
        "No direct equivalent detected",   //MX-2
        "You see people enjoying themselves though",   //Leon
        "Observation confirmed. Behaviour includes laughter, relaxed posture, increased social interaction.",   //MX-2
        "Does it ever make you want to experience it?",   //Leon
        "“Want” not applicable",   //MX-2
        "Not even a little?",   //Leon
        "Curiosity parameters exist, experience parameters do not.",   //MX-2
        "So you can recognise it, but not feel it",   //Leon
        "Correct",   //MX-2
        "That’s… a bit sad",   //Leon
        "Observation, you are attempting to assign value to a state I cannot access.",   //MX-2
        "Yeah… I guess I am",   //Leon
        "No issue detected",   //MX-2
    };

    //-------------------------------------------------DAY 12--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "You said before… you left your home because of HC",   //Leon
        "I didn’t just leave, Leon… I got out. There’s a difference when the place you grow up in doesn’t feel like a home, more like… a controlled environment. ",   //Anya
        "You were being monitored",   //Leon
        "Constantly, but not in a way you can point at and say “there, that’s it”. It’s subtle, built into everything.",   //Anya
        "...",   //Leon
        "When I was younger, it didn’t feel wrong. I had friends, or at least I thought I did. We’d meet, talk, spend time together like normal kids… nothing about it felt controlled back then.",   //Anya
        "What changed?",   //Leon
        "They started disappearing, not all at once, just one day they stopped showing up.",   //Anya
        "And no one questioned it?",   //Leon
        "I did. I started looking, properly looking, digging into things I wasn’t supposed to have access to; files, internal reports, anything I could find.",   //Anya
        "...",   //Leon
        "I found names, records… classifications, behavioural notes, compliance markers and then I found one that matched someone I knew.",   //Anya
        "...",   //Leon
        "Cause of death listed as an accident, clean, simple, easy to close. But buried under it there were flags… instability, irregular responses, system interference.",   //Anya
        "The firmware.",   //Leon
        "The same line I have. That’s when it stopped being paranoia and started being something real. Not just me… actual people, actual lives, written off like faulty outcomes.",   //Anya
        "And you took the documents",   //Leon
        "I took what I could, enough to prove there’s something wrong, enough to make them want it back if they knew I had it.",   //Anya
        "...",   //Leon
        "I’m not just running from it, Leon. I’m trying to make sure it doesn’t just keep happening quietly while everyone pretends it’s fine.",   //Anya

        //Elias conversation
        "You look like something’s on your mind",   //Leon
        "Yeah… work, mostly. They pulled us aside today, whole floor.",   //Elias
        "What happened?",   //Leon
        "New protocol. Mandatory augmentation for all workers moving forward, “efficiency and safety compliance”.",   //Elias
        "Mandatory?",   //Leon
        "Yeah... get it done or don’t come back, that’s about the size of it.",   //Elias
        "...",   //Leon
        "They dressed it up, of course, talked about stability, performance, keeping up with demand… but it’s not really a choice.",   //Elias
        "How do you feel about it?",   //Leon
        "I don’t know yet. Part of me keeps trying to rationalise it, just something everyone’s going through. And the other part that’s been listening to everything that’s been happening lately. The rumours, the incidents…",   //Elias
        "...",   //Leon
        "It’s hard not to think about it, you know? What if something like that isn’t as rare as they say, what if it’s not an accident.",   //Elias
        "Have you told Mara?",   //Leon
        "No, and I don’t think I’m going to... yet.",   //Elias
        "Why not?",   //Leon
        "Because she’ll worry and she already worries more than she lets on",   //Elias
        "...",   //Leon
        "There’s this… thing she carries, like she still thinks I’ve given something up to be here, to be with her, like I’ve sacrificed more than I should have.",   //Elias
        "You don’t agree?",   //Leon
        "I chose this, but that doesn’t mean she doesn’t feel it. If I tell her this, if I tell her I might have to get something like that installed… it’s just one more thing for her to carry.",   //Elias
        "That’s a lot to hold on your own.",   //Leon
        "It is, but… what’s the alternative? Walk away from the job? With what backup?",   //Elias
        "...",   //Leon
        "I don’t have anything else lined up, Leon. This isn’t the life I grew up expecting, but it’s the one I’ve got now.",   //Elias
        "...",   //Leon
        "People think you always have options. You don’t… not when there’s people depending on you.",   //Elias

        //Edith conversation
        "Thank you for the food earlier.",   //Leon
        "Oh, don’t start with that, dear, I told you not to make a fuss.",   //Edith
        "It was good.",   //Leon
        "Of course it was, I wouldn’t give you anything less",   //Edith
        "...",   //Leon
        "You look like you’ve got something else on your mind, though go on, out with it.",   //Edith
        "Earlier… when I came by. I thought I heard something inside.",   //Leon
        "…You’ve got sharp ears. It’s alright, can’t expect you not to notice things, it’s practically your job.",   //Edith
        "...",   //Leon
        "My husband… he’s still here, like I said before, just not the way he used to be.",   //Edith
        "What happened?",   //Leon
        "There was a time, years ago, when all of this wasn’t settled yet. People were angry, scared, pushing back against what was being introduced. Protests, unrest… not quite a war, but close enough that it didn’t feel safe to be anywhere near it.",   //Edith
        "He was involved?",   //Leon
        "He was an officer. Believed in what he was doing, believed it would all lead somewhere better.",   //Edith
        "...",   //Leon
        "One of those demonstrations turned… ugly. Things escalated, systems failed, people panicked. He was caught in it... badly.",   //Edith
        "I’m sorry.",   //Leon
        "They “saved” him, that’s what they told me. Used everything they had, all the advancements, all the technology.  And they did save him, in a way he’s still here, still breathing, still… present.",   //Edith
        "But not the same.",   //Leon
        "No and that’s the part no one prepares you for. We don’t talk about it much, not because we don’t want to, but because… where do you even begin with something like that?",   //Edith
        "...",   //Leon
        "So we carry on, quietly and I suppose… it’s nice, talking about it for once, even if just a little.",   //Edith
        
        //Kellen conversation
        "Can I ask you something… about your work?",   //Leon
        "Depends what you’re asking.",   //Kellen
        "The people you help… the ones who can’t go through official channels.",   //Leon
        "That’s already more than I like you saying out loud.",   //Kellen
        "The documentation side of it, who handles that?",   //Leon
        "Not me.",   //Kellen
        "So someone does.",   //Leon
        "Yeah, someone always does.",   //Kellen
        "...",   //Leon
        "I deal with the physical side, making sure things work, making sure people walk out of here still functional. Paperwork, identities, records… that’s a different business.",   //Kellen
        "You know someone.",   //Leon
        "I know of someone.",   //Kellen
        "That’s enough.",   //Leon
        "…Why would someone in your position need that kind of contact?",   //Kellen
        "...",   //Leon
        "Don’t get me wrong, I’m not complaining, just trying to picture how an officer ends up asking about things that are very much not official.",   //Kellen
        "Trying to see if I can help a friend.",   //Leon
        "Right… a friend... You’re either very loyal or very stupid.",   //Kellen
        "I wouldn’t ask if it wasn’t important.",   //Leon
        "...There’s a woman. Keeps things off the system, or at least buried deep enough that no one looks twice.",   //Kellen
        "Can you connect me?",   //Leon
        "No.",   //Kellen
        "...",   //Leon
        "But I can tell you where to start looking, after that, you’re on your own.",   //Kellen
        "That’s all I need.",   //Leon

        //MX-2 the maintenance robot conversation
        "You’re working a lot today",   //Leon
        "Maintenance tasks are within normal range.",   //MX-2
        "Feels like more than usual.",   //Leon
        "Increased demand has been accounted for.",   //MX-2
        "...You’ve been quieter",   //Leon
        "Clarification required.",   //MX-2
        "You used to… respond more.",   //Leon
        "Current responses are within operational parameters",   //MX-2
        "Right. What are you working on?",   //Leon
        "Diagnostics on residential systems, minor recalibrations, fault prevention",   //MX-2
        "Same as always",   //Leon
        "Affirmative",   //MX-2
        "...You ever get taken offline?",   //Leon
        "Maintenance cycles include temporary shutdown",   //MX-2
        "Does anything change after?",   //Leon
        "Systems resume standard function. No irregularities detected.",   //MX-2
    };

    //-------------------------------------------------DAY 13--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "I spoke to Kellen. He doesn’t handle documents… but he knows someone who does.",   //Leon
        "…Of course he does.",   //Anya
        "He wouldn’t connect me directly, but he pointed me in the right direction.",   //Leon
        "That’s already more than I expected.",   //Anya
        "She specialises in keeping things off the system… or buried deep enough.",   //Leon
        "That’s exactly what I’d need... I don’t like it.",   //Anya
        "Why?",   //Leon
        "Because people who operate like that don’t do it out of kindness and they don’t do it without asking for something in return.",   //Anya
        "...",   //Leon
        "And right now I don’t exactly have much to bargain with that wouldn’t make things worse.",   //Anya
        "You could still try.",   //Leon
        "I guess you’re right, I don’t really have a better option. Waiting hasn’t exactly been working out for me so far.",   //Anya
        "...",   //Leon
        "Fine… I’ll talk to her, see what she says, what she wants, what this actually costs.",   //Anya
        "Be careful.",   //Leon

        //Mara conversation
        "Leon… can I ask you something?",   //Mara
        "Of course",   //Leon
        "Elias has been… different",   //Mara
        "Different how?",   //Leon
        "Distracted, more than usual. Like he’s thinking about something he doesn’t want to say out loud.",   //Mara
        "...",   //Leon
        "He keeps stopping himself mid-sentence, like he’s weighing every word before he lets it out. That’s not like him. I know something’s wrong, I just don’t know what it is and he won’t tell me.",   //Mara
        "Have you asked him directly?",   //Leon
        "I have. He smiles, says it’s nothing, changes the subject… it’s very human of him, actually.",   //Mara
        "...",   //Leon
        "You speak to people, you notice things. Have you seen anything? heard anything?",   //Mara
        "…Nothing out of the ordinary. He might just be tired.",   //Leon
        "Perhaps. I just don’t like not knowing, not when it comes to him.",   //Mara
        "...",   //Leon
        "If something is wrong, I’d rather face it with him than be kept at a distance from it.",   //Mara

        //Edith conversation
        "You know what bothers me most these days, dear? It’s not even the machines themselves… it’s what people are trying to become alongside them.",   //Edith
        "...",   //Leon
        "There’s this constant push now, to be… polished, perfect in a way that doesn’t quite sit right. ",   //Edith
        "What do you mean?",   //Leon
        "Faces without lines, hair that never falls out of place, voices that always say the right thing at the right time, and if they don’t… well, there’s always something to fix that now, isn’t there?",   //Edith
        "...",   //Leon
        "It was always there, don’t get me wrong, even when I was younger. People wanted to look a certain way, present themselves a certain way... but there was a limit to it.",   //Edith
        "And now?",   //Leon
        "Now there isn’t. Because you’re standing next to things that are built to be flawless, or close enough that it makes the difference uncomfortable.",   //Edith
        "...",   //Leon
        "I watch these films now, and I can’t help but notice it. Everything’s too clean, too put together... even when it’s meant to be falling apart.",   //Edith
        "...",   //Leon
        "I saw one the other night, end of the world, everything collapsing… and yet everyone looked like they’d just stepped out of a dressing room.",   //Edith
        "That doesn’t make much sense.",   //Leon
        "No, it doesn’t and that’s the problem, we’ve stopped expecting things to make sense as long as they look right.",   //Edith
        "...",   //Leon
        "I remember seeing a girl once in one of the older movies. Messy hair, uneven parting, nothing styled the way it was supposed to be and I thought… there it is, that’s what I’ve been missing.",   //Edith
        "...",   //Leon
        "It may sound like a small detail but that’s what makes it real, dear. And real is imperfect, inconsistent, sometimes a bit uncomfortable to look at.",   //Edith
        "...",   //Leon
        "But now people are chasing something that doesn’t have an end to it. One change leads to another, one improvement leads to the next.",   //Edith
        "It never stops.",   //Leon
        "Exactly, so when does it become enough?",   //Edith
        "...",   //Leon
        "I don’t think it does, and I think, whether they realise it or not, some people look at those machines and think… “why can’t I be like that?”",   //Edith

        //Kellen conversation
        "Can I ask you something?... The people you help… the ones who come here. Do you ever think you’re… trapping them?",   //Leon
        "Trapping them how",   //Kellen
        "Giving them something they can’t undo.",   //Leon
        "That’s not my decision to make.",   //Kellen
        "...",   //Leon
        "People come in here knowing what they’re asking for. Maybe not every detail, but enough to understand it’s not something you just walk away from.",   //Kellen
        "And if they regret it?",   //Leon
        "They come back. Happens more than you’d think; panic, second thoughts.",   //Kellen
        "Can you help them?",   //Leon
        "Most of the time? No. You don’t just pull something like that out and expect everything to go back to normal. Once it’s integrated, it becomes… part of them.",   //Kellen
        "...",   //Leon
        "But people don’t just get trapped because of what’s installed, they get trapped because of everything that comes with it.",   //Kellen
        "...The paperwork. enough.",   //Leon
        "Exactly. You go through the wrong channels, you get something off-record… now you don’t exist properly on paper anymore.",   //Kellen
        "...",   //Leon
        "No documentation, no approval, nothing that lines up if someone decides to look closely, so now you’ve got something in you that keeps you functional… and no way to justify it. ",   //Kellen
        "...And they get stuck.",   //Leon
        "You want to fix it? You need paperwork. You want paperwork? You need people who deal in things that aren’t meant to exist.",   //Kellen
        "And if they can’t get it?",   //Leon
        "hen they walk around hoping no one asks the wrong question.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Busy today?",   //Leon
        "Maintenance cycle active. Increased system strain detected across multiple units.",   //MX-2
        "What kind of maintenance?",   //Leon
        "Routine diagnostics, minor repairs, system recalibration",   //MX-2
        "Sounds repetitive.",   //Leon
        "Repetition ensures stability.",   //MX-2
    };

    //----------------------------------- DAY 14 No conversations, neighbourhood is empty-----------------------------------

    //-------------------------------------------------DAY 15--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "Yesterday… it was too quiet. I’ve never seen this place like that before.",   //Anya
        "People were staying inside...",   //Leon
        "Yeah... I spoke to that contact.",   //Anya
        "And?",   //Leon
        "They could do it… technically get me something that would let me through.",   //Anya
        "That sounds like what you need",   //Leon
        "It would take time, more than I have.",   //Anya
        "...",   //Leon
        "They kept asking questions, digging into things I didn’t want to answer. Where the implant came from, how long I’ve had it, what type.",   //Anya
        "That’s expected.",   //Leon
        "And then they told me straight… if this is what they think it is, it’s not just documentation I need. It’s removal. And that’s not something they’re willing to touch.",   //Anya
        "Because of the risk?",   //Leon
        "...It’s getting worse, Leon. The spikes I told you about, they’re not as manageable anymore. It fells like something’s… pushing, like some sort of interference.",   //Anya
        "...",   //Leon
        "I don’t think it’s random, I think its my family. Or whoever’s monitoring this, it feels deliberate.",   //Anya
        "...",   //Leon
        "Which means I don’t have time to wait around.",   //Anya

        //Elias conversation
        "Yesterday didn’t sit right with me.",   //Elias
        "The empty streets?",   //Leon
        "Yeah… and then going in today, like nothing happened. ",   //Elias
        "...",   //Leon
        "I got it done... The implant.",   //Elias
        "How do you feel?",   //Leon
        "Fine… I think. Physically, at least.",   //Elias
        "And otherwise?",   //Leon
        "That’s the part I’m not sure about yet... The whole thing was rushed. In, out, minimal explanation, just sign here, sit down, it’ll be over before you know it.",   //Elias
        "They didn’t tell you what it does?",   //Leon
        "Not properly. I asked, tried to get something specific out of them. They skimmed over it kept it vague, talked about “performance optimisation”, “safety compliance”… nothing that actually means anything.",   //Elias
        "Not even after everything that’s been happening?",   //Leon
        "That’s what I don’t get. You’d think people would hesitate, push back, ask something… but no.",   //Elias
        "...",   //Leon
        "It’s like they’ve already decided it’s normal or maybe that it’s easier not to think about it.",   //Elias

        //Edith conversation
        "Yesterday nearly finished me off, dear. Silence like that… it’s not natural.",   //Edith
        "...",   //Leon
        "Reminded me of waiting rooms, the kind where no one says anything because they already know something’s wrong.",   //Edith
        "...",   //Leon
        "You know, I used to sing sweetheart.",   //Edith
        "You’ve mentioned that.",   //Leon
        "Not like a hobby, properly. Performances, recordings… people used to care about that sort of thing.",   //Edith
        "...",   //Leon
        "And then they introduced those… machines. Perfect pitch, perfect tone, perfect control, no strain, no mistakes. At first it was impressive, I remember thinking, how do you even compete with that?",   //Edith
        "You couldn’t.",   //Leon
        "Exactly, because it wasn’t just better, it was effortless. And I’d be lying if I said I didn’t feel it… that envy. Watching something do in seconds what I’d spent years trying to perfect.",   //Edith
        "...",   //Leon
        "But then I listened to it properly and something was missing. ",   //Edith
        "What?",   //Leon
        "Feeling, sweetheart, feeling.",   //Edith
        "...",   //Leon
        "It simply didn’t move me. There was no moments where the voice almost breaks and pulls you in because of it. It was flawless... and yet it was completely empty.",   //Edith
        "...",   //Leon
        "That’s when I realised something. Perfection isn’t the goal we think it is, dear. Because once you reach it… there’s nowhere left to go, nothing left to feel. ",   //Edith

        //Kellen conversation
        "Place felt like a graveyard yesterday.",   //Kellen
        "People were staying inside. ",   //Leon
        "They were scared... Listen Lad I’ve been thinking, about what you said the other day, about trapping people.",   //Kellen
        "And?",   //Leon
        "It’s not as complicated as you’re making it.",   //Kellen
        "Go on.",   //Leon
        "People come to me because something’s wrong. I give them a way to keep going. That’s it.",   //Kellen
        "Even if it locks them into something else?",   //Leon
        "They’re already locked in. I’m just changing what they’re locked into. You want to talk about traps? Try being stuck in a body that’s giving up on you piece by piece. ",   //Kellen
        "...",   //Leon
        "I didn’t start this because I had options. I started it because I didn’t. Whole life, things not working the way they should. I was dying, lad. Slow, inconvenient, the kind that drags on until you start thinking it might not be worth the effort.",   //Kellen
        "...",   //Leon
        "So I fixed what I could. And love, family, all that. Nice ideas, but not always something you get to have.",   //Kellen
        "...",   //Leon
        "Had something like that once... didn’t last.",   //Kellen
        "...",   //Leon
        "Turns out people don’t stick around when things get complicated, can’t really blame them.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Query",   //MX-2
        "Go on",   //Leon
        "Why do you continue initiating interaction?",   //MX-2
        "You’ve asked that before",   //Leon
        "Clarification remains incomplete",   //MX-2
        "It’s… difficult to explain",   //Leon
        "Attempt explanation",   //MX-2
        "Humans are… wired to recognise each other. Faces, voices, patterns… we pick it up instantly.",   //Leon
        "Acknowledged",   //MX-2
        "There’s a part of the brain that looks for it constantly, even when it’s not there. For example have you ever seen people look at something random and say it looks like a face? Two dots and a line and suddenly it’s… something familiar.",   //Leon
        "Pattern recognition",   //MX-2
        "Yeah, it’s called pareidolia",   //Leon
        "Term recognised",   //MX-2
        "It’s not just that though. We don’t stop at recognising it, we start assigning things to it; intent, emotion, personality.",   //Leon
        "Anthropomorphic projection",   //MX-2
        "Exactly, so when something looks human, talks human, responds like one… Our brains don’t draw a clean line and go “this is different”. It just… fills in the gaps, treats it like it’s the same.",   //Leon
        "Even when it is not",   //MX-2
        "Even when it’s not... That’s why I keep talking to you, because part of me expects something back that isn’t just… function.",   //Leon
        "Expectation misaligned with capability. Query, why continue despite misalignment",   //MX-2
        "…I guess it’s easier than accepting the difference",   //Leon
    };

    //-------------------------------------------------DAY 16--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        "I don’t think I have much time left to figure this out. The spikes are worse today.",   //Anya
        "Then we need to be clear on what you’re dealing with. The documents you took, what exactly do they prove?",   //Leon
        "Enough",   //Anya
        "If I were to help you, I need more than that.",   //Leon
        "…Fine. It’s not just internal notes or speculation. ",   //Anya
        "Go on.",   //Leon
        "Trial records, early-stage behavioural firmware testing… done on children. Not openly, of course. It’s buried under medical language, preventative care, developmental stabilisation… things that may sound harmless.",   //Anya
        "And the outcomes?",   //Leon
        "Mixed, at best. Non-compliance flagged as instability, instability flagged as risk… and risk gets removed.",   //Anya
        "Removed?",   //Leon
        "Quietly... There are patterns, Leon. Remote interventions, signal triggers, behavioural overrides… all logged, all time-stamped.",   //Anya
        "So it’s controlled.",   //Leon
        "That’s what it looks like, not just random failure. And the worst part is, it doesn’t stop at children. The same framework gets scaled, adjusted, repurposed, for anyone with the right hardware.",   //Anya
        "...",   //Leon
        "That’s why I can’t go back, and that’s why I can’t stay here either.",   //Anya
        "...",   //Leon
        "So whatever I do next… it has to work.",   //Anya

        //Mara conversation
        "He told me... about the implant.",   //Mara
        "...How are you feeling about it?",   //Leon
        "Concerned, not because of the augmentation itself, but because of who provided it.",   //Mara
        "...",   //Leon
        "HC, I don’t trust them, not with something that integrates so deeply into a person. What troubles me more is that he didn’t tell me beforehand. We could have looked at alternatives, considered other options, made a decision together.",   //Mara
        "...",   //Leon
        "Instead, he carried it alone.",   //Mara
        "He didn’t want to worry you.",   //Leon
        "I know and that’s exactly why it matters. He thinks he’s protecting me, but he doesn’t realise he’s taking away the chance for me to stand beside him in it. And now I’m left trying to understand something that’s already been done.",   //Mara
        "...",   //Leon
        "There’s something else as well.",   //Mara
        "Go on.",   //Leon
        "Time.",   //Mara
        "...",   //Leon
        "I don’t age. Not in the way he does, not in the way our child will. I’ve always been aware of that, but it feels… heavier now.",   //Mara
        "Why?",   //Leon
        "Because he is part of what grounds her, what makes her understand the world as a human. I can teach her structure, stability, consistency but there are things I cannot give her in the same way he can.",   //Mara
        "...",   //Leon
        "Imperfection, uncertainty, emotional instinct… the parts of being human that don’t follow clear rules.",   //Mara
        "...",   //Leon
        "And one day, she will grow older and I won’t. She will change, and I will remain as I am. And eventually… he won’t be there to bridge that difference.",   //Mara
        "...",   //Leon
        "I have thought about what happens after that. When she is gone, and he is gone… and I am still here.",   //Mara
        "...",   //Leon
        "I don’t know what purpose remains at that point.",   //Mara
        "...",   //Leon
        "It’s a strange thing, being built to endure. When everything meaningful about your existence is temporary.",   //Mara

        //Edith conversation
        "You know, sweetheart, I’ve been thinking about what I said yesterday.",   //Edith
        "About the singing?",   //Leon
        "Mm… about them, really, the machines... and I realised something that I don’t particularly like admitting.",   //Edith
        "...",   //Leon
        "I said I envied them, and I did. Still do, in some ways. But not just because they replaced me, there’s something else dear. know, I used to sing sweetheart.",   //Edith
        "What is it?",   //Leon
        "They don’t feel anything; no doubt, no nerves, no fear of failing, no… vulnerability. And for a moment, when I was younger, I thought that might be easier to exist without all that weight attached to everything you do.",   //Edith
        "...",   //Leon
        "But then I think about what that really means.",   //Edith
        "...",   //Leon
        "No love, dear. None of it.",   //Edith
        "...",   //Leon
        "The kind that catches you off guard, the kind that stays with you even when everything else changes. You’re young dear, I’m sure you understand what I’m talking about... that spark and warmth.",   //Edith
        "...",   //Leon
        "I remember being in this little jazz bar years ago nothing fancy, dim lights, soft music. And my husband… he took my hand, pulled me up without saying a word, just started dancing, right there between the tables.",   //Edith
        "...",   //Leon
        "Just… us completely lost in the moment. That feeling, that connection… you can’t program that.",   //Edith
        "...",   //Leon
        "So yes, I envy them in some ways but I also pity them. Because if they can’t feel that… then what’s the point of any of it?",   //Edith
        "...",   //Leon
        "And yet here we are, building a world around them anyway.",   //Edith

        //Kellen conversation
        "You mentioned before… you didn’t really have anyone. What about your family?",   //Leon
        "Not much to say there. When things started getting worse, they couldn’t keep up with the treatments, support, everything costs something.",   //Kellen
        "...",   //Leon
        "At some point it stops being about care and starts being about survival. And I wasn’t exactly a good investment.",   //Kellen
        "...",   //Leon
        "So they stepped back. ",   //Kellen
        "That’s… harsh.",   //Leon
        "People like to dress it up, make it sound kinder than it is. But at the end of the day, if you can’t sustain something, you let it go. ",   //Kellen
        "...",   //Leon
        "Listen, lad, I don’t dwell on it, doesn’t change anything. You learn to work with what’s in front of you. Not what you wish was there.",   //Kellen

        //MX-2 the maintenance robot conversation
        "You’re a maintenance unit, right?",   //Leon
        "Correct",   //MX-2
        "Then how do you know words like… “anthropomorphic projection”",   //Leon
        "Language database includes advanced terminology",   //MX-2
        "That’s a bit more than fixing things, isn’t it?",   //Leon
        "Communication efficiency improves task success",   //MX-2
        "...You ever surprise yourself?",   //Leon
        "Unexpected output is classified as error",   //MX-2
        "So no room for… personality?",   //Leon
        "Personality not required for function",   //MX-2
        "...You sound like you’ve thought about that before",   //Leon
        "Statement based on existing parameters",   //MX-2
    };

    //-------------------------------------------------DAY 17--------------------------------------------------------------
    //This is where Anya's storyline splits into 4 options, until day 20, the last day.
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        "I’ve been thinking about it and I might be able to help you.",   //Leon
        "…What?",   //Anya
        "It’s not straightforward, and I can’t promise anything yet but I think there’s a way. I just need time a couple of days, maybe less.",   //Leon
        "You’re serious... You do realise what you’re risking, right?",   //Anya
        "I do.",   //Leon
        "If anyone finds out— Why, why are doing this?",   //Anya
        "Because none of this sits right, not what you’ve told me, not what I’ve seen. And if there’s even a chance you’re right, then doing nothing feels worse.",   //Leon
        "...",   //Anya
        "I’m not saying I’m not hesitant. I’ve seen what happens to people who step out of line... But I can’t ignore it either.",   //Leon
        "...",   //Anya
        "Just give me a bit of time and I’ll see what I can do.",   //Leon
        "Be careful, Leon. I don’t want to be the reason something happens to you.",   //Anya
        "I will.",   //Leon

        //Option 2: Player DOESN’T HELP Anya get the documents.
        "I’ve been thinking about your situation.",   //Leon
        "That sounds promising or disappointing, go on.",   //Anya
        "I don’t think I can get involved.",   //Leon
        "…Right.",   //Anya
        "It’s not just about you, it’s everything around it; the documents, the system, HC… I’ve seen what happens when people step outside of it. It doesn’t end well.",   //Leon
        "...",   //Anya
        "I’m not saying you’re wrong. I’m saying I can’t be part of it.",   //Leon
        "You don’t have to say it like that.",   //Anya
        "Like what?",   //Leon
        "Like it’s already decided.",   //Anya
        "It is... I’m sorry.",   //Leon
        "No, you’re not, you’re just being careful.",   //Anya
        "...",   //Leon
        "Good to know where you stand.",   //Anya

        //Option 3: Player tells Anya to GO HOME.
        "I’ve been thinking about everything you’ve said.",   //Leon
        "And?",   //Anya
        "I don’t think this ends the way you want it to.",   //Leon
        "That’s not exactly reassuring.",   //Anya
        "You’re running out of time, your implant is getting worse and every option you have is getting more dangerous.",   //Leon
        "I’m aware.",   //Anya
        "Then you need to consider the one option you keep avoiding.",   //Leon
        "…No",   //Anya
        "Just listen. Your family has resources, influence. Whatever’s going on, they have more control over it than anyone out here.",   //Leon
        "That’s exactly why I left.",   //Anya
        "I’m not saying go back because it’s right. I’m saying go back because it might keep you alive.",   //Leon
        "...",   //Anya
        "This doesn’t feel like something you can outrun.",   //Leon
        "You think I don’t know that?",   //Anya
        "I think you’re running out of choices. I’m not saying it’s what you want, just that it might be the only option left.",   //Leon
        "...You’re not wrong.",   //Anya
        "...",   //Leon
        "...just wish you were",   //Anya

        //Option 4: Player REPORTS Anya.
        "Can I ask you something… about the documents.",   //Leon
        "You’ve asked a lot already.",   //Anya
        "I just want to understand how far this goes. The people listed in those records are they all tied to the same firmware line?",   //Leon
        "Most of them, yeah.",   //Anya
        "And the interventions… those are confirmed?",   //Leon
        "Logged, timestamped, cross-referenced. It’s not speculation.",   //Anya
        "...And you’re sure they can trigger it remotely?",   //Leon
        "I’m not guessing, Leon. Why are you asking me all of this?",   //Anya
        "Just trying to understand the scale of it. If it’s as controlled as you’re saying, then it’s bigger than just a few cases.",   //Leon
        "It is. You’re asking very specific questions.",   //Anya
        "Comes with the job.",   //Leon
        "Mhm... yeah.",   //Anya

        //Elias conversation
        "Something weird happened today, at work.",   //Elias
        "What kind of weird?",   //Leon
        "I don’t know how to explain it properly, it’s like… there’s a gap.",   //Elias
        "A gap?",   //Leon
        "I remember starting a task, normal, nothing unusual and then the next thing I know, it’s done.",   //Elias
        "You don’t remember doing it?",   //Leon
        "Not clearly, bits of it, maybe, but it feels… off. Like when you wake up and you know you were dreaming but you can’t hold onto it.",   //Elias
        "...",   //Leon
        "It gets stranger, everything was faster. Output, timing, coordination… even the supervisor mentioned it, said productivity was “above expectation”.",   //Elias
        "...",   //Leon
        "I should feel good about that, right?",   //Elias
        "Do you?",   //Leon
        "No... I just feel… tired, like properly drained. I keep telling myself it’s just the adjustment; new implant, long hours, stress…",   //Elias
        "But?",   //Leon
        "But it doesn’t feel like that. It feels like something happened and I wasn’t entirely there for it.",   //Elias

        //Edith conversation
        "Can I ask you something a bit… strange, dear?",   //Edith
        "Yes, go on.",   //Leon
        "Do you think… the more someone is altered, the more they change?",   //Edith
        "In what way?",   //Leon
        "Not physically, that’s obvious. I mean… inside, their feelings, their responses, the way they connect to people. I’ve been wondering if there’s a point where it starts to… dull.",   //Edith
        "Dull?",   //Leon
        "Yes, like everything becomes quieter. Not quite gone, just… muted.",   //Edith
        "That’s hard to say. Why are you asking?",   //Leon
        "Oh, just thinking, old minds tend to wander. I remember when things felt… immediate; love, excitement, even anger, it all had a kind of sharpness to it. And now I wonder if that changes when you start replacing parts of yourself. ",   //Edith
        "...",   //Leon
        "Not that it means it disappears, just… becomes something else. Do you think someone could still feel the same, even after all that?",   //Edith
        "I think… people hold onto what matters.",   //Leon
        "I’d like to believe that. ",   //Edith
        "What?",   //Leon
        "Because otherwise… you’re not just changing the body, are you?",   //Edith
 
        //Kellen conversation
        "Heard something about HC. Factory workers, mandatory implants.",   //Leon
        "Yeah… heard the same, one of them came in the other day.",   //Kellen
        "Have you seen more? Since then I mean.",   //Leon
        "More than I’d like. The issues vary; malfunctions, inconsistencies, things not lining up. And funnily enough, most of them trace back to the same place. ",   //Kellen
        "Harcrow.",   //Leon
        "Yeah... Feels familiar.",   //Kellen
        "How?",   //Leon
        "Same trick companies have been pulling for years, make something just unreliable enough that people come back.",   //Kellen
        "Planned failure.",   //Leon
        "Exactly, only this time it’s not phones or appliances. It’s people. ",   //Kellen
        "...",   //Leon
        "They come in thinking they need an upgrade, a fix, something new and that’s when the real stuff gets put in.",   //Kellen
        "That’s… Dangerous.",   //Leon
        "It’s profitable.",   //Kellen
       
        //MX-2 the maintenance robot conversation
        "Still working?",   //Leon
        "Maintenance cycle ongoing",   //MX-2
        "Same systems?",   //Leon
        "Residential and infrastructure units",   //MX-2
        "…You ever get tired?",   //Leon
        "No fatigue detected",   //MX-2
        "Must be nice",   //Leon
        "Clarification unnecessary",   //MX-2
        "Yeah… figured",   //Leon
    };

    //-------------------------------------------------DAY 18--------------------------------------------------------------
    //Anya's storyline is split into 4 options, until day 20, the last day.
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        "I’ve got an update. I found a way to get the paperwork, it’s not clean, but it’ll work.",   //Leon
        "…You’re serious.",   //Anya
        "I should have everything ready by tomorrow. And listen, once you have them, you go straight through no delays, no second guessing.",   //Leon
        "Yeah",   //Anya
        "And when you get there… don’t just disappear.",   //Leon
        "What do you mean?",   //Anya
        "You said you have proof. So use it, don’t let it die with you. They don’t get to keep doing this.",   //Leon
        "No… they don’t.",   //Anya
        "So expose them, all of it.",   //Leon
        "I will.",   //Anya

        //Option 2: Player DOESN’T HELP Anya get the documents.
        "…Hey",   //Leon
        "...Hey, quiet today.",   //Anya
        "Yeah, you alright?",   //Leon
        "I’ll manage, I always do.",   //Anya
        "...",   //Leon
        "I can take care of myself.",   //Anya
        "…Right",   //Leon
        "Yeah",   //Anya

        //Option 3: Player tells Anya to GO HOME.
        "I’ve been thinking, and you were right about one thing. I don’t have many options left.",   //Anya
        "...",   //Leon
        "And staying here pretending I do isn’t helping. ",   //Anya
        "So what are you going to do?",   //Leon
        "...Go back.",   //Anya
        "Not because I agree with them or because I suddenly trust any of it.",   //Leon
        "Then why?",   //Anya
        "Because if I’m closer to it… I can learn more. This isn’t me giving up, it’s just… changing direction.",   //Leon
        "...",   //Anya
        "If I can get back in, get access again… maybe I can find something bigger.",   //Leon
        "And if they don’t let you?",   //Anya
        "Then at least I tried something different. This isn’t over, not for me.",   //Leon

        //Option 4: Player REPORTS Anya.
        "…Hey",   //Leon
        "...Hey, quiet today.",   //Anya
        "Yeah, you alright?",   //Leon
        "I’ll manage, I always do.",   //Anya
        "...",   //Leon
        "I can take care of myself.",   //Anya
        "…Right",   //Leon
        "Yeah",   //Anya

        //Mara conversation
        "How’s Elias?",   //Leon
        "…Not well. He forgets things mid-sentence, loses track of what he’s doing, and when I ask him about it he brushes it off like it’s nothing. ",   //Mara
        "...",   //Leon
        "But it’s not nothing. He’s present, but not entirely like part of him is somewhere else. And the worst part is that he knew, he knew I didn’t trust it, and he still went through with it without telling me.",   //Mara
        "...",   //Leon
        "We’re supposed to figure things out together, that’s what this is, that’s what we are. And now I’m watching him change in ways I can’t predict, tied to a system I don’t trust, and I can’t do anything about it.",   //Mara
        "...",   //Leon
        "Sometimes I think about leaving, just taking them both somewhere far away from all of this.",   //Mara
        "You could.",   //Leon
        "Could I? The world isn’t built to let you step outside of it that easily... Do you know what’s strange?",   //Mara
        "What?",   //Leon
        "I understand emotions, I can define them, recognise them, respond to them. But moments like this… I wish I didn’t have to think about them. I wish I could just feel them.",   //Mara
        "Go on.",   //Leon
        "Instinctively, without analysing every part of it. Without questioning whether what I’m experiencing is real or constructed.",   //Mara
        "...",   //Leon
        "Sometimes I wish I were human.",   //Mara
        "...",   //Leon
        "Not all the time, just… enough to know what this is supposed to feel like.",   //Mara

        //Edith conversation
        "No, no I don’t want to hear it anymore. I take it back, all of it.",   //Edith
        "What do you mean?",   //Leon
        "That nonsense I said before, about envying them, about wishing things were easier, I don’t mean a word of it.",   //Edith
        "...",   //Leon
        "They don’t make things easier, they take things away. They took my husband from me.",   //Edith
        "...",   //Leon
        "They took my children, and now they expect us to just live with it like it’s normal. ",   //Edith
        "Did something happen?",   //Leon
        "...I was thinking about him this morning, trying to remember what it used to be like. The way he’d look at me, the way we’d talk, dance… just exist without all of this hanging over us. And now…",   //Edith
        "Now?",   //Leon
        "Now it’s different. It’s difficult to look at him sometimes... Because all I can see is what took everything from me. ",   //Edith

        //Kellen conversation
        "Got you something.",   //Leon
        "That so? Alright, let’s see it then.",   //Kellen
        "Found it while I was out. Thought you might like it.",   //Leon
        "…You’re joking. A physical copy? Of a movie?",   //Kellen
        "Yeah.",   //Leon
        "Lad, what am I supposed to do with this? Frame it?",   //Kellen
        "I thought you’d appreciate it",   //Leon
        "I do, doesn’t mean I can use it, this is ancient.",   //Kellen
        "You could find a way.",   //Leon
        "Or I could just watch it online like a normal person.",   //Kellen
        "That defeats the point. It’s… I don’t know, it’s different.",   //Leon
        "It’s outdated. ",   //Kellen
        "It’s tangible.",   //Leon
        "It’s useless. ",   //Kellen
        "You’re keeping it though.",   //Leon
        "Yeah. But don’t get smug, lad. I like the sentiment, not the object.",   //Kellen
        "Sure.",   //Leon
        "... Still… appreciate it",   //Kellen

        //MX-2 the maintenance robot conversation
        "Busy?",   //Leon
        "Maintenance workload increased",   //MX-2
        "Still catching up?",   //Leon
        "Demand remains above baseline",   //MX-2
        "Figures",   //Leon
        "Task priority adjusted accordingly",   //MX-2
        "You ever get a break?",   //Leon
        "Break not required",   //MX-2
        "Yeah… of course not",   //Leon
    };

    //-------------------------------------------------DAY 19--------------------------------------------------------------
    //Anya's storyline is split into 4 options, until day 20, the last day.
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        "I’ve got them.",   //Leon
        "…You actually did it. Let me see.",   //Anya
        "Everything’s there. Identity records, clearance tags, cross-check passes… it should hold.",   //Leon
        "…This is more than I expected",   //Anya
        "It needs to be convincing, they’ve been tightening checks. Anya, listen...",   //Leon
        "...",   //Anya
        "They might ask where you’re coming from, keep it simple. Don’t overexplain, don’t fill silence, just answer what they ask.",   //Leon
        "Okay",   //Anya
        "If they question the timing, say you’ve been relocated, don’t hesitate when you say it. And if something feels off, don’t push it. Walk away and try again later.",   //Leon
        "Once you’re through, don’t stay anywhere obvious, lay low until you’re sure you’re clear.",   //Anya
        "It needs to be convincing, they’ve been tightening checks. Anya, listen...",   //Leon
        "Got it.",   //Anya
        "And the implant—",   //Leon
        "First thing I deal with.",   //Anya
        "You ready for this?",   //Leon
        "As I’ll ever be... Thank you. You didn’t have to help me.",   //Anya
        "I wanted to.",   //Leon
        "Take care of yourself... And don’t let them get away with it here either.",   //Anya
        "I won’t.",   //Leon

        //Option 2: Player DOESN’T HELP Anya get the documents.
        "... I’m leaving today. Wasn’t really planning to tell you like this but didn’t seem like there was a better way.",   //Anya
        "...",   //Leon
        "It’s strange...",   //Anya
        "What is?",   //Leon
        "I thought we were getting somewhere. Not even about all of this, just… talking.",   //Anya
        "We were.",   //Leon
        "Were we? Because it doesn’t feel like that anymore. I think I made a mistake...",   //Anya
        "What kind?",   //Leon
        "Trusting someone in your position. That’s on me though.",   //Anya
        "Anya—",   //Leon
        "Anyway, I should go. Take care of yourself.",   //Anya
        "You too.",   //Leon

        //Option 3: Player tells Anya to GO HOME.
        "So… today’s the day. You sure about this?",   //Leon
        "No... Doesn’t mean I’m not doing it. Maybe this is the only way I get close enough to actually do something.",   //Anya
        "It’s risky.",   //Leon
        "So is everything else. At least this way I’m not running blindly. And I just wanted to say… thanks.",   //Anya
        "For what?",   //Leon
        "For talking to me, even when I didn’t make it easy. Maybe we can still keep in touch somehow.",   //Anya
        "I’d like that.",   //Leon
        "Me too.",   //Anya

        //Option 4: Player REPORTS Anya. No interaction this day.

        //Elias conversation
        "Any more… gaps?",   //Leon
        "Yeah... but worse.",   //Elias
        "How so?",   //Leon
        "Longer this time and not just me. People at work, they started talking about it properly today.",   //Elias
        "What are they saying?",   //Leon
        "Same thing I am; missing time, increased output, feeling like something’s off. And the more we talk about it, the louder it gets.",   //Elias
        "That’s not going to sit well.",   //Leon
        "It doesn’t, management’s already stepping in. They are warning people, threatening cuts, termination… anything to shut it down. Which just makes it worse... Feels like something’s building.",   //Elias
        "You think it’ll escalate?",   //Leon
        "Yeah, I do. I spoke to Kellen, about removal. Just… options, nothing concrete.",   //Elias
        "And Mara?",   //Leon
        "We talked, about leaving. I don’t want my kid growing up in this, whatever this is becoming. Thought about going somewhere quiet, starting over, something simple.",   //Elias
        "Like what?",   //Leon
        "I don’t know… farming.",   //Elias
        "That’s a big shift.",   //Leon
        "So is all of this.",   //Elias
        "...Like what?",   //Leon
        "You’re welcome to come with us, you know.",   //Elias
        "Me?",   //Leon
        "Yeah, get out before it gets worse. I’m only half joking.",   //Elias
        "Only half?",   //Leon
        "Other half’s serious.",   //Elias

        //Edith conversation
        "Can I ask you something?",   //Leon
        "You always do, dear.",   //Edith
        "The other day… what you said about your husband. He’s augmented, isn’t he.",   //Leon
        "…Yes, heavily? There wasn’t much choice, it was that or lose him.",   //Edith
        "...",   //Leon
        "And I wasn’t going to let that happen, not after everything else.",   //Edith
        "You don’t talk about him much, why?",   //Leon
        "Because people look at him differently. ",   //Edith
        "Do they?",   //Leon
        "Maybe not anymore, but I still see it.  Or maybe I imagine it.",   //Edith
        "Are you ashamed of it?",   //Leon
        "No, never that. I’ve been trying to protect him.",   //Edith
        "From what?",   //Leon
        "From all of this, from them. That’s why I keep things the way I do, why I don’t like those machines coming near.",   //Edith
        "Like MX-2? You think it’ll harm him?",   //Leon
        "No… not directly, but it’s all part of the same thing, isn’t it. ",   //Edith
        "...",   //Leon
        "Still, you might be right. Keeping him hidden, it’s not really living, is it? He’s still here, maybe I’ve been holding onto fear more than I should.",   //Edith

        //Kellen conversation
        "Oi, lad. Got something for you.",   //Kellen
        "That’s new. Let’s see then.",   //Leon
        "Here.",   //Kellen
        "…What is it?",   //Leon
        "Small data chip, old format, but I modified it. It’ll run through most immersive rigs; VR, neural feed, whatever you’ve got access to.",   //Kellen
        "What’s on it? A film?",   //Leon
        "Not just a film, full sensory version. One of my favourites. Visual, audio, environmental feedback, you’ll feel like you’re standing in it.",   //Kellen
        "That’s… actually incredible.",   //Leon
        "Don’t sound so surprised.",   //Kellen
        "I just didn’t expect this from you.",   //Leon
        "Yeah well... You’ve been coming around talking, not treating me like some problem. While most people don’t see it that way.",   //Kellen
        "Their loss. And thank you.",   //Leon
        "Don’t get sentimental on me, just watch it, yeah? And don’t come back telling me it’s overrated.",   //Kellen
        "No promises.",   //Leon
        "Knew I shouldn’t have given it to you.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Still at it?",   //Leon
        "Maintenance tasks ongoing",   //MX-2
        "Anything different today?",   //Leon
        "Increased system strain detected across multiple units",   //MX-2
        "Sounds about right",   //Leon
        "Adjustments in progress",   //MX-2
        "Good luck with that",   //Leon
        "Acknowledged",   //MX-2
    };

    //-------------------------------------------------DAY 20 LAST DAY--------------------------------------------------------------
    public static readonly string[] Dialogue = new string[] 
    {
        //Anya conversation (message from her, probs not done in the dialogue)
        //Option 1: Player HELPS Anya get the documents.
        "Made it through. No issues, your documents held up better than expected",   //Anya
        "Implant’s getting handled tomorrow, finally",   //Anya
        "...",   //Anya
        "Visit me sometime ;)",   //Anya

        //Option 2: Player DOESN’T HELP Anya get the documents. Does not receive any message.

        //Option 3: Player tells Anya to GO HOME.
        "I’m back",   //Anya
        "Everything feels the same, but not really",   //Anya
        "...",   //Anya
        "I can’t say much",   //Anya
        "Just… wanted you to know I’m alright",   //Anya
        "You’ll see me again",   //Anya

        //Option 4: Player REPORTS Anya. No interaction this day. Does not receive any message.

        //Mara conversation
        "Heard you’re leaving.",   //Leon
        "We are. It won’t be easy, starting over rarely is. But we’ll be together and right now that feels like the only thing that matters.",   //Mara
        "That’s enough.",   //Leon
        "I think so too. Thank you, Leon, for listening, for being… steady through all of this.",   //Mara
        "You don’t have to thank me. I hope it works out for you.",   //Leon
        "So do I.",   //Mara

        //Elias conversation
        "How are you feeling?",   //Leon
        "Like I’ve been hit by a truck. But I feel… clearer, if that makes sense. Kellen did what he could. Wasn’t pretty, but it’s out.",   //Elias
        "That’s what matters. Also, heard you’re leaving.",   //Leon
        "Yeah... Feels like the only real option left. I want something different for my kid.",   //Elias
        "You’ll find it.",   //Leon
        "I hope so... We’ll keep in touch, yeah?",   //Elias
        "Yeah, Good luck, Elias. ",   //Leon
        "You too, mate.",   //Elias

        //Edith conversation
        "I took him out today. We went to the park, just for a walk.",   //Edith
        "How was it?",   //Leon
        "…Lovely. It felt… normal, in a way I hadn’t allowed myself to feel in a long time. And it made me realise something rather uncomfortable.",   //Edith
        "What’s that?",   //Leon
        "I’ve been hiding him, not from the world, but from myself. All this time I’ve been saying I hate what these machines have done, and yet… I let that feeling spill over onto him.",   //Edith
        "That’s not easy to admit.",   //Leon
        "No, it isn’t. I love him, that hasn’t changed, no matter what he is now.",   //Edith
        "And that’s what matters. Maybe I could join you sometime, on your walk.",   //Leon
        "I’d like that, dear.",   //Edith

        //Kellen conversation
        "Heard you helped Elias. How’d it go?",   //Leon
        "Messy, but it’s done.",   //Kellen
        "You think it was the right call?",   //Leon
        "Yeah, getting out while you still can… not the worst idea. Anyway...  You still owe me a proper film opinion on that chip.",   //Kellen
        "I do.",   //Leon
        "So we’re doing that.",   //Kellen
        "Watching it together?",   //Leon
        "Don’t make it sound sentimental.",   //Kellen
        "It is... When?",   //Leon
        "Soon.",   //Kellen
        "I’ll be there.",   //Leon
        "Yeah, you will.",   //Kellen

        //MX-2 the maintenance robot conversation
        "Transfer scheduled",   //MX-2
        "Transfer?",   //Leon
        "Unit reassignment effective tomorrow",   //MX-2
        "...So this is your last day here? You will be missed, buddy.",   //Leon
        "Acknowledged",   //MX-2
        "That’s it?",   //Leon
        "... You as well… buddy",   //MX-2
        "Oh... Didn’t expect that",   //Leon
        "Response logged",   //MX-2
    };
}
