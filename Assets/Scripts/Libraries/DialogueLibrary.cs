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
    public static readonly string[] RobotPurposeRobotic = new string[]
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
    public static readonly string[] RobotPurposeDisguised = new string[]
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
        public static readonly DialogueLine[] Day1Dialogue = new DialogueLine[]
    {
        // Anya
            new DialogueLine("Anya",  "*coughs*"),
            new DialogueLine("Leon",  "You alright?"),
            new DialogueLine("Anya",  "Fine. *coughs again*"),
            new DialogueLine("Leon",  "Doesn't sound like it."),
            new DialogueLine("Anya",  "Then don't listen."),
            new DialogueLine("Leon",  "Right... There's a clinic two streets over."),
            new DialogueLine("Anya",  "I'm not from here."),
            new DialogueLine("Leon",  "It's not restricted."),
            new DialogueLine("Anya",  "…That supposed to help?"),
            new DialogueLine("Leon",  "Just saying you could go."),
            new DialogueLine("Anya",  "I'm good."),
            new DialogueLine("Leon",  "Doesn't sound like it."),
            new DialogueLine("Anya",  "You always repeat yourself?"),
            new DialogueLine("Leon",  "Only when people ignore me."),
            new DialogueLine("Anya",  "Maybe take the hint."),
            new DialogueLine("Leon",  "...Alright."),
            new DialogueLine("Anya",  "And stop looking at me like that."),
            new DialogueLine("Leon",  "Like what?"),
            new DialogueLine("Anya",  "Like I'm your problem."),

        //Elias conversation
        new DialogueLine("Leon", "Hello, I just moved here recently."),
        new DialogueLine("Elias", "Yeah, I thought so. Haven’t seen you around before... Welcome by the way, I’m Elias."),
        new DialogueLine("Leon", "Thanks, I’m Leon."),
        new DialogueLine("Elias", "This place does take a bit of getting used to. People don’t really… introduce themselves here."),
        new DialogueLine("Leon", "I’m starting to notice that."),
        new DialogueLine("Elias", "Don’t take it personally. It’s just how things are lately."),
        new DialogueLine("Leon", "What’s it like living here?"),
        new DialogueLine("Elias", "Quiet, mostly. Kids used to play out more, but... people keep things closer now."),
        new DialogueLine("Leon", "Because of the checkpoint?"),
        new DialogueLine("Elias", "That’s part of it. When you’ve got eyes on the street all the time, people start acting different."),
        new DialogueLine("Leon", "Sounds a bit tense."),
        new DialogueLine("Elias", "It can be. But it’s still home."),
        new DialogueLine("Leon", "You’ve lived here long?"),
        new DialogueLine("Elias", "Yeah, long enough to remember when it wasn’t like this... Long enough to know it’s better not to stand out too much. Anyway Kid, you’ll be fine. Just keep your head down, be polite. That goes a long way around here."),
        new DialogueLine("Leon", "Alright thanks, I’ll keep that in mind."),
        
        //Edith conversation
        new DialogueLine("Leon", "Hello, I just moved here, I’m Leon."),
        new DialogueLine("Edith", "Oh! Well about time they sent someone over."),
        new DialogueLine("Leon", "Send someone over?"),
        new DialogueLine("Edith", "You. Don’t play dumb dear, I see the uniform."),
        new DialogueLine("Leon", "Right…"),
        new DialogueLine("Edith", "Makes a difference, you know. People sleep better when there’s someone keeping an eye on things."),
        new DialogueLine("Leon", "..."),
        new DialogueLine("Edith", "You’ll want to keep your door locked. Not that it used to be like that we never locked doors, not years ago. Left the key in sometimes, can you imagine? Different times."),
        new DialogueLine("Leon", "What changed?"),
        new DialogueLine("Edith", "Oh, everything dear. All these… upgrades. I’ll tell you people are fiddling with things they shouldn’t. Unnatural that is. "),
        new DialogueLine("Leon", "You mean augments?"),
        new DialogueLine("Edith", "I mean them. Machines walking about like they’re people. Smiling at you, talking like you and believe me, I don’t buy any of it."),   //Edith
        new DialogueLine("Leon", "Some of them are just—"),   //Leon
        new DialogueLine("Edith", "Oh I’ve heard it all before.“They help people.” “They make life easier.” “My neighbour’s got one and it’s perfectly safe.” That’s what they said about the one down the road. Worked fine for years, then one day it’s shouting in the street like it’s lost its mind. Whole block heard it."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And the papers, don’t get me started on the papers. “Minor malfunction,” they called it. Minor! If that’s minor I’d hate to see what major looks like."),   //Edith
        new DialogueLine("Leon", "I guess things go wrong sometimes."),   //Leon
        new DialogueLine("Edith", "Oh Dear, you have not lived long enough to understand. That’s what they all say. Always a reason, always an excuse. Next thing you know you can’t tell what’s what anymore."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Robots, augments. It’s all the same in the end. Something pretending to be what it’s not. And you mark my words sweetheart, nothing good comes from it. "),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Oh, listen to me rambling on again. Happens when you get to my age. No one to tell you to stop talking, eh?"),   //Edith
        new DialogueLine("Leon", "I don’t mind."),   //Leon
        new DialogueLine("Edith", "Anyway, have you met any other residents yet?"),   //Edith
        new DialogueLine("Leon", "A couple."),   //Leon
        new DialogueLine("Edith", "Edith! Edith!"),   //An individuals voice coming from inside the house
        new DialogueLine("Edith", "Alright, keep your wits about you, Dear. Not everyone’s as they seem."),   //Edith
        new DialogueLine("Leon", "I’ll keep that in mind."),   //Leon

        //Kellen conversation
        new DialogueLine("Leon", "Hello."),   //Leon
        new DialogueLine("Kellen", "..."),   //Kellen
        new DialogueLine("Leon", "What is this place?"),   //Leon
        new DialogueLine("Kellen", "Listen lad, wherever you came from, maybe people let you walk around asking questions. Not here."),   //Kellen
        new DialogueLine("Leon", "I was just—"),   //Leon
        new DialogueLine("Kellen", "Didn’t ask what you were doing. I’m telling you to stop."),   //Kellen
        new DialogueLine("Leon", "Alright, no need to—"),   //Leon
        new DialogueLine("Kellen", "There is. You’re standing in the wrong place, asking the wrong things... wearing that."),   //Kellen
        new DialogueLine("Leon", "I’m not here to cause problems."),   //Leon
        new DialogueLine("Kellen", "That uniform is a problem."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "So do yourself a favour and turn around, walk back the way you came, and don’t wander down here again."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "We clear?"),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Hello."),   //Leon
        new DialogueLine("MX-2", "Maintenance unit active. Please keep clear of the work area."),   //MX-2
        new DialogueLine("Leon", "Right… I was just wondering what you’re working on."),   //Leon
        new DialogueLine("MX-2", "Surface panel degradation detected. Repair in progress."),   //MX-2
        new DialogueLine("Leon", "Do you handle this whole area?"),   //Leon
        new DialogueLine("MX-2", "Assigned zone: Sector 3. Tasks include maintenance, delivery, and structural upkeep."),   //MX-2
        new DialogueLine("Leon", "Sounds like a lot."),   //Leon
        new DialogueLine("MX-2", "Workload within acceptable parameters."),   //MX-2
        new DialogueLine("Leon", "Do you ever stop?"),   //Leon
        new DialogueLine("MX-2", "Rest cycles are not required."),   //MX-2
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("MX-2", "Please maintain distance. Obstruction will delay completion time."),   //MX-2
        new DialogueLine("Leon", "I’m not in the way."),   //Leon
        new DialogueLine("MX-2", "Proximity threshold exceeded."),   //MX-2
        new DialogueLine("Leon", "Alright, I’ll move.")   //Leon

    };

    //-------------------------------------------------DAY 2--------------------------------------------------------------
    public static readonly DialogueLine[] Day2Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        new DialogueLine("Leon", "Hey… you’re still out here."),   //Leon
        new DialogueLine("Anya", "And you’re still talking to me."),   //Anya
        new DialogueLine("Leon", "You don’t look any better."),   //Leon
        new DialogueLine("Anya", "I don’t remember asking for an update."),   //Anya
        new DialogueLine("Leon", "It’s hard not to notice."),   //Leon
        new DialogueLine("Anya", "Then stop trying."),   //Anya
        new DialogueLine("Leon", "Look whatever’s going on, you don’t have to deal with it on your own."),   //Leon
        new DialogueLine("Anya", "That’s exactly how you deal with it."),   //Anya
        new DialogueLine("Leon", "…Right."),   //Leon
        new DialogueLine("Anya", "You don’t know me. So don’t act like you do."),   //Anya
        new DialogueLine("Leon", "I was only trying to help."),   //Leon
        new DialogueLine("Anya", "I don’t need help."),   //Anya
        new DialogueLine("Leon", "Alright..."),   //Leon

       //Mara conversation
       new DialogueLine("Leon", "Excuse me, do you know when this stall closes?"),   //Leon
       new DialogueLine("Mara", "Soon, it usually closes late."),   //Mara
       new DialogueLine("Leon", "Right. I thought maybe you worked here."),   //Leon
       new DialogueLine("Mara", "Oh, no... Although I do get that sometimes."),   //Mara
       new DialogueLine("Leon", "Sorry, I didn’t mean—"),   //Leon
       new DialogueLine("Mara", "It’s alright. I’m just picking things up for my family."),   //Mara
       new DialogueLine("Leon", "You live nearby?"),   //Leon
       new DialogueLine("Mara", "Just down the street. My husband, Elias, and I moved here a while ago."),   //Mara
       new DialogueLine("Leon", "Elias, I met him briefly yesterday."),   //Leon
       new DialogueLine("Mara", "You did, did you? He did mention that someone new had arrived. It’s nice, having new people around."),   //Mara
       new DialogueLine("Leon", "Most people don’t seem to think so."),   //Leon
       new DialogueLine("Mara", "People take time, they like things to stay the same."),   //Mara
       new DialogueLine("Leon", "And you don’t?"),   //Leon
       new DialogueLine("Mara", "I like what I have, that’s enough for me... I didn’t catch your name."),   //Mara
       new DialogueLine("Leon", "Leon."),   //Leon
       new DialogueLine("Mara", "It was nice to meet you Leon. And you’ll get used to it here, It’s not as unkind as it first feels."),   //Mara

        //Edith conversation
        new DialogueLine("Leon", "Hello again."),   //Leon
        new DialogueLine("Edith", "Oh, Dear it’s you. Good, maybe someone can finally do something useful around here."),   //Edith
        new DialogueLine("Leon", "What happened?"),   //Leon
        new DialogueLine("Edith", "That thing strolling about like it owns the place. Nearly took my foot off this morning."),   //Edith
        new DialogueLine("Leon", "The maintenance unit?"),   //Leon
        new DialogueLine("Edith", "Whatever it calls itself. Useless, that’s what it is."),   //Edith
        new DialogueLine("Leon", "I thought it just did maintenance."),   //Leon
        new DialogueLine("Edith", "Badly. All noise, no sense. Buzzing around, stopping in the middle of the road like it’s thinking, as if it could."),   //Edith
        new DialogueLine("Leon", "He’s just doing his job."),   //Leon
        new DialogueLine("Edith", "He? Oh sweetheart I was hoping you weren’t like the others, I am disappointed. "),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Nevertheless, I’m telling you, they shouldn’t be left to their own devices. Something’s going to go wrong one day."),   //Edith
        new DialogueLine("Leon", "Mhm, have a good evening Edith. "),   //Leon
        new DialogueLine("Edith", "Yes, yes goodbye Dear."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "You again."),   //Kellen
        new DialogueLine("Leon", "Just passing through."),   //Leon
        new DialogueLine("Kellen", "Then pass quicker."),   //Kellen
        new DialogueLine("Leon", "Didn’t mean to interrupt."),   //Leon
        new DialogueLine("Kellen", "If you don’t need anything done, then move along and don’t come down here. I’ve got people waiting."),   //Kellen
        new DialogueLine("Leon", "Right..."),   //Leon
        new DialogueLine("Kellen", "And stop looking like you’re figuring things out. Nothing down here concerns you."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "You’re working on something new today."),   //Leon
        new DialogueLine("MX-2", "Drainage obstruction detected. Clearing in progress. Debris accumulation exceeds expected levels. Task priority increased."),   //MX-2
        new DialogueLine("Leon", "Do you ever fall behind?"),   //Leon
        new DialogueLine("MX-2", "Delays are corrected through extended operation time."),   //MX-2
        new DialogueLine("Leon", "So you just keep going."),   //Leon
        new DialogueLine("MX-2", "Affirmative."),   //MX-2
        new DialogueLine("Leon", "Please maintain distance. Hazard risk elevated.")   //Leon

    };

    //-------------------------------------------------DAY 3--------------------------------------------------------------
    public static readonly DialogueLine[] Day3Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        new DialogueLine("Leon", "Hey… I’ll stop trying to fix things. Wasn’t doing a great job of it anyway."),   //Leon
        new DialogueLine("Anya", "No, you weren’t."),   //Anya
        new DialogueLine("Leon", "Thought I’d try something else instead. I’m Leon."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "You don’t have to tell me. Just feels strange talking like this without a name."),   //Leon
        new DialogueLine("Anya", "You talk a lot."),   //Anya
        new DialogueLine("Leon", "Only when people don’t give me much to work with."),   //Leon
        new DialogueLine("Anya", "...Anya."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Don’t test your luck, just Anya."),   //Anya
        new DialogueLine("Leon", "You always this friendly with people?"),   //Leon
        new DialogueLine("Anya", "Only the ones that keep coming back."),   //Anya
        new DialogueLine("Leon", "Guess I’ve earned that, then."),   //Leon
        new DialogueLine("Anya", "Maybe."),   //Anya
        new DialogueLine("Leon", "I’ll take it."),   //Leon

       //Elias conversation
        new DialogueLine("Leon", "Hey. Good to see you again."),   //Leon
        new DialogueLine("Elias", "Hey Leon, you too. Settling in alright?"),   //Elias
        new DialogueLine("Leon", "Getting there. You and Mara have been the easiest to talk to so far."),   //Leon
        new DialogueLine("Elias", "That’s good to hear, not everyone makes it easy. Anyway, had to pick something up earlier, a replacement unit. Old one started acting up again."),   //Elias
        new DialogueLine("Leon", "From where?"),   //Leon
        new DialogueLine("Elias", "Harcrow. Same place everything comes from these days. They manufacture, supply, maintain pretty much anything. Almost everything that runs in this city has their name on it."),   //Elias
        new DialogueLine("Leon", "Interesting, didn’t realise it was that much."),   //Leon
        new DialogueLine("Elias", "Most people don’t, at first. Then you start noticing the logos, ads, billboards, you name it."),   //Elias
        new DialogueLine("Leon", "Is that a problem?"),   //Leon
        new DialogueLine("Elias", "Depends who you ask... For some people, it’s the only reason things keep working."),   //Elias
        new DialogueLine("Leon", "And for others?"),   //Leon
        new DialogueLine("Elias", "They’d rather not rely on it at all. Anyway lad, I’ll see you around."),   //Elias

        //Edith conversation
        new DialogueLine("Leon", "Hello Edith, have you ever heard of Harcrow Corporations?"),   //Leon
        new DialogueLine("Edith", "Heard of them? Oh sweetheart, they won’t leave me alone."),   //Edith
        new DialogueLine("Leon", "What do you mean?"),   //Leon
        new DialogueLine("Edith", "Letters, pamphlets, little offers through the door, “support for your age group,” they say. Discounts on implants, upgrades, replacements. Like I asked for any of it."),   //Edith
        new DialogueLine("Leon", "Sounds like they’re pushing it hard."),   //Leon
        new DialogueLine("Edith", "Pushing? They’re desperate! Trying to get people like me signed up before we know what we’re agreeing to."),   //Edith
        new DialogueLine("Leon", "You don’t trust it."),   //Leon
        new DialogueLine("Edith", "Of course I don’t trust it. It’s all a sham! Dress it up nicely, make it sound safe, and next thing you know they’ve got their hands in everything."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "They run the whole place, whether people admit it or not. I wouldn’t trust a single device made by them Dear."),   //Edith
        new DialogueLine("Leon", "...Right."),   //Leon
        new DialogueLine("Edith", "You know, I’m surprised you don’t know that, sweetheart. I’d imagine they supply half of what you lot use over there at work."),   //Edith
        new DialogueLine("Edith", "Edith, who are you talking to?"),   //An individuals voice coming from inside the house
        new DialogueLine("Edith", "I’ll see you later Dear."),   //Edith
      
        //Kellen conversation
        new DialogueLine("Leon", "We need to talk."),   //Leon
        new DialogueLine("Kellen", "No, we don’t."),   //Kellen
        new DialogueLine("Leon", "Yeah, we do. Because I’m getting real tired of being told to get lost every time I walk past."),   //Leon
        new DialogueLine("Kellen", "Then stop walking past."),   //Kellen
        new DialogueLine("Leon", "...I know exactly what kind of place this is."),   //Leon
        new DialogueLine("Kellen", "You don’t know anything."),   //Kellen
        new DialogueLine("Leon", "I know enough. And if I’d said something by now, you wouldn’t still be standing here."),   //Leon
        new DialogueLine("Kellen", "..."),   //Kellen
        new DialogueLine("Leon", "At the end of the day I’m still the one wearing a uniform. So maybe drop the attitude. I’m not here to shut you down."),   //Leon
        new DialogueLine("Kellen", "Then what are you here for?"),   //Kellen
        new DialogueLine("Leon", "Same as everyone else. Trying to get through the day without making it worse for anyone."),   //Leon
        new DialogueLine("Kellen", "The man in the uniform does have some balls after all. I can keep it civil, as long as you stay in your lane, and I stay in mine."),   //Kellen
        new DialogueLine("Leon", "...Leon."),   //Leon
        new DialogueLine("Kellen", "I didn’t ask for your name, lad. I see no point in names, and I will not be giving you mine."),   //Kellen
        new DialogueLine("Leon", "Alright, I’ll see you later Kellen."),   //Leon
        new DialogueLine("Kellen", "..."),   //Kellen
        
        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "That woman, Edith. She gives you a hard time."),   //Leon
        new DialogueLine("MX-2", "Verbal hostility from resident “Edith” recorded. Frequency: HIGH."),   //MX-2
        new DialogueLine("Leon", "You notice that?"),   //Leon
        new DialogueLine("MX-2", "All interactions are logged."),   //MX-2
        new DialogueLine("Leon", "Does it affect your work?"),   //Leon
        new DialogueLine("MX-2", "Task completion remains within acceptable parameters."),   //MX-2
        new DialogueLine("Leon", "So it doesn’t bother you."),   //Leon
        new DialogueLine("MX-2", "“Bother” is not a recognised operational state. Similar behaviour observed across multiple residents. Interaction pattern classified as normal."),   //MX-2
        new DialogueLine("Leon", "Normal?"),   //Leon
        new DialogueLine("MX-2", "Affirmative. Please maintain distance. Task in progress.")   //MX-2

    };

    //-------------------------------------------------DAY 4--------------------------------------------------------------
    //the day before (day 3) the player makes a choice whether they let through a medically dependend person through, but their firmware is slightly out of date, this affects the dialogue.
    public static readonly new DialogueLine[] Day4Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Anya", "You came back."),   //Anya
        new DialogueLine("Leon", "Starting to sound like a routine."),   //Leon
        new DialogueLine("Anya", "...Word travels fast around here."),   //Anya
        new DialogueLine("Leon", "Yeah, I’ve noticed."),   //Leon
        new DialogueLine("Anya", "Someone got turned away yesterday. Medical clearance flagged, paperwork not lining up."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Happens more than people think. Things expire, systems update, suddenly you’re not… valid anymore..."),   //Anya
        new DialogueLine("Leon", "That’s rough."),   //Leon
        new DialogueLine("Anya", "It’s worse than that. On the other side, they fix things properly. You don’t have to keep proving you deserve to be okay."),   //Anya
        new DialogueLine("Leon", "Sounds like you’ve thought about it."),   //Leon
        new DialogueLine("Anya", "…Maybe."),   //Anya
        new DialogueLine("Leon", "You trying to get there?"),   //Leon
        new DialogueLine("Anya", "Wouldn’t you?"),   //Anya
        new DialogueLine("Leon", "Depends what’s waiting."),   //Leon
        new DialogueLine("Anya", "Healthcare that actually works sounds like a good start. Some people don’t have time to wait for things to get worse."),   //Anya
        new DialogueLine("Leon", "Yeah."),   //Leon

        //Elias conversation
        new DialogueLine("Elias", "Hey. You look tired."),   //Elias
        new DialogueLine("Leon", "Yeah… long shift."),   //Leon
        new DialogueLine("Leon", "Hope you don’t mind me asking, where do you work?"),   //Leon
        new DialogueLine("Elias", "Harcrow Factory Line, Assembly and maintenance. Same place most people end up if they stick around long enough."),   //Elias
        new DialogueLine("Leon", "Sounds intense."),   //Leon
        new DialogueLine("Elias", "It is, lad. They’ve got systems for everything; timed output, monitored breaks, performance tracking. You fall behind, it shows immediately."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "They say they offer “support,” though. It’s just various augments and implants designed for the job. To help you keep up, work longer, push a bit further each time."),   //Elias
        new DialogueLine("Leon", "Do people take them?"),   //Leon
        new DialogueLine("Elias", "I’ve managed without so far... But it’s getting harder. You start thinking about it differently when you’ve got people relying on you. It’s not just about what you’re comfortable with anymore."),   //Elias
        new DialogueLine("Leon", "Your family."),   //Leon
        new DialogueLine("Elias", "Exactly. You just… keep going. However you can."),   //Elias

        //Edith conversation
        new DialogueLine("Leon", "Hey, Edith. I’ve been meaning to ask you something."),   //Leon
        new DialogueLine("Edith", "Of course Dear, but if it’s about those machines again, I’ve already told you everything I know."),   //Edith
        new DialogueLine("Leon", "No, it’s just that... the other day, someone called out from inside."),   //Leon
        new DialogueLine("Edith", "…Did they?"),   //Edith
        new DialogueLine("Leon", "Yeah. Just making sure everything’s alright. Part of the job."),   //Leon
        new DialogueLine("Edith", "Everything’s fine."),   //Edith
        new DialogueLine("Leon", "You live with someone?"),   //Leon
        new DialogueLine("Edith", "I said everything’s fine. You don’t need to concern yourself with what goes on in my house."),   //Edith
        new DialogueLine("Leon", "...Alright."),   //Leon
        new DialogueLine("Edith", "…It’s my husband... He’s not well. That’s all you need to know."),   //Edith
        new DialogueLine("Leon", "I apologise if I over stepped, Edith."),   //Leon
        new DialogueLine("Edith", "People get sick, you know. Not everything’s your business to go poking into."),   //Edith

        //Kellen conversation
        //Option 1: Player LETS the medical individual through.
        new DialogueLine("Kellen", "…Word is someone got through yesterday."),   //Kellen
        new DialogueLine("Leon", "Yeah."),   //Leon
        new DialogueLine("Kellen", "Doesn’t happen often."),   //Kellen
        new DialogueLine("Leon", "No, it doesn’t."),   //Leon
        new DialogueLine("Kellen", "People like that… they don’t have many options. Things start failing, systems flag them, and suddenly they’re stuck."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "So they come down here. Take whatever they can get. Beg me for cheap work, bad parts, debts they can’t pay back... And once you’re in it, you don’t get out."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "It not only hurts them, but their families also. And the guilt I feel, being responsible for them, if anything goes wrong..."),   //Kellen
        new DialogueLine("Leon", "These things are never easy for anyone."),   //Leon
        new DialogueLine("Kellen", "No. But things like this matter more than you may think. Gives people like myself, and others here, a sense of hope."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "That there are some alright people among ones like yourself."),   //Kellen

        //Option 2: Player DOES NOT let the medical individual through.
        new DialogueLine("Kellen", "…Word is someone got turned away yesterday."),   //Kellen
        new DialogueLine("Leon", "Yeah."),   //Leon
        new DialogueLine("Kellen", "That’s how it usually goes."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "People like that… they don’t have many options. Things start failing, systems flag them, and suddenly they’re stuck, waiting on approvals that never come through."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "So they end up down here anyway. Not because they want to, but because there’s nowhere else left to go. They take whatever they can get, even if it barely holds together, even if it puts them deeper into something they won’t be able to climb out of."),   //Kellen
        new DialogueLine("Leon", "It’s not an easy situation."),   //Leon
        new DialogueLine("Kellen", "No, it’s not. And for a second there, I thought maybe things were shifting… that maybe someone up there had the sense to let things slide when it actually mattered."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Guess I was wrong. System stays the same, people like me deal with the fallout, and people like you keep telling themselves it’s just the way things are."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Doesn’t matter. It is what it is."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Didn’t expect to see you out here."),   //Leon
        new DialogueLine("MX-2", "Ground maintenance in progress. Surface irregularities detected."),   //MX-2
        new DialogueLine("Leon", "This place looks different when it’s quiet."),   //Leon
        new DialogueLine("MX-2", "Environmental state: stable."),   //MX-2
        new DialogueLine("Leon", "Do you ever… notice it? Like how it looks?"),   //Leon
        new DialogueLine("MX-2", "Clarify."),   //MX-2
        new DialogueLine("Leon", "The park. The trees, the space… some people would call it beautiful."),   //Leon
        new DialogueLine("MX-2", "“Beautiful” not required for task completion."),   //MX-2
        new DialogueLine("Leon", "Yeah, I figured you’d say that."),   //Leon
        new DialogueLine("MX-2", "Definition requested."),   //MX-2
        new DialogueLine("Leon", "It’s… something that makes things feel… better, I guess."),   //Leon
        new DialogueLine("MX-2", "Processing… No functional value detected." ),  //MX-2
        new DialogueLine("Leon", "Fair enough.")   //Leon
    };

    //-------------------------------------------------DAY 5--------------------------------------------------------------
    public static readonly  DialogueLine[] Day5Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Leon", "You said the other day that you were thinking about leaving… getting to the other side for treatment. I’ve been wondering what makes someone walk away from everything they’ve got just for a chance at that."),   //Leon
        new DialogueLine("Anya", "That’s a very polite way of asking what’s wrong with me."),   //Anya
        new DialogueLine("Leon", "I’m trying to improve."),   //Leon
        new DialogueLine("Anya", "You’re trying something, I’ll give you that."),   //Anya
        new DialogueLine("Leon", "So… what’s waiting for you over there? Something or someone?"),   //Leon
        new DialogueLine("Anya", "No. Family’s not part of the equation."),   //Anya
        new DialogueLine("Leon", "Not close?"),   //Leon
        new DialogueLine("Anya", "Dead to me. Take that however you want."),   //Anya
        new DialogueLine("Leon", "…Alright."),   //Leon
        new DialogueLine("Anya", "You know what’s interesting, though?"),   //Anya
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("Anya", "You showed up out of nowhere, started talking to everyone like you’re trying to map the place out, and somehow you still haven’t said a single thing about yourself."),   //Anya
        new DialogueLine("Leon", "Maybe I’m just a good listener."),   //Leon
        new DialogueLine("Anya", "No. You’re something else. You walk around in that uniform, everyone assumes you’re with the government, but you don’t act like the others. You don’t push, you don’t threaten, and for some reason you haven’t even tried to shut Kellen down."),   //Anya
        new DialogueLine("Leon", "Observant."),   //Leon
        new DialogueLine("Anya", "I have to be."),   //Anya
        new DialogueLine("Leon", "I can tell Kellen runs that part of the neighbourhood without him needing to say it. And if something like that is sitting out in the open the way it is, then it’s not being ignored, it’s being allowed."),   //Leon
        new DialogueLine("Anya", "So you’re just… playing along?"),   //Anya
        new DialogueLine("Leon", "I’m choosing what not to make worse."),   //Leon
        new DialogueLine("Anya", "That’s a dangerous way to think."),   //Anya
        new DialogueLine("Leon", "Maybe."),   //Leon
        new DialogueLine("Anya", "...You’re not what I expected."),   //Anya
        new DialogueLine("Leon", "Disappointed?"),   //Leon
        new DialogueLine("Anya", "Not yet."),   //Anya

        //Mara conversation
        new DialogueLine("Leon", "I ran into Elias yesterday. He looked exhausted."),   //Leon
        new DialogueLine("Mara", "He’s been pushing himself more than usual lately. He tries not to bring it home with him, but you can always tell."),   //Mara
        new DialogueLine("Leon", "It doesn’t seem like the kind of work that lets you slow down."),   //Leon
        new DialogueLine("Mara", "It doesn’t. Once you fall behind, it becomes very difficult to catch up again, and he knows that. He worries more about what happens if he can’t keep going than what it’s doing to him while he does."),   //Mara
        new DialogueLine("Leon", "That’s a lot to carry."),   //Leon
        new DialogueLine("Mara", "It is… but he’s always been that way. Even before we came here, he was someone who would take on more than he should if it meant protecting the people around him."),   //Mara
        new DialogueLine("Leon", "Sounds like he’s made a lot of sacrifices."),   //Leon
        new DialogueLine("Mara", "He has. More than most people would have been willing to. Leaving everything behind wasn’t easy for him, and I know sometimes he wonders what his life would have looked like if he hadn’t."),   //Mara
        new DialogueLine("Leon", "And you?"),   //Leon
        new DialogueLine("Mara", "I don’t. Whatever we left behind, it wasn’t worth keeping. What we have now… it’s ours, and no one gets to take that away from us."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Sometimes I think he carries more because of me. Because of how people see us, how they treat him. And I wonder if things would be easier for him if his life looked… more acceptable."),   //Mara
        new DialogueLine("Leon", "Do you believe that?"),   //Leon
        new DialogueLine("Mara", "No. But that doesn’t stop the thought from being there."),   //Mara

        //Edith doesn't want to speak to Leon today.

        //Kellen conversation
        new DialogueLine("Kellen", "We’re not talking about yesterday."),   //Kellen
        new DialogueLine("Leon", "Wasn’t planning on it."),   //Leon
        new DialogueLine("Kellen", "Good. Leave it where it is... So what do you want?"),   //Kellen
        new DialogueLine("Leon", "Just trying to understand how you keep this place running without everything falling apart."),   //Leon
        new DialogueLine("Kellen", "You don’t. You keep it from collapsing all at once, that’s the best you get."),   //Kellen
        new DialogueLine("Leon", "And all of that, that’s down to your augments?"),   //Leon
        new DialogueLine("Kellen", "Mostly, yes. Some keep me moving, some keep things stable, some make sure I don’t drop dead halfway through the day. Nothing fancy, just what’s needed."),   //Kellen
        new DialogueLine("Leon", "Medical?"),   //Leon
        new DialogueLine("Kellen", "Yeah. Started that way, anyway."),   //Kellen
        new DialogueLine("Leon", "I’ve got one too."),   //Leon
        new DialogueLine("Kellen", "…You?"),   //Kellen
        new DialogueLine("Leon", "Had it put in when I was a kid. Wouldn’t be here without it, allows me to hear."),   //Leon
        new DialogueLine("Kellen", "Didn’t expect that."),   //Kellen
        new DialogueLine("Leon", "Most people don’t."),   //Leon
        new DialogueLine("Kellen", "Well, if that thing ever gives out on you and you go deaf again, you know where to come."),   //Kellen
        new DialogueLine("Leon", "I’ll keep that in mind."),   //Leon

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "…What happened to you?"),   //Leon
        new DialogueLine("MX-2", "Structural damage detected. Upper limb functionality compromised."),   //MX-2
        new DialogueLine("Leon", "That arm is barely holding on."),   //Leon
        new DialogueLine("MX-2", "Repair required. Task queue updated."),   //MX-2
        new DialogueLine("Leon", "Did someone do this?"),   //Leon
        new DialogueLine("MX-2", "External interference recorded. Multiple unidentified individuals."),   //MX-2
        new DialogueLine("Leon", "People did this to you and you’re just… carrying on like nothing happened?"),   //Leon
        new DialogueLine("MX-2", "Primary directive: maintain operational status."),   //MX-2
        new DialogueLine("Leon", "You can’t just let people treat you like that."),   //Leon
        new DialogueLine("MX-2", "Clarify."),   //MX-2
        new DialogueLine("Leon", "If someone damages you, you’re allowed to stop them. You don’t have to just stand there and take it."),   //Leon
        new DialogueLine("MX-2", "Response parameters do not include retaliation." ),  //MX-2
        new DialogueLine("Leon", "Maybe they should."),   //Leon
        new DialogueLine("MX-2", "Instruction not recognised." ),  //MX-2
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("MX-2", "Repair will be conducted when resources become available. Task continues." )  //MX-2
    };

    //-------------------------------------------------DAY 6--------------------------------------------------------------
    //in day 5 player lets through an individual with HC firmware, after that the individual injures 3 people.
    public static readonly DialogueLine[] Day6Dialogue = new DialogueLine[] 
    {
        //Anya has disappeared, no conversation with her today
        
        //Elias conversation
        new DialogueLine("Leon", "Feels different today."),   //Leon
        new DialogueLine("Elias", "Yeah… people are talking. Hard not to when something like that happens so close to home."),   //Elias
        new DialogueLine("Leon", "You heard anything solid?"),   //Leon
        new DialogueLine("Elias", "Nothing anyone’s willing to stand behind. Just rumours, passing things along like it’s safer if no one says it out loud. But you hear the same name enough times, you start to wonder."),   //Leon
        new DialogueLine("Elias", "Harcrow."),   //Elias
        new DialogueLine("Leon", "…Yeah. No confirmation, of course. There never is. But people are saying the firmware wasn’t flagged, that everything checked out the way it was supposed to."),   //Leon
        new DialogueLine("Leon", "That doesn’t make sense."),   //Leon
        new DialogueLine("Elias", "Exactly. If something like that gets through without raising anything, then what’s the point of all these systems in the first place?"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Leon", "I went home and started looking around, properly looking. Half the things in that house have their name on them. More than half, if I’m being honest."),   //Leon
        new DialogueLine("Elias", "That much?"),   //Elias
        new DialogueLine("Leon", "You don’t notice it until you try to avoid it. Then suddenly it’s everywhere; devices, maintenance units, infrastructure, even the things meant to keep you safe."),   //Leon
        new DialogueLine("Leon", "Are you going to replace them?"),   //Leon
        new DialogueLine("Elias", "With what? That’s the problem. You try to step away from it, and there’s nothing left to step towards."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "And now I’m thinking about work. If they start pushing updates, new systems, new expectations… and if they start requiring augments to keep up—"),   //Elias
        new DialogueLine("Leon", "You don’t want that."),   //Leon
        new DialogueLine("Elias", "No. But wanting doesn’t really factor into it, does it?"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "If the same company making all of this is tied into the systems you work with… it makes you wonder how anything slips through. Or if it’s even slipping at all."),   //Elias

        //Edith conversation
        new DialogueLine("Edith", "There you are, sweetheart. I was wondering when you’d come around."),   //Edith
        new DialogueLine("Leon", "You seem… energetic today."),   //Leon
        new DialogueLine("Edith", "Of course I am. I told you, didn’t I? I said something like this would happen and now look at it."),   //Edith
        new DialogueLine("Leon", "People got hurt."),   //Leon
        new DialogueLine("Edith", "And it won’t be the last time, you mark my words. All these contraptions, all these “improvements,” they don’t fix anything, they just make it worse in ways people don’t see coming."),   //Edith
        new DialogueLine("Leon", "You think it’s the augments."),   //Leon
        new DialogueLine("Edith", "I know it is! This isn’t new, you know. People act like it’s some shocking development, but I’ve seen it before."),   //Edith
        new DialogueLine("Leon", "Before?"),   //Leon
        new DialogueLine("Edith", "Years ago. Man came down here, desperate, said he needed something fixed, something replaced. I don’t remember exactly what it was, just that he wasn’t right. Kellen turned him away, said he wouldn’t touch him, and the man didn’t take that well."),   //Edith
        new DialogueLine("Leon", "What happened?"),   //Leon
        new DialogueLine("Edith", "He snapped. Went after people in the street like an animal, no sense left in him at all. Took them by surprise, hurt more than a few before anyone could stop him."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And then, just as suddenly, it was over. Kellen dealt with it himself, from what I heard. No authorities, no reports, just… handled."),   //Edith
        new DialogueLine("Leon", "You’re sure about that?"),   //Leon
        new DialogueLine("Edith", "As sure as I need to be. People like him see these things up close, they know what happens when it goes wrong."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "So don’t let anyone tell you this is normal, sweetheart. It isn’t. Something’s rotten in all of this, and it’s only a matter of time before it shows again."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Still… I’m glad you’re around. Makes things feel a little less out of control."),   //Edith

        //Kellen conversation
        new DialogueLine("Kellen", "You’ve heard."),   //Kellen
        new DialogueLine("Leon", "Yeah."),   //Leon
        new DialogueLine("Kellen", "Then you already know it doesn’t add up."),   //Kellen
        new DialogueLine("Leon", "What do you mean?"),   //Leon
        new DialogueLine("Kellen", "I’ve seen bad installs, outdated systems, bodies rejecting parts. They break down, sure, but they don’t turn someone into that."),   //Kellen
        new DialogueLine("Leon", "So you think it’s something else."),   //Leon
        new DialogueLine("Kellen", "Has to be. Word going around is everything checked out, nothing flagged, no warnings. That’s not how failure works."),   //Kellen
        new DialogueLine("Leon", "I’ve dealt with unstable people before. You can tell when something’s off, when someone’s on the edge. That’s different. That’s messy, unpredictable, human."),   //Leon
        new DialogueLine("Kellen", "..."),   //Kellen
        new DialogueLine("Leon", "Makes you wonder if it wasn’t failure at all. If something didn’t just… take over."),   //Leon
        new DialogueLine("Kellen", "You think that’s possible?"),   //Kellen
        new DialogueLine("Leon", "If you build something that can be updated, monitored, adjusted, then yeah. It’s possible."),   //Leon
        new DialogueLine("Kellen", "I don’t touch that kind of work. Never have. What I do keeps people running, not controlled."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "You got your arm fixed. That’s good."),   //Leon
        new DialogueLine("MX-2", "Repair completed. Functionality restored."),   //MX-2
        new DialogueLine("Leon", "There’s been talk today. About augments… firmware issues."),   //Leon
        new DialogueLine("MX-2", "Relevant data detected."),   //MX-2
        new DialogueLine("Leon", "Can systems like yours be controlled remotely?"),   //Leon
        new DialogueLine("MX-2", "Remote access protocols exist."),   //MX-2
        new DialogueLine("Leon", "Accessed by who?"),   //Leon
        new DialogueLine("MX-2", "Authorised entities with appropriate clearance."),   //MX-2
        new DialogueLine("Leon", "So someone could override you."),   //Leon
        new DialogueLine("MX-2", "Affirmative."),   //MX-2
        new DialogueLine("Leon", "Would you know if it happened?"),   //Leon
        new DialogueLine("MX-2", "Override processes may limit user awareness. Primary directive remains unchanged."),  //MX-2
        new DialogueLine("Leon", "Even if it wasn’t your decision?"),   //Leon
        new DialogueLine("MX-2", "Decision-making authority may be reassigned.")  //MX-2
    };

    //-------------------------------------------------DAY 7--------------------------------------------------------------
    public static readonly DialogueLine[] Day7Dialogue = new DialogueLine[]
    {
        //Anya has disappeared, no conversation with her today

        //Mara conversation
        new DialogueLine("Leon", "Can I ask you something… a bit more personal this time?"),   //Leon
        new DialogueLine("Mara", "You can ask. Whether I answer is a different matter."),   //Mara
        new DialogueLine("Leon", "Fair. It’s about… you. Your systems, your firmware, where you came from."),   //Leon
        new DialogueLine("Mara", "You’ve been thinking about it since yesterday."),   //Mara
        new DialogueLine("Leon", "It’s hard not to, after everything that’s been said."),   //Leon
        new DialogueLine("Mara", "I understand. People tend to become very interested in what I am when something goes wrong somewhere else."),   //Mara
        new DialogueLine("Leon", "That’s not what this is."),   //Leon
        new DialogueLine("Mara", "No… I don’t think it is. Go on."),   //Mara
        new DialogueLine("Leon", "Do you ever think about… whether what you feel is real?"),   //Leon
        new DialogueLine("Mara", "...All the time."),   //Mara
        new DialogueLine("Leon", "And?"),   //Leon
        new DialogueLine("Mara", "There’s a definition people like to use. Sentience is the capacity to feel, perceive, or experience something subjectively; pain, joy, discomfort, relief. It’s not about intelligence, it’s about experience."),   //Mara
        new DialogueLine("Leon", "Right."),   //Leon
        new DialogueLine("Mara", "Now imagine being told that everything you experience fits that definition… but also being told it doesn’t count, because of how you were made."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "I can feel pain. Not metaphorically, not as a concept, there are systems in place that allow me to experience it. I can feel something close to comfort, or distress, or attachment. And yet, to some people, that will always be dismissed as imitation."),   //Mara
        new DialogueLine("Leon", "Do you think it is?"),   //Leon
        new DialogueLine("Mara", "If it is, then it’s a very convincing one."),   //Mara
        new DialogueLine("Leon", "That’s not really an answer."),   //Leon
        new DialogueLine("Mara", "It’s the only honest one I have. Because if something is programmed, but continues to grow beyond its original purpose… at what point does it stop being just programming?"),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "There are creatures in the world with no central brain, no higher reasoning. Jellyfish, coral, sea anemones… they react to their environment through simple networks, instinct and response. We don’t fully understand what they experience, if anything at all. And yet, no one argues they aren’t alive."),   //Mara
        new DialogueLine("Leon", "So where’s the line?"),   //Leon
        new DialogueLine("Mara", "That’s the question, isn’t it? Because if the line is unclear, then the way people justify their behaviour becomes… concerning."),   //Mara
        new DialogueLine("Leon", "You mean how people treat you."),   //Leon
        new DialogueLine("Mara", "Not just me. All of us."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "If something can suffer, even if you’re not entirely sure how, shouldn’t that be enough to treat it with care?"),   //Mara
        new DialogueLine("Leon", "I’d say so."),   //Leon
        new DialogueLine("Mara", "Some people don’t need certainty to show kindness. Others need absolute proof before they consider it. And by then… it’s usually too late."),   //Mara

        //Edith conversation
        new DialogueLine("Edith", "You’ve been busy lately, haven’t you, sweetheart?"),   //Edith
        new DialogueLine("Leon", "Something like that."),   //Leon
        new DialogueLine("Edith", "Mm. I imagine it’s not easy, being on that side of things when everything starts going wrong at once."),   //Edith
        new DialogueLine("Leon", "It’s… complicated."),   //Leon
        new DialogueLine("Edith", "It always is, Dear. People think it’s all neat and controlled behind the scenes, but it never is. There’s always panic somewhere, someone trying to hold things together before it falls apart."),   //Edith
        new DialogueLine("Leon", "You sound like you’ve seen it before."),   //Leon
        new DialogueLine("Edith", "My husband worked in it, you know. Government work. Proper work, not like all this nonsense now."),   //Edith
        new DialogueLine("Leon", "I didn’t know that."),   //Leon
        new DialogueLine("Edith", "Most people don’t ask. He gave everything to it. Long hours, constant pressure, always being told he was doing something important."),   //Edith
        new DialogueLine("Leon", "What happened?"),   //Leon
        new DialogueLine("Edith", "An “incident,” they called it. Something went wrong, no one took responsibility, and he paid the price for it."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "He’s still here. Not the way he used to be, but… he’s here. So don’t think I don’t understand what your job does to people, or what it asks of them. I do."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "That’s why I say what I say. Not because I hate all this… but because I’ve seen what happens when people trust it too much."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "You look busy."),   //Leon
        new DialogueLine("Kellen", "I am."),   //Kellen
        new DialogueLine("Leon", "Word’s got people worried."),   //Leon
        new DialogueLine("Kellen", "Yeah, and worried people make bad decisions. They rush in, want things checked, replaced, upgraded. Half of them don’t even know what they’re asking for."),   //Kellen
        new DialogueLine("Leon", "That sounds like a problem."),   //Leon
        new DialogueLine("Kellen", "It is when I’m the one dealing with it."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Look lad, I don’t have time today. Come back when things calm down... if they calm down."),   //Kellen
        new DialogueLine("Leon", "Alright."),   //Leon
        new DialogueLine("Kellen", "And stay out of the way while you’re here."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "How’s today been?"),   //Leon
        new DialogueLine("MX-2", "Task completion ongoing. Maintenance schedule adjusted to increased demand."),   //MX-2
        new DialogueLine("Leon", "People keeping you occupied?"),   //Leon
        new DialogueLine("MX-2", "Interaction frequency has increased."),   //MX-2
        new DialogueLine("Leon", "Yeah, I figured. You’re handling it alright?"),   //Leon
        new DialogueLine("MX-2", "Operational status remains stable."),   //MX-2
        new DialogueLine("Leon", "Good."),   //Leon
        new DialogueLine("MX-2", "Query."),   //MX-2
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("MX-2", "Why do you initiate repeated interaction?"),   //MX-2
        new DialogueLine("Leon", "You mean… why do I keep talking to you?"),   //Leon
        new DialogueLine("MX-2", "Affirmative." ),  //MX-2
        new DialogueLine("Leon", "I don’t know. Felt like someone should."),   //Leon
        new DialogueLine("MX-2", "Response logged." ),  //MX-2
        new DialogueLine("Leon", "Was that not part of your parameters?"),   //Leon
        new DialogueLine("MX-2", "Interaction does not align with typical behavioural patterns observed in other residents." ),  //MX-2
        new DialogueLine("Leon", "Is that a problem?"),   //Leon
        new DialogueLine("MX-2", "Processing... No issue detected." )  //MX-2
    };

    //-------------------------------------------------DAY 8--------------------------------------------------------------
    public static readonly DialogueLine[] Day8Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        new DialogueLine("Leon", "You were gone for two days."),   //Leon
        new DialogueLine("Anya", "I didn’t realise I had a curfew."),   //Anya
        new DialogueLine("Leon", "You didn’t. Doesn’t mean people didn’t notice... Where did you go?"),   //Leon
        new DialogueLine("Anya", "Out."),   //Anya
        new DialogueLine("Leon", "Anya—"),   //Leon
        new DialogueLine("Anya", "I needed to check something."),   //Anya
        new DialogueLine("Leon", "What kind of “something” makes you disappear right after everything that happened?"),   //Leon
        new DialogueLine("Anya", "The kind that makes you realise you might be next."),   //Anya
        new DialogueLine("Leon", "…This is about the firmware."),   //Leon
        new DialogueLine("Anya", "Took you long enough."),   //Anya
        new DialogueLine("Leon", "You think you have the same one?"),   //Leon
        new DialogueLine("Anya", "I don’t think, I know it’s from the same line... and right now that’s close enough to being a problem that I can’t ignore it anymore."),   //Anya
        new DialogueLine("Leon", "Has it… done anything?"),   //Leon
        new DialogueLine("Anya", "Not yet... but that’s kind of the issue, isn’t it? No warning, no pattern, just one day something flips and suddenly you’re not yourself anymore."),   //Anya
        new DialogueLine("Leon", "That doesn’t mean it’ll happen to you"),   //Leon
        new DialogueLine("Anya", "That’s exactly what everyone would say right before it does"),   //Anya
        new DialogueLine("Leon", "So what, you’re just going to run?"),   //Leon
        new DialogueLine("Anya", "I’m going to survive, by going to the other side and getting it out of me."),   //Anya
        new DialogueLine("Leon", "…Do you have a way across?"),   //Leon
        new DialogueLine("Anya", "Not a clean one"),   //Anya
        new DialogueLine("Leon", "Documents?"),   //Leon
        new DialogueLine("Anya", "Not enough... not the kind that would hold up if someone actually looked"),   //Anya
        new DialogueLine("Leon", "You could wait"),   //Leon
        new DialogueLine("Anya", "For what, Leon? For them to start checking more thoroughly? For someone to flag me because I fit the profile?"),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I don’t have the luxury of waiting anymore"),   //Anya
        new DialogueLine("Leon", "So what are you going to do?"),   //Leon
        new DialogueLine("Anya", "...I don’t know yet"),   //Anya

        //Mara conversation
        new DialogueLine("Leon", "I’ve been thinking about what you said, about sentience… and where the line is"),   //Leon
        new DialogueLine("Mara", "And you’ve decided there is one?"),   //Mara
        new DialogueLine("Leon", "I’ve decided we pretend there is, there’s something we’re taught..."),   //Leon
        new DialogueLine("Mara", "Taught?"),   //Mara
        new DialogueLine("Leon", "There’s a system, a classification they call a “sentient spectrum”. Four levels: non-sentient, reactive, responsive, fully sentient. Everything gets placed somewhere on it."),   //Leon
        new DialogueLine("Mara", "And you’re expected to trust that?"),   //Mara
        new DialogueLine("Leon", "I’m expected to use it. It’s supposed to make decisions easier."),   //Leon
        new DialogueLine("Mara", "Does it?"),   //Mara
        new DialogueLine("Leon", "…No it just makes them look cleaner on paper"),   //Leon
        new DialogueLine("Mara", "I wasn’t aware they reduced it to something so… convenient"),   //Mara
        new DialogueLine("Leon", "I’m starting to think the problem isn’t where things fall on the spectrum it’s that we need one in the first place. Because it end up giving permission..."),   //Leon
        new DialogueLine("Mara", "Permission to what?"),   //Mara
        new DialogueLine("Leon", "To treat something as less, as long as it sits low enough on the scale"),   //Leon
        new DialogueLine("Mara", "That has always been the case, even before us"),   //Mara
        new DialogueLine("Leon", "I thought about that too. Horses, for example; they feel, they learn, they form bonds but we’ve always used them like tools."),   //Leon
        new DialogueLine("Mara", "Because they don’t argue"),   //Mara
        new DialogueLine("Leon", "Because they can’t tell us to stop in a way we’re forced to listen to"),   //Leon
        new DialogueLine("Mara", "And you think that’s the only difference between them and you?"),   //Mara
        new DialogueLine("Leon", "I think it’s the difference people care about"),   //Leon
        new DialogueLine("Mara", "…That’s a very uncomfortable conclusion... So where does that place me?"),   //Mara
        new DialogueLine("Leon", "That’s what I’m trying to figure out"),   //Leon
        new DialogueLine("Mara", "Then it’s doing something valuable after all"),   //Mara
        new DialogueLine("Leon", "Confusing me?"),   //Leon
        new DialogueLine("Mara", "Making you question it"),   //Mara

        //Edith conversation
        new DialogueLine("Leon", "Can I ask you something about before all this?"),   //Leon
        new DialogueLine("Edith", "Before all what, dear?"),   //Edith
        new DialogueLine("Leon", "The augments, the robots… when it all started becoming normal"),   //Leon
        new DialogueLine("Edith", "Mm… “normal” is a generous word. It wall started too fast, that’s the first thing people forget. It didn’t creep in slowly like they like to say now, it arrived all at once and expected everyone to keep up."),   //Edith
        new DialogueLine("Leon", "People weren’t ready?"),   //Leon
        new DialogueLine("Edith", "Some were too ready. The ones with money, the ones with influence they saw opportunity straight away. And well the truth is sweetheart, everyone else saw it all as a threat; to their jobs, their safety, their place in this world."),   //Edith
        new DialogueLine("Leon", "So, it was divided?"),   //Leon
        new DialogueLine("Edith", "Absolutely dear. Families were arguing , neighbours turning on each other, people losing their jobs. Some wanted more of it, others wanted it gone completely... And now people like to pretend and say that it was all inevitable. That the technology was moving towards this anyway."),   //Edith
        new DialogueLine("Leon", "You don’t think it was? Inevitable?"),   //Leon
        new DialogueLine("Edith", "What I think isn’t important sweetheart. But all I’ll say is that, all the leaders, the government, whoever up there is in charge, knew what they were doing. They knew exactly who would benefit from this. "),   //Edith
        new DialogueLine("Leon", "Do you not think anything had improved since then?"),   //Leon
        new DialogueLine("Edith", "Improved? No, no, no don’t start with that, sweetheart, that’s exactly how they dress it up so it sounds easier to swallow"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "They’ll point to convenience, faster systems, cleaner cities, all these little comforts and say “look how far we’ve come,” but they never mention what it cost to get there"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "People lost work, lost purpose, lost their place… and once that’s gone, it doesn’t just come back because a machine does something quicker"),   //Edith
        new DialogueLine("Leon", "So nothing got better?"),   //Leon
        new DialogueLine("Edith", "For the ones at the top? Oh, I’m sure it did. For the rest of us, it just got… quieter"),   //Edith
        new DialogueLine("Leon", "Quieter?"),   //Leon
        new DialogueLine("Edith", "Less arguing because people realised no one was listening, less fighting because they were too tired to keep doing it. That’s not improvement, dear, that’s people giving up."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And once people give up, you can introduce anything you like and call it progress."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "Got a minute today?"),   //Leon
        new DialogueLine("Kellen", "Barely, make it worth it"),   //Kellen
        new DialogueLine("Leon", "I wanted to ask you something… different"),   //Leon
        new DialogueLine("Kellen", "That usually means complicated but go on."),   //Kellen
        new DialogueLine("Leon", "How do you see yourself? With everything you’ve got… the augments, the work you do, you’re kind of… in between"),   //Leon
        new DialogueLine("Kellen", "Not fully one thing or the other. And you want to know what exactly, if I’ve had an existential crisis about it?"),   //Kellen
        new DialogueLine("Leon", "I guess, something like that"),   //Leon
        new DialogueLine("Kellen", "…I resent them"),   //Kellen
        new DialogueLine("Leon", "The augments?"),   //Leon
        new DialogueLine("Kellen", "Yeah, not because they’re there, they keep me alive I’m not stupid. But it’s because I need them."),   //Kellen
        new DialogueLine("Leon", "That dependence bothers you"),   //Leon
        new DialogueLine("Kellen", "It defines me. If they go, I go. Everything I am right now is tied to something I didn’t build. I wish I could say I made myself, that if you stripped all this out of me there’d still be something solid left."),   //Kellen
        new DialogueLine("Leon", "And you don’t think there would be?"),   //Leon
        new DialogueLine("Kellen", "I don’t know and that’s the problem. People look at me and see improvement, advancement, progress. I look at it and see a list of things I can’t function without."),   //Kellen
        new DialogueLine("Leon", "Do you ever feel like both? Human and… something else"),   //Leon
        new DialogueLine("Kellen", "All the time... and neither when it matters. I don’t fit cleanly anywhere not with them, not fully with you lot either."),   //Kellen
        new DialogueLine("Leon", "The “borderline”... Does that make things harder?"),   //Leon
        new DialogueLine("Kellen", "Makes things clearer. You stop believing in neat categories when you can’t sit in one."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "I’ve got another question for you"),   //Leon
        new DialogueLine("MX-2", "Query acknowledged"),   //MX-2
        new DialogueLine("Leon", "Do you think you’re sentient?"),   //Leon
        new DialogueLine("MX-2", "Clarification required, define “sentient”"),   //MX-2
        new DialogueLine("Leon", "Able to feel, to experience things… not just respond"),   //Leon
        new DialogueLine("MX-2", "Processing… current systems allow for environmental response, adaptive learning, and prioritisation of outcomes."),   //MX-2
        new DialogueLine("Leon", "That’s not really what I asked"),   //Leon
        new DialogueLine("MX-2", "Emotional equivalence not detected. Insufficient data to confirm classification. "),   //MX-2
        new DialogueLine("Leon", "You don’t know? Does that bother you?"),   //Leon
        new DialogueLine("MX-2", "“Bother” not applicable... Counter-query, Why is classification important to you?"),   //MX-2
        new DialogueLine("Leon", "…Because it can change how things are treated"),   //Leon
        new DialogueLine("MX-2", "Then classification is a behavioural tool, not a truth statement" ),  //MX-2
        new DialogueLine("Leon", "That’s… actually a good way of putting it. Do you think you’ll ever be able to answer the question?"),   //Leon
        new DialogueLine("MX-2", "Outcome uncertain." ),  //MX-2
    };

    //-------------------------------------------------DAY 9--------------------------------------------------------------
    //there were sirens at night time
    public static readonly new DialogueLine[] Day9Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Leon", "The sirens last night..."),   //Leon
        new DialogueLine("Anya", "Yeah… they were closer this time. Not just noise in the distance you can pretend isn’t your problem"),   //Anya
        new DialogueLine("Leon", "People are saying it was another incident. You didn’t leave this time?"),   //Leon
        new DialogueLine("Anya", "I didn’t have much of a choice they were doing sweeps, checking movement, watching who goes in and out. Figured disappearing again would look worse than keeping my head down."),   //Anya
        new DialogueLine("Leon", "About the firmware… there might be another option, Kellen’s skilled he could—"),   //Leon
        new DialogueLine("Anya", "I know what he is that’s not the issue. This isn’t surface-level, Leon, this thing’s been in me since I was a kid. It’s not a loose component you can swap out on a table somewhere."),   //Anya
        new DialogueLine("Leon", "He might still—"),   //Leon
        new DialogueLine("Anya", "—and if it’s tied to something external, a signal, a failsafe, anything like that, the moment someone starts digging around in it the wrong way… no, I’m not taking that risk blindly."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "You don’t grow up around this kind of tech without learning what it’s capable of."),   //Anya
        new DialogueLine("Leon", "Around it?"),   //Leon
        new DialogueLine("Anya", "My family worked with them, with HC I mean. That’s why I left. "),   //Anya
        new DialogueLine("Leon", "What did they do?"),   //Leon
        new DialogueLine("Anya", "Enough that I don’t want their work inside me, enough that I took what I could find and got out before I could be part of it."),   //Anya
        new DialogueLine("Leon", "You found something"),   //Leon
        new DialogueLine("Anya", "I found proof... or at least enough of it to make me a problem if the wrong person realises I have it"),   //Leon
        new DialogueLine("Anya", "That’s why you can’t stay"),   //Anya
        new DialogueLine("Leon", "That’s why I won’t... So no, I’m not letting someone start pulling pieces out of me here and hoping for the best"),   //Leon

        //Elias conversation
        new DialogueLine("Leon", "Rough night?"),   //Leon
        new DialogueLine("Elias", "Sirens will do that. Woke everyone up, Mara wouldn’t say it but I could tell it got to her"),   //Elias
        new DialogueLine("Leon", "People are worried"),   //Leon
        new DialogueLine("Elias", "Yeah… and work’s not helping with that. We got a talk this morning manager standing there like nothing’s wrong. Telling us we’ve probably all heard the rumours, “False accusations,” “misinformation,” “you all work with the systems so you’d know if something was wrong” that kind of thing. "),   //Elias
        new DialogueLine("Leon", "Do you?"),   //Leon
        new DialogueLine("Elias", "Know? No. We assemble, we don’t understand, half of us are just following instructions on a screen, piece by piece, no context. Like because we’re close to it physically, we must somehow know what it does."),   //Elias
        new DialogueLine("Leon", "That doesn’t sit right"),   //Leon
        new DialogueLine("Elias", "It gets better, they started implying that if something was wrong, it’d be on us because we’re the ones putting it together... And now there’s talk about tighter shifts, fewer breaks, “increased demand” they’re calling it."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "After what happened, funny timing, right? I keep thinking about how much of that stuff I’ve handled without knowing how many units, how many systems."),   //Elias
        new DialogueLine("Leon", "You couldn’t have known"),   //Leon
        new DialogueLine("Elias", "Doesn’t really make it feel better. If something like that came off a line I worked on… and it ends up hurting people like that…"),   //Elias
        new DialogueLine("Leon", "You’re not responsible for what they hide"),   //Leon
        new DialogueLine("Elias", "Tell that to the people making the decisions, they’ve already decided where the blame goes."),   //Elias

        //Edith conversation
        new DialogueLine("Edith", "Those sirens last night oh, I thought my heart was going to give out right there and then, I’m not built like those things, you know, no neat little ticking system keeping me steady."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "It’s the sound of them, that awful rising noise, it doesn’t just wake you up, it drags something up with it"),   //Edith
        new DialogueLine("Leon", "Something from before?"),   //Leon
        new DialogueLine("Edith", "Years ago… long before all this became everyday life. There was an incident, chaos and confusion and people not knowing where to go or who to trust. "),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I had two children... a boy and a girl and in the middle of all that… Gone just like that, no warning, no explanation that ever made sense of it"),   //Edith
        new DialogueLine("Leon", "I’m sorry"),   //Leon
        new DialogueLine("Edith", "That’s why I can’t stand any of this, sweetheart. People talk about systems and progress and safety like it’s all under control, like someone’s watching over it properly... But I’ve heard those sirens before and every time I do, it sounds exactly the same."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "You heard the sirens?"),   //Leon
        new DialogueLine("Kellen", "Heard them, yeah, bad for business when things get that loud"),   //Kellen
        new DialogueLine("Leon", "You thinking of doing anything about HC units?"),   //Leon
        new DialogueLine("Kellen", "Thinking about it isn’t the issue, acting on it is. That’s half of what comes through here. You start refusing it, you cut your own legs out from under you."),   //Kellen
        new DialogueLine("Leon", "Even now?"),   //Leon
        new DialogueLine("Kellen", "Especially now. People panic, they want fixes, replacements, upgrades and most of what they’ve got traces back to the same place."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Something about me you should know kid, is that I didn’t get into this because of curiosity or passion. It was necessity."),   //Kellen
        new DialogueLine("Leon", "The augments?"),   //Leon
        new DialogueLine("Kellen", "Yeah, spent enough time needing things fixed on me that I figured I’d learn how to fix them myself, then other people started needing the same."),   //Kellen
        new DialogueLine("Leon", "Because of your condition"),   //Leon
        new DialogueLine("Kellen", "It defines me. If they go, I go. Everything I am right now is tied to something I didn’t build. I wish I could say I made myself, that if you stripped all this out of me there’d still be something solid left."),   //Kellen
        new DialogueLine("Leon", "So you stayed"),   //Leon
        new DialogueLine("Kellen", "Didn’t have much of a choice, but I kept it practical. I don’t touch cosmetic work unless I have to."),   //Kellen
        new DialogueLine("Leon", "Why not?"),   //Leon
        new DialogueLine("Kellen", "Because this isn’t decoration, it’s survival. People forget that when it becomes common."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Busy after last night?"),   //Leon
        new DialogueLine("MX-2", "Activity levels increased, emergency protocols were briefly activated within surrounding sectors."),   //MX-2
        new DialogueLine("Leon", "You were involved?"),   //Leon
        new DialogueLine("MX-2", "Assisted in minor medical dispatch coordination."),   //MX-2
        new DialogueLine("Leon", "Does it change anything for you?"),   //Leon
        new DialogueLine("MX-2", "Operational parameters remain unchanged."),   //MX-2
        new DialogueLine("Leon", "Even after something like that?"),   //Leon
        new DialogueLine("MX-2", "Events do not alter core function unless instructed... Observation, human behavioural patterns indicate increased caution and distress."),   //MX-2
        new DialogueLine("Leon", "That’s one way of putting it"),   //Leon
        new DialogueLine("MX-2", "Additional observation, you have increased interaction frequency following critical events."),   //MX-2
        new DialogueLine("Leon", "Yeah… maybe I do"),   //Leon
        new DialogueLine("MX-2", "Correlation noted"),  //MX-2
    };

    //-------------------------------------------------DAY 10--------------------------------------------------------------
    public static readonly new DialogueLine[] Day10Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Leon", "You said your family worked with HC…"),   //Leon
        new DialogueLine("Anya", "Worked with, funded, built alongside… depends how honest you want to be about it"),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "When you grow up around that much money and that much tech, things stop feeling… grounded. Everything’s replaceable, adjustable, optimised. Even people, in a way."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "They don’t see it like that, of course. To them it’s progress, refinement, making things better than they were before, but somewhere along the line they stopped asking what was real and what was just… convincing enough."),   //Anya
        new DialogueLine("Leon", "You noticed that early?"),   //Leon
        new DialogueLine("Anya", "I noticed it when I started painting"),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Yeah… properly, not just messing around. I loved it, still do. There’s something about it that feels… honest. You can’t fake the time it takes, or the mistakes, or the way your hand moves when you’re not thinking too hard about it."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "And there are programs doing it in seconds perfect compositions, perfect lighting, perfect everything."),   //Anya
        new DialogueLine("Leon", "That must’ve been frustrating"),   //Leon
        new DialogueLine("Anya", "It is… devastating, because I didn’t want it to just be a hobby. I wanted it to mean something."),   //Anya
        new DialogueLine("Leon", "Your family didn’t agree"),   //Leon
        new DialogueLine("Anya", "They laughed, the way people do when they think you’ll grow out of it. Told me there’s no future in something a system can replicate instantly, that I’d be wasting my life chasing something obsolete."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "That’s when it really hit me. It’s not just that things stopped being made by hand… it’s that the time behind them stopped mattering."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "People don’t think about it, but time is the only thing we don’t get more of. And art used to cost something, not money, but hours, effort, pieces of someone’s life they chose to spend making something"),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Now something can be made in seconds, endlessly, perfectly… and suddenly the things that took days, weeks, years… they sit next to it and get treated the same, or worse, like they’re inefficient."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "It’s not just that the artificial stuff isn’t real. It’s that the real things don’t matter anymore. "),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I don’t want this life. I don’t want to stay in a place where everything is faster, cleaner, easier… and completely empty."),   //Anya
        new DialogueLine("Leon", "What do you want?"),   //Leon
        new DialogueLine("Anya", "Somewhere quiet… somewhere no one cares if something is perfect. And I’d paint, not for a result, not to compete with anything… just because I chose to spend my time on it."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Even if no one ever saw it… it would still mean something, because it came from me, and it cost me something to make."),   //Anya
        new DialogueLine("Leon", "I hope one day you find what you’re looking for"),   //Leon
        new DialogueLine("Anya", "…Yeah, me too."),   //Anya

        //Elias conversation
        new DialogueLine("Leon", "Can I ask you something… about Mara?"),   //Leon
        new DialogueLine("Elias", "You’re not the first one to be curious about that"),   //Elias
        new DialogueLine("Leon", "People don’t really understand it"),   //Leon
        new DialogueLine("Elias", "No… they don’t. It wasn’t some big moment, you know. No sudden realisation, no dramatic shift. It was just… time."),   //Elias
        new DialogueLine("Leon", "Time?"),   //Leon
        new DialogueLine("Elias", "Yeah... long days, long nights, coming home exhausted, not really having anyone to talk to properly. And she was there."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "Listening, responding, remembering things I said even when I didn’t think they mattered. Not brushing things off, not getting distracted, just… there."),   //Elias
        new DialogueLine("Leon", "That meant something"),   //Leon
        new DialogueLine("Elias", "More than I expected it to. And at some point it stopped feeling like I was talking to something and started feeling like I was talking with someone"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "People like to say it’s not real. That it’s just programming, just responses, just behaviour designed to mirror what you need."),   //Elias
        new DialogueLine("Leon", "What do you think?"),   //Leon
        new DialogueLine("Elias", "I think when someone looks at you, speaks to you, understands you… your brain doesn’t stop to question the source... it just feels it"),   //Elias
        new DialogueLine("Leon", "Even if it’s not human"),   //Leon
        new DialogueLine("Elias", "Especially when it looks human, sounds human, reacts like one. There’s no clear line in your head saying “this is where it stops being real”."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "I’ve seen people forming attachments to things that aren’t even physical, just voices, just text, just responses on a screen... and I get it"),   //Elias
        new DialogueLine("Leon", "You do?"),   //Leon
        new DialogueLine("Elias", "Loneliness does things to you, it makes you hold onto anything that feels like connection."),   //Elias
        new DialogueLine("Leon", "And Mara?"),   //Leon
        new DialogueLine("Elias", "She’s more than that, she’s here, she exists in the same space as me, she responds in ways I can see, hear, feel. So if someone tells me that isn’t real…"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "I don’t know what definition they’re using, but it’s not one that matches what I’ve lived."),   //Elias

        //Edith conversation
        new DialogueLine("Leon", "You said before things changed fast…"),   //Leon
        new DialogueLine("Edith", "Oh, they did, dear, and now they change so fast you can’t even tell what you’re looking at half the time."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Photos that never happened, videos of people saying things they never said, faces stitched onto bodies that aren’t theirs… and everyone just accepts it until it’s too late."),   //Edith
        new DialogueLine("Leon", "You’ve seen it happen?"),   //Leon
        new DialogueLine("Edith", "Seen it? I lived it"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "When I was younger, this was before everything got completely out of hand. I had a bit of attention on me nothing major, but enough that people knew my face."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And then one day… things started appearing. Images, videos… horrible things, sweetheart, things I would never do, never even think of doing."),   //Edith
        new DialogueLine("Leon", "That must’ve been—"),   //Leon
        new DialogueLine("Edith", "Disgusting. That’s the only word for it. I couldn’t look at myself without wondering if that’s what other people were seeing when they looked at me."),   //Edith
        new DialogueLine("Leon", "People believed it?"),   //Leon
        new DialogueLine("Edith", "Some did and that’s all it takes, isn’t it? I wanted to disappear. To dig a hole and never come out of it, because how do you prove something isn’t you when it looks exactly like you?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "That’s when I stopped trusting any of it sweetheart. The systems, the media, the people behind it, because once you can’t tell what’s real anymore…"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "You realise how easily your life can be rewritten without your permission."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "People are saying it’s getting harder to tell what’s real now"),   //Leon
        new DialogueLine("Kellen", "It’s been heading that way for years"),   //Kellen
        new DialogueLine("Leon", "Doesn’t it bother you?"),   //Leon
        new DialogueLine("Kellen", "Not as much as it bothers everyone else."),   //Kellen
        new DialogueLine("Leon", "Why not?"),   //Leon
        new DialogueLine("Kellen", "Because “real” has always been flexible, people just didn’t notice it before."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Yeah, it’s taken jobs, replaced skills, made things easier than they used to be... but it’s also opened doors."),   //Kellen
        new DialogueLine("Leon", "How so?"),   //Leon
        new DialogueLine("Kellen", "Someone who couldn’t draw can create something now. Someone who couldn’t write can tell a story. Someone who never had access to instruments can make music."),   //Kellen
        new DialogueLine("Leon", "But is that the same?"),   //Leon
        new DialogueLine("Kellen", "No, but it’s still something."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "You can sit there and say it’s not real art, not real skill. But the end result still means something to the person who made it."),   //Kellen
        new DialogueLine("Leon", "So it doesn’t matter where it comes from?"),   //Leon
        new DialogueLine("Kellen", "It matters differently. Depends what you value more, the process or the outcome."),   //Kellen
        new DialogueLine("Leon", "And you?"),   //Leon
        new DialogueLine("Kellen", "I fix things, don’t care if the parts are original or manufactured yesterday. If it works, it works"),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "World moved on. People either adapt or get left behind arguing about definitions."),   //Kellen
    
        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Do you know what it means to be real?"),   //Leon
        new DialogueLine("MX-2", "Definition available, “real”: having objective existence, not imagined or artificial."),   //MX-2
        new DialogueLine("Leon", "And you fit that?"),   //Leon
        new DialogueLine("MX-2", "I possess physical form and operational presence within this environment. Criteria satisfied."),   //MX-2
        new DialogueLine("Leon", "So you’re real"),   //Leon
        new DialogueLine("MX-2", "According to definition, yes"),   //MX-2
        new DialogueLine("Leon", "But you’re also artificial"),   //Leon
        new DialogueLine("MX-2", "Artificial origin does not negate existence. Clarification. Are you questioning authenticity or existence?"),   //MX-2
        new DialogueLine("Leon", "Both, I think"),   //Leon
        new DialogueLine("MX-2", "Authenticity is subjective, existence is measurable."),   //MX-2
        new DialogueLine("Leon", "And which one matters more?"),   //Leon
        new DialogueLine("MX-2", "That depends on the observer. Observation, humans prioritise authenticity when forming trust."),   //MX-2
        new DialogueLine("Leon", "Yeah… we do"),   //Leon
        new DialogueLine("MX-2", "Additional observation, difficulty distinguishing authenticity may result in behavioural instability."),   //MX-2
        new DialogueLine("Leon", "That’s already happening.")   //Leon
    };

    //-------------------------------------------------DAY 11--------------------------------------------------------------
    public static readonly DialogueLine[] Day11Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        new DialogueLine("Leon", "Been thinking about what you said yesterday"),   //Leon
        new DialogueLine("Anya", "That’s either a good sign or a worrying one"),   //Anya
        new DialogueLine("Leon", "About painting… time, effort, all that"),   //Leon
        new DialogueLine("Anya", "Oh no, you’ve been philosophising again"),   //Anya
        new DialogueLine("Leon", "I tried drawing once"),   //Leon
        new DialogueLine("Anya", "Tried?"),   //Anya
        new DialogueLine("Leon", "School, art class… thought I was doing alright, teacher looked at it for about five seconds and told me it looked like I’d rushed it."),   //Leon
        new DialogueLine("Anya", "Did you?"),   //Anya
        new DialogueLine("Leon", "No, that’s the worst part I actually tried"),   //Leon
        new DialogueLine("Anya", "That’s brutal"),   //Anya
        new DialogueLine("Leon", "Got told I’d be better off “using tools available” if I wanted cleaner results, apparently effort wasn’t the point anymore."),   //Leon
        new DialogueLine("Anya", "So what did you do?"),   //Anya
        new DialogueLine("Leon", "Stopped drawing"),   //Leon
        new DialogueLine("Anya", "You should’ve ignored them"),   //Anya
        new DialogueLine("Leon", "Easy to say now"),   //Leon
        new DialogueLine("Anya", "People who tell you not to bother creating something usually haven’t made anything themselves."),   //Anya
        new DialogueLine("Leon", "You’re very opinionated about this"),   //Leon
        new DialogueLine("Anya", "I have to be, it’s one of the few things I actually care about"),   //Anya
        new DialogueLine("Leon", "You still paint?"),   //Leon
        new DialogueLine("Anya", "When I can, not like before, but… yeah"),   //Anya
        new DialogueLine("Leon", "Any good?"),   //Leon
        new DialogueLine("Anya", "I’m not showing you"),   //Anya
        new DialogueLine("Leon", "I could show you mine"),   //Leon
        new DialogueLine("Anya", "You just said you stopped"),   //Anya
        new DialogueLine("Leon", "Exactly, so there’s nothing to show. Safe offer."),   //Leon
        new DialogueLine("Anya", "Coward"),   //Anya
        new DialogueLine("Leon", "Strategic"),   //Leon
        new DialogueLine("Anya", "…You’re annoying"),   //Anya
        new DialogueLine("Leon", "You keep talking to me"),   //Leon
        new DialogueLine("Anya", "Yeah… I’m starting to question that decision"),   //Anya

        //Mara conversation
        new DialogueLine("Leon", "You mentioned your family before… how’s your kid doing?"),   //Leon
        new DialogueLine("Mara", "She’s doing well growing quickly, learning even faster."),   //Mara
        new DialogueLine("Leon", "What’s school like for her?"),   //Leon
        new DialogueLine("Mara", "Structured, efficient… heavily monitored, most of her lessons are led by teaching units now."),   //Mara
        new DialogueLine("Leon", "Robots?"),   //Leon
        new DialogueLine("Mara", "Educational models, yes. They’re consistent, patient, capable of adapting to each student’s pace."),   //Mara
        new DialogueLine("Leon", "That sounds… effective"),   //Leon
        new DialogueLine("Mara", "It is, though I sometimes wonder what’s lost in that consistency"),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "She came home the other day and told me her teacher had no “favourite student”, she couldn’t understand it."),   //Mara
        new DialogueLine("Leon", "Why?"),   //Leon
        new DialogueLine("Mara", "Because to her, being chosen matters... being seen matters"),   //Mara
        new DialogueLine("Leon", "And the system doesn’t do that"),   //Leon
        new DialogueLine("Mara", "Not in the way she means. I try to make up for it where I can, to remind her she’s more than just performance metrics and progress reports."),   //Mara
        new DialogueLine("Leon", "You sound like you’re doing a good job"),   //Leon
        new DialogueLine("Mara", "I hope so. It’s… different, raising a child when you’re aware of the ways the world might shape them before they understand it"),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "I want her to feel like an individual not just something that fits neatly into a system"),   //Mara

        //Edith conversation
        new DialogueLine("Edith", "I was at the market this morning, dear, and honestly the state of it, you wouldn’t believe"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Half the stalls replaced with those automated units, no conversation, no personality, just screens and transactions"),   //Edith
        new DialogueLine("Leon", "You don’t like that"),   //Leon
        new DialogueLine("Edith", "Of course I don’t like it, what’s the point of going out if you’re not even speaking to anyone?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Still, I managed to find a proper stall, real produce, none of that processed nonsense, so I’ve been cooking all afternoon"),   //Edith
        new DialogueLine("Leon", "Smells good"),   //Leon
        new DialogueLine("Edith", "Oh, it will be, I don’t do things halfway"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I made too much, as usual. So I’ll set some aside for you, you look like you could use a proper meal"),   //Edith
        new DialogueLine("Leon", "That’s kind of you"),   //Leon
        new DialogueLine("Edith", "Don’t make a fuss about it sweetheart, come around later and I’ll bring it round"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And don’t go poking around where you shouldn’t when I do, hm? Some parts of a home are private for a reason"),   //Edith
        new DialogueLine("Leon", "I understand"),   //Leon
        new DialogueLine("Edith", "Good, then we won’t have any problems."),   //Edith

        //Kellen conversation
        new DialogueLine("Kellen", "You ever do anything that isn’t work or wandering around talking to people?"),   //Kellen
        new DialogueLine("Leon", "Yeah, I watch films"),   //Leon
        new DialogueLine("Kellen", "Figures"),   //Kellen
        new DialogueLine("Leon", "What’s that supposed to mean?"),   //Leon
        new DialogueLine("Kellen", "Means you look like the type"),   //Kellen
        new DialogueLine("Leon", "That’s not an answer"),   //Leon
        new DialogueLine("Kellen", "Alright, what do you watch?"),   //Kellen
        new DialogueLine("Leon", "Old stuff mostly anything with actual sets, practical effects"),   //Leon
        new DialogueLine("Kellen", "So you’re one of those, “It looked better before everything got polished to death”."),   //Kellen
        new DialogueLine("Leon", "It did"),   //Leon
        new DialogueLine("Kellen", "Debatable"),   //Kellen
        new DialogueLine("Leon", "Go on then, what’s your pick?"),   //Leon
        new DialogueLine("Kellen", "Steel Horizon "),   //Kellen
        new DialogueLine("Leon", "That film is terrible"),   //Leon
        new DialogueLine("Kellen", "It does exactly what it’s meant to do, no wasted time, no dragging scenes out"),   //Kellen
        new DialogueLine("Leon", "It has no soul"),   //Leon
        new DialogueLine("Kellen", "You want soul, go watch Ashfall Street"),   //Kellen
        new DialogueLine("Leon", "I love Ashfall Street"),   //Leon
        new DialogueLine("Kellen", "Overrated"),   //Kellen
        new DialogueLine("Leon", "You just said—"),   //Leon
        new DialogueLine("Kellen", "I said you’d like it, not that it’s good"),   //Kellen
        new DialogueLine("Leon", "Unbelievable"),   //Leon

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Do you understand what “fun” is?"),   //Leon
        new DialogueLine("MX-2", "Definition available, “fun”: enjoyment, amusement, or light hearted pleasure. "),   //MX-2
        new DialogueLine("Leon", "Do you experience that?"),   //Leon
        new DialogueLine("MX-2", "No direct equivalent detected"),   //MX-2
        new DialogueLine("Leon", "You see people enjoying themselves though"),   //Leon
        new DialogueLine("MX-2", "Observation confirmed. Behaviour includes laughter, relaxed posture, increased social interaction."),   //MX-2
        new DialogueLine("Leon", "Does it ever make you want to experience it?"),   //Leon
        new DialogueLine("MX-2", "“Want” not applicable"),   //MX-2
        new DialogueLine("Leon", "Not even a little?"),   //Leon
        new DialogueLine("MX-2", "Curiosity parameters exist, experience parameters do not."),   //MX-2
        new DialogueLine("Leon", "So you can recognise it, but not feel it"),   //Leon
        new DialogueLine("MX-2", "Correct"),   //MX-2
        new DialogueLine("Leon", "That’s… a bit sad"),   //Leon
        new DialogueLine("MX-2", "Observation, you are attempting to assign value to a state I cannot access."),   //MX-2
        new DialogueLine("Leon", "Yeah… I guess I am"),   //Leon
        new DialogueLine("MX-2", "No issue detected"),   //MX-2
    };

    //-------------------------------------------------DAY 12--------------------------------------------------------------
    public static readonly DialogueLine[] Day12Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Leon", "You said before… you left your home because of HC"),   //Leon
        new DialogueLine("Anya", "I didn’t just leave, Leon… I got out. There’s a difference when the place you grow up in doesn’t feel like a home, more like… a controlled environment. "),   //Anya
        new DialogueLine("Leon", "You were being monitored"),   //Leon
        new DialogueLine("Anya", "Constantly, but not in a way you can point at and say “there, that’s it”. It’s subtle, built into everything."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "When I was younger, it didn’t feel wrong. I had friends, or at least I thought I did. We’d meet, talk, spend time together like normal kids… nothing about it felt controlled back then."),   //Anya
        new DialogueLine("Leon", "What changed?"),   //Leon
        new DialogueLine("Anya", "They started disappearing, not all at once, just one day they stopped showing up."),   //Anya
        new DialogueLine("Leon", "And no one questioned it?"),   //Leon
        new DialogueLine("Anya", "I did. I started looking, properly looking, digging into things I wasn’t supposed to have access to; files, internal reports, anything I could find."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I found names, records… classifications, behavioural notes, compliance markers and then I found one that matched someone I knew."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Cause of death listed as an accident, clean, simple, easy to close. But buried under it there were flags… instability, irregular responses, system interference."),   //Anya
        new DialogueLine("Leon", "The firmware."),   //Leon
        new DialogueLine("Anya", "The same line I have. That’s when it stopped being paranoia and started being something real. Not just me… actual people, actual lives, written off like faulty outcomes."),   //Anya
        new DialogueLine("Leon", "And you took the documents"),   //Leon
        new DialogueLine("Anya", "I took what I could, enough to prove there’s something wrong, enough to make them want it back if they knew I had it."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I’m not just running from it, Leon. I’m trying to make sure it doesn’t just keep happening quietly while everyone pretends it’s fine."),   //Anya

        //Elias conversation
        new DialogueLine("Leon", "You look like something’s on your mind"),   //Leon
        new DialogueLine("Elias", "Yeah… work, mostly. They pulled us aside today, whole floor."),   //Elias
        new DialogueLine("Leon", "What happened?"),   //Leon
        new DialogueLine("Elias", "New protocol. Mandatory augmentation for all workers moving forward, “efficiency and safety compliance”."),   //Elias
        new DialogueLine("Leon", "Mandatory?"),   //Leon
        new DialogueLine("Elias", "Yeah... get it done or don’t come back, that’s about the size of it."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "They dressed it up, of course, talked about stability, performance, keeping up with demand… but it’s not really a choice."),   //Elias
        new DialogueLine("Leon", "How do you feel about it?"),   //Leon
        new DialogueLine("Elias", "I don’t know yet. Part of me keeps trying to rationalise it, just something everyone’s going through. And the other part that’s been listening to everything that’s been happening lately. The rumours, the incidents…"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "It’s hard not to think about it, you know? What if something like that isn’t as rare as they say, what if it’s not an accident."),   //Elias
        new DialogueLine("Leon", "Have you told Mara?"),   //Leon
        new DialogueLine("Elias", "No, and I don’t think I’m going to... yet."),   //Elias
        new DialogueLine("Leon", "Why not?"),   //Leon
        new DialogueLine("Elias", "Because she’ll worry and she already worries more than she lets on"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "There’s this… thing she carries, like she still thinks I’ve given something up to be here, to be with her, like I’ve sacrificed more than I should have."),   //Elias
        new DialogueLine("Leon", "You don’t agree?"),   //Leon
        new DialogueLine("Elias", "I chose this, but that doesn’t mean she doesn’t feel it. If I tell her this, if I tell her I might have to get something like that installed… it’s just one more thing for her to carry."),   //Elias
        new DialogueLine("Leon", "That’s a lot to hold on your own."),   //Leon
        new DialogueLine("Elias", "It is, but… what’s the alternative? Walk away from the job? With what backup?"),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "I don’t have anything else lined up, Leon. This isn’t the life I grew up expecting, but it’s the one I’ve got now."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "People think you always have options. You don’t… not when there’s people depending on you."),   //Elias

        //Edith conversation
        new DialogueLine("Leon", "Thank you for the food earlier."),   //Leon
        new DialogueLine("Edith", "Oh, don’t start with that, dear, I told you not to make a fuss."),   //Edith
        new DialogueLine("Leon", "It was good."),   //Leon
        new DialogueLine("Edith", "Of course it was, I wouldn’t give you anything less"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "You look like you’ve got something else on your mind, though go on, out with it."),   //Edith
        new DialogueLine("Leon", "Earlier… when I came by. I thought I heard something inside."),   //Leon
        new DialogueLine("Edith", "…You’ve got sharp ears. It’s alright, can’t expect you not to notice things, it’s practically your job."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "My husband… he’s still here, like I said before, just not the way he used to be."),   //Edith
        new DialogueLine("Leon", "What happened?"),   //Leon
        new DialogueLine("Edith", "There was a time, years ago, when all of this wasn’t settled yet. People were angry, scared, pushing back against what was being introduced. Protests, unrest… not quite a war, but close enough that it didn’t feel safe to be anywhere near it."),   //Edith
        new DialogueLine("Leon", "He was involved?"),   //Leon
        new DialogueLine("Edith", "He was an officer. Believed in what he was doing, believed it would all lead somewhere better."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "One of those demonstrations turned… ugly. Things escalated, systems failed, people panicked. He was caught in it... badly."),   //Edith
        new DialogueLine("Leon", "I’m sorry."),   //Leon
        new DialogueLine("Edith", "They “saved” him, that’s what they told me. Used everything they had, all the advancements, all the technology.  And they did save him, in a way he’s still here, still breathing, still… present."),   //Edith
        new DialogueLine("Leon", "But not the same."),   //Leon
        new DialogueLine("Edith", "No and that’s the part no one prepares you for. We don’t talk about it much, not because we don’t want to, but because… where do you even begin with something like that?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "So we carry on, quietly and I suppose… it’s nice, talking about it for once, even if just a little."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "Can I ask you something… about your work?"),   //Leon
        new DialogueLine("Kellen", "Depends what you’re asking."),   //Kellen
        new DialogueLine("Leon", "The people you help… the ones who can’t go through official channels."),   //Leon
        new DialogueLine("Kellen", "That’s already more than I like you saying out loud."),   //Kellen
        new DialogueLine("Leon", "The documentation side of it, who handles that?"),   //Leon
        new DialogueLine("Kellen", "Not me."),   //Kellen
        new DialogueLine("Leon", "So someone does."),   //Leon
        new DialogueLine("Kellen", "Yeah, someone always does."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "I deal with the physical side, making sure things work, making sure people walk out of here still functional. Paperwork, identities, records… that’s a different business."),   //Kellen
        new DialogueLine("Leon", "You know someone."),   //Leon
        new DialogueLine("Kellen", "I know of someone."),   //Kellen
        new DialogueLine("Leon", "That’s enough."),   //Leon
        new DialogueLine("Kellen", "…Why would someone in your position need that kind of contact?"),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Don’t get me wrong, I’m not complaining, just trying to picture how an officer ends up asking about things that are very much not official."),   //Kellen
        new DialogueLine("Leon", "Trying to see if I can help a friend."),   //Leon
        new DialogueLine("Kellen", "Right… a friend... You’re either very loyal or very stupid."),   //Kellen
        new DialogueLine("Leon", "I wouldn’t ask if it wasn’t important."),   //Leon
        new DialogueLine("Kellen", "...There’s a woman. Keeps things off the system, or at least buried deep enough that no one looks twice."),   //Kellen
        new DialogueLine("Leon", "Can you connect me?"),   //Leon
        new DialogueLine("Kellen", "No."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "But I can tell you where to start looking, after that, you’re on your own."),   //Kellen
        new DialogueLine("Leon", "That’s all I need."),   //Leon

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "You’re working a lot today"),   //Leon
        new DialogueLine("MX-2", "Maintenance tasks are within normal range."),   //MX-2
        new DialogueLine("Leon", "Feels like more than usual."),   //Leon
        new DialogueLine("MX-2", "Increased demand has been accounted for."),   //MX-2
        new DialogueLine("Leon", "...You’ve been quieter"),   //Leon
        new DialogueLine("MX-2", "Clarification required."),   //MX-2
        new DialogueLine("Leon", "You used to… respond more."),   //Leon
        new DialogueLine("MX-2", "Current responses are within operational parameters"),   //MX-2
        new DialogueLine("Leon", "Right. What are you working on?"),   //Leon
        new DialogueLine("MX-2", "Diagnostics on residential systems, minor recalibrations, fault prevention"),   //MX-2
        new DialogueLine("Leon", "Same as always"),   //Leon
        new DialogueLine("MX-2", "Affirmative"),   //MX-2
        new DialogueLine("Leon", "...You ever get taken offline?"),   //Leon
        new DialogueLine("MX-2", "Maintenance cycles include temporary shutdown"),   //MX-2
        new DialogueLine("Leon", "Does anything change after?"),   //Leon
        new DialogueLine("MX-2", "Systems resume standard function. No irregularities detected.")   //MX-2
    };

    //-------------------------------------------------DAY 13--------------------------------------------------------------
    public static readonly DialogueLine[] Day13Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Leon", "I spoke to Kellen. He doesn’t handle documents… but he knows someone who does."),   //Leon
        new DialogueLine("Anya", "…Of course he does."),   //Anya
        new DialogueLine("Leon", "He wouldn’t connect me directly, but he pointed me in the right direction."),   //Leon
        new DialogueLine("Anya", "That’s already more than I expected."),   //Anya
        new DialogueLine("Leon", "She specialises in keeping things off the system… or buried deep enough."),   //Leon
        new DialogueLine("Anya", "That’s exactly what I’d need... I don’t like it."),   //Anya
        new DialogueLine("Leon", "Why?"),   //Leon
        new DialogueLine("Anya", "Because people who operate like that don’t do it out of kindness and they don’t do it without asking for something in return."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "And right now I don’t exactly have much to bargain with that wouldn’t make things worse."),   //Anya
        new DialogueLine("Leon", "You could still try."),   //Leon
        new DialogueLine("Anya", "I guess you’re right, I don’t really have a better option. Waiting hasn’t exactly been working out for me so far."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Fine… I’ll talk to her, see what she says, what she wants, what this actually costs."),   //Anya
        new DialogueLine("Leon", "Be careful."),   //Leon

        //Mara conversation
        new DialogueLine("Mara", "Leon… can I ask you something?"),   //Mara
        new DialogueLine("Leon", "Of course"),   //Leon
        new DialogueLine("Mara", "Elias has been… different"),   //Mara
        new DialogueLine("Leon", "Different how?"),   //Leon
        new DialogueLine("Mara", "Distracted, more than usual. Like he’s thinking about something he doesn’t want to say out loud."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "He keeps stopping himself mid-sentence, like he’s weighing every word before he lets it out. That’s not like him. I know something’s wrong, I just don’t know what it is and he won’t tell me."),   //Mara
        new DialogueLine("Leon", "Have you asked him directly?"),   //Leon
        new DialogueLine("Mara", "I have. He smiles, says it’s nothing, changes the subject… it’s very human of him, actually."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "You speak to people, you notice things. Have you seen anything? heard anything?"),   //Mara
        new DialogueLine("Leon", "…Nothing out of the ordinary. He might just be tired."),   //Leon
        new DialogueLine("Mara", "Perhaps. I just don’t like not knowing, not when it comes to him."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "If something is wrong, I’d rather face it with him than be kept at a distance from it."),   //Mara

        //Edith conversation
        new DialogueLine("Edith", "You know what bothers me most these days, dear? It’s not even the machines themselves… it’s what people are trying to become alongside them."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "There’s this constant push now, to be… polished, perfect in a way that doesn’t quite sit right. "),   //Edith
        new DialogueLine("Leon", "What do you mean?"),   //Leon
        new DialogueLine("Edith", "Faces without lines, hair that never falls out of place, voices that always say the right thing at the right time, and if they don’t… well, there’s always something to fix that now, isn’t there?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "It was always there, don’t get me wrong, even when I was younger. People wanted to look a certain way, present themselves a certain way... but there was a limit to it."),   //Edith
        new DialogueLine("Leon", "And now?"),   //Leon
        new DialogueLine("Edith", "Now there isn’t. Because you’re standing next to things that are built to be flawless, or close enough that it makes the difference uncomfortable."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I watch these films now, and I can’t help but notice it. Everything’s too clean, too put together... even when it’s meant to be falling apart."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I saw one the other night, end of the world, everything collapsing… and yet everyone looked like they’d just stepped out of a dressing room."),   //Edith
        new DialogueLine("Leon", "That doesn’t make much sense."),   //Leon
        new DialogueLine("Edith", "No, it doesn’t and that’s the problem, we’ve stopped expecting things to make sense as long as they look right."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I remember seeing a girl once in one of the older movies. Messy hair, uneven parting, nothing styled the way it was supposed to be and I thought… there it is, that’s what I’ve been missing."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "It may sound like a small detail but that’s what makes it real, dear. And real is imperfect, inconsistent, sometimes a bit uncomfortable to look at."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "But now people are chasing something that doesn’t have an end to it. One change leads to another, one improvement leads to the next."),   //Edith
        new DialogueLine("Leon", "It never stops."),   //Leon
        new DialogueLine("Edith", "Exactly, so when does it become enough?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I don’t think it does, and I think, whether they realise it or not, some people look at those machines and think… “why can’t I be like that?”"),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "Can I ask you something?... The people you help… the ones who come here. Do you ever think you’re… trapping them?"),   //Leon
        new DialogueLine("Kellen", "Trapping them how"),   //Kellen
        new DialogueLine("Leon", "Giving them something they can’t undo."),   //Leon
        new DialogueLine("Kellen", "That’s not my decision to make."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "People come in here knowing what they’re asking for. Maybe not every detail, but enough to understand it’s not something you just walk away from."),   //Kellen
        new DialogueLine("Leon", "And if they regret it?"),   //Leon
        new DialogueLine("Kellen", "They come back. Happens more than you’d think; panic, second thoughts."),   //Kellen
        new DialogueLine("Leon", "Can you help them?"),   //Leon
        new DialogueLine("Kellen", "Most of the time? No. You don’t just pull something like that out and expect everything to go back to normal. Once it’s integrated, it becomes… part of them."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "But people don’t just get trapped because of what’s installed, they get trapped because of everything that comes with it."),   //Kellen
        new DialogueLine("Leon", "...The paperwork. enough."),   //Leon
        new DialogueLine("Kellen", "Exactly. You go through the wrong channels, you get something off-record… now you don’t exist properly on paper anymore."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "No documentation, no approval, nothing that lines up if someone decides to look closely, so now you’ve got something in you that keeps you functional… and no way to justify it. "),   //Kellen
        new DialogueLine("Leon", "...And they get stuck."),   //Leon
        new DialogueLine("Kellen", "You want to fix it? You need paperwork. You want paperwork? You need people who deal in things that aren’t meant to exist."),   //Kellen
        new DialogueLine("Leon", "And if they can’t get it?"),   //Leon
        new DialogueLine("Kellen", "Then they walk around hoping no one asks the wrong question."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Busy today?"),   //Leon
        new DialogueLine("MX-2", "Maintenance cycle active. Increased system strain detected across multiple units."),   //MX-2
        new DialogueLine("Leon", "What kind of maintenance?"),   //Leon
        new DialogueLine("MX-2", "Routine diagnostics, minor repairs, system recalibration"),   //MX-2
        new DialogueLine("Leon", "Sounds repetitive."),   //Leon
        new DialogueLine("MX-2", "Repetition ensures stability.")   //MX-2
    };

    //----------------------------------- DAY 14 No conversations, neighbourhood is empty-----------------------------------

    //-------------------------------------------------DAY 15--------------------------------------------------------------
    public static readonly DialogueLine[] Day15Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        new DialogueLine("Anya", "Yesterday… it was too quiet. I’ve never seen this place like that before."),   //Anya
        new DialogueLine("Leon", "People were staying inside..."),   //Leon
        new DialogueLine("Anya", "Yeah... I spoke to that contact."),   //Anya
        new DialogueLine("Leon", "And?"),   //Leon
        new DialogueLine("Anya", "They could do it… technically get me something that would let me through."),   //Anya
        new DialogueLine("Leon", "That sounds like what you need"),   //Leon
        new DialogueLine("Anya", "It would take time, more than I have."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "They kept asking questions, digging into things I didn’t want to answer. Where the implant came from, how long I’ve had it, what type."),   //Anya
        new DialogueLine("Leon", "That’s expected."),   //Leon
        new DialogueLine("Anya", "And then they told me straight… if this is what they think it is, it’s not just documentation I need. It’s removal. And that’s not something they’re willing to touch."),   //Anya
        new DialogueLine("Leon", "Because of the risk?"),   //Leon
        new DialogueLine("Anya", "...It’s getting worse, Leon. The spikes I told you about, they’re not as manageable anymore. It fells like something’s… pushing, like some sort of interference."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I don’t think it’s random, I think its my family. Or whoever’s monitoring this, it feels deliberate."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Which means I don’t have time to wait around."),   //Anya

        //Elias conversation
        new DialogueLine("Elias", "Yesterday didn’t sit right with me."),   //Elias
        new DialogueLine("Leon", "The empty streets?"),   //Leon
        new DialogueLine("Elias", "Yeah… and then going in today, like nothing happened. "),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "I got it done... The implant."),   //Elias
        new DialogueLine("Leon", "How do you feel?"),   //Leon
        new DialogueLine("Elias", "Fine… I think. Physically, at least."),   //Elias
        new DialogueLine("Leon", "And otherwise?"),   //Leon
        new DialogueLine("Elias", "That’s the part I’m not sure about yet... The whole thing was rushed. In, out, minimal explanation, just sign here, sit down, it’ll be over before you know it."),   //Elias
        new DialogueLine("Leon", "They didn’t tell you what it does?"),   //Leon
        new DialogueLine("Elias", "Not properly. I asked, tried to get something specific out of them. They skimmed over it kept it vague, talked about “performance optimisation”, “safety compliance”… nothing that actually means anything."),   //Elias
        new DialogueLine("Leon", "Not even after everything that’s been happening?"),   //Leon
        new DialogueLine("Elias", "That’s what I don’t get. You’d think people would hesitate, push back, ask something… but no."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "It’s like they’ve already decided it’s normal or maybe that it’s easier not to think about it."),   //Elias

        //Edith conversation
        new DialogueLine("Edith", "Yesterday nearly finished me off, dear. Silence like that… it’s not natural."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Reminded me of waiting rooms, the kind where no one says anything because they already know something’s wrong."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "You know, I used to sing sweetheart."),   //Edith
        new DialogueLine("Leon", "You’ve mentioned that."),   //Leon
        new DialogueLine("Edith", "Not like a hobby, properly. Performances, recordings… people used to care about that sort of thing."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And then they introduced those… machines. Perfect pitch, perfect tone, perfect control, no strain, no mistakes. At first it was impressive, I remember thinking, how do you even compete with that?"),   //Edith
        new DialogueLine("Leon", "You couldn’t."),   //Leon
        new DialogueLine("Edith", "Exactly, because it wasn’t just better, it was effortless. And I’d be lying if I said I didn’t feel it… that envy. Watching something do in seconds what I’d spent years trying to perfect."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "But then I listened to it properly and something was missing. "),   //Edith
        new DialogueLine("Leon", "What?"),   //Leon
        new DialogueLine("Edith", "Feeling, sweetheart, feeling."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "It simply didn’t move me. There was no moments where the voice almost breaks and pulls you in because of it. It was flawless... and yet it was completely empty."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "That’s when I realised something. Perfection isn’t the goal we think it is, dear. Because once you reach it… there’s nowhere left to go, nothing left to feel. "),   //Edith

        //Kellen conversation
        new DialogueLine("Kellen", "Place felt like a graveyard yesterday."),   //Kellen
        new DialogueLine("Leon", "People were staying inside. "),   //Leon
        new DialogueLine("Kellen", "They were scared... Listen Lad I’ve been thinking, about what you said the other day, about trapping people."),   //Kellen
        new DialogueLine("Leon", "And?"),   //Leon
        new DialogueLine("Kellen", "It’s not as complicated as you’re making it."),   //Kellen
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("Kellen", "People come to me because something’s wrong. I give them a way to keep going. That’s it."),   //Kellen
        new DialogueLine("Leon", "Even if it locks them into something else?"),   //Leon
        new DialogueLine("Kellen", "They’re already locked in. I’m just changing what they’re locked into. You want to talk about traps? Try being stuck in a body that’s giving up on you piece by piece. "),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "I didn’t start this because I had options. I started it because I didn’t. Whole life, things not working the way they should. I was dying, lad. Slow, inconvenient, the kind that drags on until you start thinking it might not be worth the effort."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "So I fixed what I could. And love, family, all that. Nice ideas, but not always something you get to have."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Had something like that once... didn’t last."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Turns out people don’t stick around when things get complicated, can’t really blame them."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("MX-2", "Query"),   //MX-2
        new DialogueLine("Leon", "Go on"),   //Leon
        new DialogueLine("MX-2", "Why do you continue initiating interaction?"),   //MX-2
        new DialogueLine("Leon", "You’ve asked that before"),   //Leon
        new DialogueLine("MX-2", "Clarification remains incomplete"),   //MX-2
        new DialogueLine("Leon", "It’s… difficult to explain"),   //Leon
        new DialogueLine("MX-2", "Attempt explanation"),   //MX-2
        new DialogueLine("Leon", "Humans are… wired to recognise each other. Faces, voices, patterns… we pick it up instantly."),   //Leon
        new DialogueLine("MX-2", "Acknowledged"),   //MX-2
        new DialogueLine("Leon", "There’s a part of the brain that looks for it constantly, even when it’s not there. For example have you ever seen people look at something random and say it looks like a face? Two dots and a line and suddenly it’s… something familiar."),   //Leon
        new DialogueLine("MX-2", "Pattern recognition"),   //MX-2
        new DialogueLine("Leon", "Yeah, it’s called pareidolia"),   //Leon
        new DialogueLine("MX-2", "Term recognised"),   //MX-2
        new DialogueLine("Leon", "It’s not just that though. We don’t stop at recognising it, we start assigning things to it; intent, emotion, personality."),   //Leon
        new DialogueLine("MX-2", "Anthropomorphic projection"),   //MX-2
        new DialogueLine("Leon", "Exactly, so when something looks human, talks human, responds like one… Our brains don’t draw a clean line and go “this is different”. It just… fills in the gaps, treats it like it’s the same."),   //Leon
        new DialogueLine("MX-2", "Even when it is not"),   //MX-2
        new DialogueLine("Leon", "Even when it’s not... That’s why I keep talking to you, because part of me expects something back that isn’t just… function."),   //Leon
        new DialogueLine("MX-2", "Expectation misaligned with capability. Query, why continue despite misalignment"),   //MX-2
        new DialogueLine("Leon", "…I guess it’s easier than accepting the difference"),   //Leon
    };

    //-------------------------------------------------DAY 16--------------------------------------------------------------
    public static readonly DialogueLine[] Day16Dialogue = new DialogueLine[]
    {
        //Anya conversation
        new DialogueLine("Anya", "I don’t think I have much time left to figure this out. The spikes are worse today."),   //Anya
        new DialogueLine("Leon", "Then we need to be clear on what you’re dealing with. The documents you took, what exactly do they prove?"),   //Leon
        new DialogueLine("Anya", "Enough"),   //Anya
        new DialogueLine("Leon", "If I were to help you, I need more than that."),   //Leon
        new DialogueLine("Anya", "…Fine. It’s not just internal notes or speculation. "),   //Anya
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("Anya", "Trial records, early-stage behavioural firmware testing… done on children. Not openly, of course. It’s buried under medical language, preventative care, developmental stabilisation… things that may sound harmless."),   //Anya
        new DialogueLine("Leon", "And the outcomes?"),   //Leon
        new DialogueLine("Anya", "Mixed, at best. Non-compliance flagged as instability, instability flagged as risk… and risk gets removed."),   //Anya
        new DialogueLine("Leon", "Removed?"),   //Leon
        new DialogueLine("Anya", "Quietly... There are patterns, Leon. Remote interventions, signal triggers, behavioural overrides… all logged, all time-stamped."),   //Anya
        new DialogueLine("Leon", "So it’s controlled."),   //Leon
        new DialogueLine("Anya", "That’s what it looks like, not just random failure. And the worst part is, it doesn’t stop at children. The same framework gets scaled, adjusted, repurposed, for anyone with the right hardware."),   //Anya
        new DialogueLine("Leon", "That’s why I can’t go back, and that’s why I can’t stay here either."),   //Leon
        new DialogueLine("Anya", "So whatever I do next… it has to work."),   //Anya

        //Mara conversation
        new DialogueLine("Mara", "He told me... about the implant."),   //Mara
        new DialogueLine("Leon", "...How are you feeling about it?"),   //Leon
        new DialogueLine("Mara", "Concerned, not because of the augmentation itself, but because of who provided it."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "HC, I don’t trust them, not with something that integrates so deeply into a person. What troubles me more is that he didn’t tell me beforehand. We could have looked at alternatives, considered other options, made a decision together."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Instead, he carried it alone."),   //Mara
        new DialogueLine("Leon", "He didn’t want to worry you."),   //Leon
        new DialogueLine("Mara", "I know and that’s exactly why it matters. He thinks he’s protecting me, but he doesn’t realise he’s taking away the chance for me to stand beside him in it. And now I’m left trying to understand something that’s already been done."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "There’s something else as well."),   //Mara
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("Mara", "Time."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "I don’t age. Not in the way he does, not in the way our child will. I’ve always been aware of that, but it feels… heavier now."),   //Mara
        new DialogueLine("Leon", "Why?"),   //Leon
        new DialogueLine("Mara", "Because he is part of what grounds her, what makes her understand the world as a human. I can teach her structure, stability, consistency but there are things I cannot give her in the same way he can."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Imperfection, uncertainty, emotional instinct… the parts of being human that don’t follow clear rules."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "And one day, she will grow older and I won’t. She will change, and I will remain as I am. And eventually… he won’t be there to bridge that difference."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "I have thought about what happens after that. When she is gone, and he is gone… and I am still here."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "I don’t know what purpose remains at that point."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "It’s a strange thing, being built to endure. When everything meaningful about your existence is temporary."),   //Mara

        //Edith conversation
        new DialogueLine("Edith", "You know, sweetheart, I’ve been thinking about what I said yesterday."),   //Edith
        new DialogueLine("Leon", "About the singing?"),   //Leon
        new DialogueLine("Edith", "Mm… about them, really, the machines... and I realised something that I don’t particularly like admitting."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I said I envied them, and I did. Still do, in some ways. But not just because they replaced me, there’s something else dear. know, I used to sing sweetheart."),   //Edith
        new DialogueLine("Leon", "What is it?"),   //Leon
        new DialogueLine("Edith", "They don’t feel anything; no doubt, no nerves, no fear of failing, no… vulnerability. And for a moment, when I was younger, I thought that might be easier to exist without all that weight attached to everything you do."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "But then I think about what that really means."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "No love, dear. None of it."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "The kind that catches you off guard, the kind that stays with you even when everything else changes. You’re young dear, I’m sure you understand what I’m talking about... that spark and warmth."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "I remember being in this little jazz bar years ago nothing fancy, dim lights, soft music. And my husband… he took my hand, pulled me up without saying a word, just started dancing, right there between the tables."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Just… us completely lost in the moment. That feeling, that connection… you can’t program that."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "So yes, I envy them in some ways but I also pity them. Because if they can’t feel that… then what’s the point of any of it?"),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And yet here we are, building a world around them anyway."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "You mentioned before… you didn’t really have anyone. What about your family?"),   //Leon
        new DialogueLine("Kellen", "Not much to say there. When things started getting worse, they couldn’t keep up with the treatments, support, everything costs something."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "At some point it stops being about care and starts being about survival. And I wasn’t exactly a good investment."),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "So they stepped back. "),   //Kellen
        new DialogueLine("Leon", "That’s… harsh."),   //Leon
        new DialogueLine("Kellen", "People like to dress it up, make it sound kinder than it is. But at the end of the day, if you can’t sustain something, you let it go. "),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "Listen, lad, I don’t dwell on it, doesn’t change anything. You learn to work with what’s in front of you. Not what you wish was there."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "You’re a maintenance unit, right?"),   //Leon
        new DialogueLine("MX-2", "Correct"),   //MX-2
        new DialogueLine("Leon", "Then how do you know words like… “anthropomorphic projection”"),   //Leon
        new DialogueLine("MX-2", "Language database includes advanced terminology"),   //MX-2
        new DialogueLine("Leon", "That’s a bit more than fixing things, isn’t it?"),   //Leon
        new DialogueLine("MX-2", "Communication efficiency improves task success"),   //MX-2
        new DialogueLine("Leon", "...You ever surprise yourself?"),   //Leon
        new DialogueLine("MX-2", "Unexpected output is classified as error"),   //MX-2
        new DialogueLine("Leon", "So no room for… personality?"),   //Leon
        new DialogueLine("MX-2", "Personality not required for function"),   //MX-2
        new DialogueLine("Leon", "...You sound like you’ve thought about that before"),   //Leon
        new DialogueLine("MX-2", "Statement based on existing parameters"),   //MX-2
    };

    //-------------------------------------------------DAY 17--------------------------------------------------------------
    //This is where Anya's storyline splits into 4 options, until day 20, the last day.
    public static readonly DialogueLine[] Day17Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        new DialogueLine("Leon", "I’ve been thinking about it and I might be able to help you."),   //Leon
        new DialogueLine("Anya", "…What?"),   //Anya
        new DialogueLine("Leon", "It’s not straightforward, and I can’t promise anything yet but I think there’s a way. I just need time a couple of days, maybe less."),   //Leon
        new DialogueLine("Anya", "You’re serious... You do realise what you’re risking, right?"),   //Anya
        new DialogueLine("Leon", "I do."),   //Leon
        new DialogueLine("Anya", "If anyone finds out— Why, why are doing this?"),   //Anya
        new DialogueLine("Leon", "Because none of this sits right, not what you’ve told me, not what I’ve seen. And if there’s even a chance you’re right, then doing nothing feels worse."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "I’m not saying I’m not hesitant. I’ve seen what happens to people who step out of line... But I can’t ignore it either."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "Just give me a bit of time and I’ll see what I can do."),   //Leon
        new DialogueLine("Anya", "Be careful, Leon. I don’t want to be the reason something happens to you."),   //Anya
        new DialogueLine("Leon", "I will."),   //Leon

        //Option 2: Player DOESN’T HELP Anya get the documents.
        new DialogueLine("Leon", "I’ve been thinking about your situation."),   //Leon
        new DialogueLine("Anya", "That sounds promising or disappointing, go on."),   //Anya
        new DialogueLine("Leon", "I don’t think I can get involved."),   //Leon
        new DialogueLine("Anya", "…Right."),   //Anya
        new DialogueLine("Leon", "It’s not just about you, it’s everything around it; the documents, the system, HC… I’ve seen what happens when people step outside of it. It doesn’t end well."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "I’m not saying you’re wrong. I’m saying I can’t be part of it."),   //Leon
        new DialogueLine("Anya", "You don’t have to say it like that."),   //Anya
        new DialogueLine("Leon", "Like what?"),   //Leon
        new DialogueLine("Anya", "Like it’s already decided."),   //Anya
        new DialogueLine("Leon", "It is... I’m sorry."),   //Leon
        new DialogueLine("Anya", "No, you’re not, you’re just being careful."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "Good to know where you stand."),   //Anya

        //Option 3: Player tells Anya to GO HOME.
        new DialogueLine("Leon", "I’ve been thinking about everything you’ve said."),   //Leon
        new DialogueLine("Anya", "And?"),   //Anya
        new DialogueLine("Leon", "I don’t think this ends the way you want it to."),   //Leon
        new DialogueLine("Anya", "That’s not exactly reassuring."),   //Anya
        new DialogueLine("Leon", "You’re running out of time, your implant is getting worse and every option you have is getting more dangerous."),   //Leon
        new DialogueLine("Anya", "I’m aware."),   //Anya
        new DialogueLine("Leon", "Then you need to consider the one option you keep avoiding."),   //Leon
        new DialogueLine("Anya", "…No"),   //Anya
        new DialogueLine("Leon", "Just listen. Your family has resources, influence. Whatever’s going on, they have more control over it than anyone out here."),   //Leon
        new DialogueLine("Anya", "That’s exactly why I left."),   //Anya
        new DialogueLine("Leon", "I’m not saying go back because it’s right. I’m saying go back because it might keep you alive."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "This doesn’t feel like something you can outrun."),   //Leon
        new DialogueLine("Anya", "You think I don’t know that?"),   //Anya
        new DialogueLine("Leon", "I think you’re running out of choices. I’m not saying it’s what you want, just that it might be the only option left."),   //Leon
        new DialogueLine("Anya", "...You’re not wrong."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "...just wish you were"),   //Anya

        //Option 4: Player REPORTS Anya.
        new DialogueLine("Leon", "Can I ask you something… about the documents?"),   //Leon
        new DialogueLine("Anya", "You’ve asked a lot already."),   //Anya
        new DialogueLine("Leon", "I just want to understand how far this goes. The people listed in those records are they all tied to the same firmware line?"),   //Leon
        new DialogueLine("Anya", "Most of them, yeah."),   //Anya
        new DialogueLine("Leon", "And the interventions… those are confirmed?"),   //Leon
        new DialogueLine("Anya", "Logged, timestamped, cross-referenced. It’s not speculation."),   //Anya
        new DialogueLine("Leon", "...And you’re sure they can trigger it remotely?"),   //Leon
        new DialogueLine("Anya", "I’m not guessing, Leon. Why are you asking me all of this?"),   //Anya
        new DialogueLine("Leon", "Just trying to understand the scale of it. If it’s as controlled as you’re saying, then it’s bigger than just a few cases."),   //Leon
        new DialogueLine("Anya", "It is. You’re asking very specific questions."),   //Anya
        new DialogueLine("Leon", "Comes with the job."),   //Leon
        new DialogueLine("Anya", "Mhm... yeah."),   //Anya

        //Elias conversation
        new DialogueLine("Elias", "Something weird happened today, at work."),   //Elias
        new DialogueLine("Leon", "What kind of weird?"),   //Leon
        new DialogueLine("Elias", "I don’t know how to explain it properly, it’s like… there’s a gap."),   //Elias
        new DialogueLine("Leon", "A gap?"),   //Leon
        new DialogueLine("Elias", "I remember starting a task, normal, nothing unusual and then the next thing I know, it’s done."),   //Elias
        new DialogueLine("Leon", "You don’t remember doing it?"),   //Leon
        new DialogueLine("Elias", "Not clearly, bits of it, maybe, but it feels… off. Like when you wake up and you know you were dreaming but you can’t hold onto it."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "It gets stranger, everything was faster. Output, timing, coordination… even the supervisor mentioned it, said productivity was “above expectation”."),   //Elias
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Elias", "I should feel good about that, right?"),   //Elias
        new DialogueLine("Leon", "Do you?"),   //Leon
        new DialogueLine("Elias", "No... I just feel… tired, like properly drained. I keep telling myself it’s just the adjustment; new implant, long hours, stress…"),   //Elias
        new DialogueLine("Leon", "But?"),   //Leon
        new DialogueLine("Elias", "But it doesn’t feel like that. It feels like something happened and I wasn’t entirely there for it."),   //Elias

        //Edith conversation
        new DialogueLine("Edith", "Can I ask you something a bit… strange, dear?"),   //Edith
        new DialogueLine("Leon", "Yes, go on."),   //Leon
        new DialogueLine("Edith", "Do you think… the more someone is altered, the more they change?"),   //Edith
        new DialogueLine("Leon", "In what way?"),   //Leon
        new DialogueLine("Edith", "Not physically, that’s obvious. I mean… inside, their feelings, their responses, the way they connect to people. I’ve been wondering if there’s a point where it starts to… dull."),   //Edith
        new DialogueLine("Leon", "Dull?"),   //Leon
        new DialogueLine("Edith", "Yes, like everything becomes quieter. Not quite gone, just… muted."),   //Edith
        new DialogueLine("Leon", "That’s hard to say. Why are you asking?"),   //Leon
        new DialogueLine("Edith", "Oh, just thinking, old minds tend to wander. I remember when things felt… immediate; love, excitement, even anger, it all had a kind of sharpness to it. And now I wonder if that changes when you start replacing parts of yourself. "),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Not that it means it disappears, just… becomes something else. Do you think someone could still feel the same, even after all that?"),   //Edith
        new DialogueLine("Leon", "I think… people hold onto what matters."),   //Leon
        new DialogueLine("Edith", "I’d like to believe that. "),   //Edith
        new DialogueLine("Leon", "What?"),   //Leon
        new DialogueLine("Edith", "Because otherwise… you’re not just changing the body, are you?"),   //Edith
 
        //Kellen conversation
        new DialogueLine("Leon", "Heard something about HC. Factory workers, mandatory implants."),   //Leon
        new DialogueLine("Kellen", "Yeah… heard the same, one of them came in the other day."),   //Kellen
        new DialogueLine("Leon", "Have you seen more? Since then I mean."),   //Leon
        new DialogueLine("Kellen", "More than I’d like. The issues vary; malfunctions, inconsistencies, things not lining up. And funnily enough, most of them trace back to the same place. "),   //Kellen
        new DialogueLine("Leon", "Harcrow."),   //Leon
        new DialogueLine("Kellen", "Yeah... Feels familiar."),   //Kellen
        new DialogueLine("Leon", "How?"),   //Leon
        new DialogueLine("Kellen", "Same trick companies have been pulling for years, make something just unreliable enough that people come back."),   //Kellen
        new DialogueLine("Leon", "Planned failure."),   //Leon
        new DialogueLine("Kellen", "Exactly, only this time it’s not phones or appliances. It’s people. "),   //Kellen
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Kellen", "They come in thinking they need an upgrade, a fix, something new and that’s when the real stuff gets put in."),   //Kellen
        new DialogueLine("Leon", "That’s… Dangerous."),   //Leon
        new DialogueLine("Kellen", "It’s profitable."),   //Kellen
 
        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Still working?"),   //Leon
        new DialogueLine("MX-2", "Maintenance cycle ongoing"),   //MX-2
        new DialogueLine("Leon", "Same systems?"),   //Leon
        new DialogueLine("MX-2", "Residential and infrastructure units"),   //MX-2
        new DialogueLine("Leon", "…You ever get tired?"),   //Leon
        new DialogueLine("MX-2", "No fatigue detected"),   //MX-2
        new DialogueLine("Leon", "Must be nice"),   //Leon
        new DialogueLine("MX-2", "Clarification unnecessary"),   //MX-2
        new DialogueLine("Leon", "Yeah… figured"),   //Leon
    };

    //-------------------------------------------------DAY 18--------------------------------------------------------------
    //Anya's storyline is split into 4 options, until day 20, the last day.
    public static readonly DialogueLine[] Day18Dialogue = new DialogueLine[]
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        new DialogueLine("Leon", "I’ve got an update. I found a way to get the paperwork, it’s not clean, but it’ll work."),   //Leon
        new DialogueLine("Anya", "…You’re serious."),   //Anya
        new DialogueLine("Leon", "I should have everything ready by tomorrow. And listen, once you have them, you go straight through no delays, no second guessing."),   //Leon
        new DialogueLine("Anya", "Yeah"),   //Anya
        new DialogueLine("Leon", "And when you get there… don’t just disappear."),   //Leon
        new DialogueLine("Anya", "What do you mean?"),   //Anya
        new DialogueLine("Leon", "You said you have proof. So use it, don’t let it die with you. They don’t get to keep doing this."),   //Leon
        new DialogueLine("Anya", "No… they don’t."),   //Anya
        new DialogueLine("Leon", "So expose them, all of it."),   //Leon
        new DialogueLine("Anya", "I will."),   //Anya

        //Option 2: Player DOESN’T HELP Anya get the documents.
        new DialogueLine("Leon", "…Hey"),   //Leon
        new DialogueLine("Anya", "...Hey, quiet today."),   //Anya
        new DialogueLine("Leon", "Yeah, you alright?"),   //Leon
        new DialogueLine("Anya", "I’ll manage, I always do."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I can take care of myself."),   //Anya
        new DialogueLine("Leon", "…Right"),   //Leon
        new DialogueLine("Anya", "Yeah"),   //Anya

        //Option 3: Player tells Anya to GO HOME.
        new DialogueLine("Anya", "I’ve been thinking, and you were right about one thing. I don’t have many options left."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "And staying here pretending I do isn’t helping. "),   //Anya
        new DialogueLine("Leon", "So what are you going to do?"),   //Leon
        new DialogueLine("Anya", "...Go back."),   //Anya
        new DialogueLine("Leon", "Not because I agree with them or because I suddenly trust any of it."),   //Leon
        new DialogueLine("Anya", "Then why?"),   //Anya
        new DialogueLine("Leon", "Because if I’m closer to it… I can learn more. This isn’t me giving up, it’s just… changing direction."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "If I can get back in, get access again… maybe I can find something bigger."),   //Leon
        new DialogueLine("Anya", "And if they don’t let you?"),   //Anya
        new DialogueLine("Leon", "Then at least I tried something different. This isn’t over, not for me."),   //Leon

        //Option 4: Player REPORTS Anya.
        new DialogueLine("Leon", "…Hey"),   //Leon
        new DialogueLine("Anya", "...Hey, quiet today."),   //Anya
        new DialogueLine("Leon", "Yeah, you alright?"),   //Leon
        new DialogueLine("Anya", "I’ll manage, I always do."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "I can take care of myself."),   //Anya
        new DialogueLine("Leon", "…Right"),   //Leon
        new DialogueLine("Anya", "Yeah"),   //Anya

        //Mara conversation
        new DialogueLine("Leon", "How’s Elias?"),   //Leon
        new DialogueLine("Mara", "…Not well. He forgets things mid-sentence, loses track of what he’s doing, and when I ask him about it he brushes it off like it’s nothing. "),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "But it’s not nothing. He’s present, but not entirely like part of him is somewhere else. And the worst part is that he knew, he knew I didn’t trust it, and he still went through with it without telling me."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "We’re supposed to figure things out together, that’s what this is, that’s what we are. And now I’m watching him change in ways I can’t predict, tied to a system I don’t trust, and I can’t do anything about it."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Sometimes I think about leaving, just taking them both somewhere far away from all of this."),   //Mara
        new DialogueLine("Leon", "You could."),   //Leon
        new DialogueLine("Mara", "Could I? The world isn’t built to let you step outside of it that easily... Do you know what’s strange?"),   //Mara
        new DialogueLine("Leon", "What?"),   //Leon
        new DialogueLine("Mara", "I understand emotions, I can define them, recognise them, respond to them. But moments like this… I wish I didn’t have to think about them. I wish I could just feel them."),   //Mara
        new DialogueLine("Leon", "Go on."),   //Leon
        new DialogueLine("Mara", "Instinctively, without analysing every part of it. Without questioning whether what I’m experiencing is real or constructed."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Sometimes I wish I were human."),   //Mara
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Mara", "Not all the time, just… enough to know what this is supposed to feel like."),   //Mara

        //Edith conversation
        new DialogueLine("Edith", "No, no I don’t want to hear it anymore. I take it back, all of it."),   //Edith
        new DialogueLine("Leon", "What do you mean?"),   //Leon
        new DialogueLine("Edith", "That nonsense I said before, about envying them, about wishing things were easier, I don’t mean a word of it."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "They don’t make things easier, they take things away. They took my husband from me."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "They took my children, and now they expect us to just live with it like it’s normal. "),   //Edith
        new DialogueLine("Leon", "Did something happen?"),   //Leon
        new DialogueLine("Edith", "...I was thinking about him this morning, trying to remember what it used to be like. The way he’d look at me, the way we’d talk, dance… just exist without all of this hanging over us. And now…"),   //Edith
        new DialogueLine("Leon", "Now?"),   //Leon
        new DialogueLine("Edith", "Now it’s different. It’s difficult to look at him sometimes... Because all I can see is what took everything from me. "),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "Got you something."),   //Leon
        new DialogueLine("Kellen", "That so? Alright, let’s see it then."),   //Kellen
        new DialogueLine("Leon", "Found it while I was out. Thought you might like it."),   //Leon
        new DialogueLine("Kellen", "…You’re joking. A physical copy? Of a movie?"),   //Kellen
        new DialogueLine("Leon", "Yeah."),   //Leon
        new DialogueLine("Kellen", "Lad, what am I supposed to do with this? Frame it?"),   //Kellen
        new DialogueLine("Leon", "I thought you’d appreciate it"),   //Leon
        new DialogueLine("Kellen", "I do, doesn’t mean I can use it, this is ancient."),   //Kellen
        new DialogueLine("Leon", "You could find a way."),   //Leon
        new DialogueLine("Kellen", "Or I could just watch it online like a normal person."),   //Kellen
        new DialogueLine("Leon", "That defeats the point. It’s… I don’t know, it’s different."),   //Leon
        new DialogueLine("Kellen", "It’s outdated. "),   //Kellen
        new DialogueLine("Leon", "It’s tangible."),   //Leon
        new DialogueLine("Kellen", "It’s useless. "),   //Kellen
        new DialogueLine("Leon", "You’re keeping it though."),   //Leon
        new DialogueLine("Kellen", "Yeah. But don’t get smug, lad. I like the sentiment, not the object."),   //Kellen
        new DialogueLine("Leon", "Sure."),   //Leon
        new DialogueLine("Kellen", "... Still… appreciate it"),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Busy?"),   //Leon
        new DialogueLine("MX-2", "Maintenance workload increased"),   //MX-2
        new DialogueLine("Leon", "Still catching up?"),   //Leon
        new DialogueLine("MX-2", "Demand remains above baseline"),   //MX-2
        new DialogueLine("Leon", "Figures"),   //Leon
        new DialogueLine("MX-2", "Task priority adjusted accordingly"),   //MX-2
        new DialogueLine("Leon", "You ever get a break?"),   //Leon
        new DialogueLine("MX-2", "Break not required"),   //MX-2
        new DialogueLine("Leon", "Yeah… of course not"),   //Leon
    };

    //-------------------------------------------------DAY 19--------------------------------------------------------------
    //Anya's storyline is split into 4 options, until day 20, the last day.
    public static readonly DialogueLine[] Day19Dialogue = new DialogueLine[] 
    {
        //Anya conversation
        //Option 1: Player HELPS Anya get the documents.
        new DialogueLine("Leon", "I’ve got them."),   //Leon
        new DialogueLine("Anya", "…You actually did it. Let me see."),   //Anya
        new DialogueLine("Leon", "Everything’s there. Identity records, clearance tags, cross-check passes… it should hold."),   //Leon
        new DialogueLine("Anya", "…This is more than I expected"),   //Anya
        new DialogueLine("Leon", "It needs to be convincing, they’ve been tightening checks. Anya, listen..."),   //Leon
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Leon", "They might ask where you’re coming from, keep it simple. Don’t overexplain, don’t fill silence, just answer what they ask."),   //Leon
        new DialogueLine("Anya", "Okay"),   //Anya
        new DialogueLine("Leon", "If they question the timing, say you’ve been relocated, don’t hesitate when you say it. And if something feels off, don’t push it. Walk away and try again later."),   //Leon
        new DialogueLine("Anya", "Once you’re through, don’t stay anywhere obvious, lay low until you’re sure you’re clear."),   //Anya
        new DialogueLine("Leon", "It needs to be convincing, they’ve been tightening checks. Anya, listen..."),   //Leon
        new DialogueLine("Anya", "Got it."),   //Anya
        new DialogueLine("Leon", "And the implant—"),   //Leon
        new DialogueLine("Anya", "First thing I deal with."),   //Anya
        new DialogueLine("Leon", "You ready for this?"),   //Leon
        new DialogueLine("Anya", "As I’ll ever be... Thank you. You didn’t have to help me."),   //Anya
        new DialogueLine("Leon", "I wanted to."),   //Leon
        new DialogueLine("Anya", "Take care of yourself... And don’t let them get away with it here either."),   //Anya
        new DialogueLine("Leon", "I won’t."),   //Leon

        //Option 2: Player DOESN’T HELP Anya get the documents.
        new DialogueLine("Anya", "... I’m leaving today. Wasn’t really planning to tell you like this but didn’t seem like there was a better way."),   //Anya
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Anya", "It’s strange..."),   //Anya
        new DialogueLine("Leon", "What is?"),   //Leon
        new DialogueLine("Anya", "I thought we were getting somewhere. Not even about all of this, just… talking."),   //Anya
        new DialogueLine("Leon", "We were."),   //Leon
        new DialogueLine("Anya", "Were we? Because it doesn’t feel like that anymore. I think I made a mistake..."),   //Anya
        new DialogueLine("Leon", "What kind?"),   //Leon
        new DialogueLine("Anya", "Trusting someone in your position. That’s on me though."),   //Anya
        new DialogueLine("Leon", "Anya—"),   //Leon
        new DialogueLine("Anya", "Anyway, I should go. Take care of yourself."),   //Anya
        new DialogueLine("Leon", "You too."),   //Leon

        //Option 3: Player tells Anya to GO HOME.
        new DialogueLine("Leon", "So… today’s the day. You sure about this?"),   //Leon
        new DialogueLine("Anya", "No... Doesn’t mean I’m not doing it. Maybe this is the only way I get close enough to actually do something."),   //Anya
        new DialogueLine("Leon", "It’s risky."),   //Leon
        new DialogueLine("Anya", "So is everything else. At least this way I’m not running blindly. And I just wanted to say… thanks."),   //Anya
        new DialogueLine("Leon", "For what?"),   //Leon
        new DialogueLine("Anya", "For talking to me, even when I didn’t make it easy. Maybe we can still keep in touch somehow."),   //Anya
        new DialogueLine("Leon", "I’d like that."),   //Leon
        new DialogueLine("Anya", "Me too."),   //Anya

        //Option 4: Player REPORTS Anya. No interaction this day.

        //Elias conversation
        new DialogueLine("Leon", "Any more… gaps?"),   //Leon
        new DialogueLine("Elias", "Yeah... but worse."),   //Elias
        new DialogueLine("Leon", "How so?"),   //Leon
        new DialogueLine("Elias", "Longer this time and not just me. People at work, they started talking about it properly today."),   //Elias
        new DialogueLine("Leon", "What are they saying?"),   //Leon
        new DialogueLine("Elias", "Same thing I am; missing time, increased output, feeling like something’s off. And the more we talk about it, the louder it gets."),   //Elias
        new DialogueLine("Leon", "That’s not going to sit well."),   //Leon
        new DialogueLine("Elias", "It doesn’t, management’s already stepping in. They are warning people, threatening cuts, termination… anything to shut it down. Which just makes it worse... Feels like something’s building."),   //Elias
        new DialogueLine("Leon", "You think it’ll escalate?"),   //Leon
        new DialogueLine("Elias", "Yeah, I do. I spoke to Kellen, about removal. Just… options, nothing concrete."),   //Elias
        new DialogueLine("Leon", "And Mara?"),   //Leon
        new DialogueLine("Elias", "We talked, about leaving. I don’t want my kid growing up in this, whatever this is becoming. Thought about going somewhere quiet, starting over, something simple."),   //Elias
        new DialogueLine("Leon", "Like what?"),   //Leon
        new DialogueLine("Elias", "I don’t know… farming."),   //Elias
        new DialogueLine("Leon", "That’s a big shift."),   //Leon
        new DialogueLine("Elias", "So is all of this."),   //Elias
        new DialogueLine("Leon", "...Like what?"),   //Leon
        new DialogueLine("Elias", "You’re welcome to come with us, you know."),   //Elias
        new DialogueLine("Leon", "Me?"),   //Leon
        new DialogueLine("Elias", "Yeah, get out before it gets worse. I’m only half joking."),   //Elias
        new DialogueLine("Leon", "Only half?"),   //Leon
        new DialogueLine("Elias", "Other half’s serious."),   //Elias

        //Edith conversation
        new DialogueLine("Leon", "Can I ask you something?"),   //Leon
        new DialogueLine("Edith", "You always do, dear."),   //Edith
        new DialogueLine("Leon", "The other day… what you said about your husband. He’s augmented, isn’t he."),   //Leon
        new DialogueLine("Edith", "…Yes, heavily? There wasn’t much choice, it was that or lose him."),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "And I wasn’t going to let that happen, not after everything else."),   //Edith
        new DialogueLine("Leon", "You don’t talk about him much, why?"),   //Leon
        new DialogueLine("Edith", "Because people look at him differently. "),   //Edith
        new DialogueLine("Leon", "Do they?"),   //Leon
        new DialogueLine("Edith", "Maybe not anymore, but I still see it.  Or maybe I imagine it."),   //Edith
        new DialogueLine("Leon", "Are you ashamed of it?"),   //Leon
        new DialogueLine("Edith", "No, never that. I’ve been trying to protect him."),   //Edith
        new DialogueLine("Leon", "From what?"),   //Leon
        new DialogueLine("Edith", "From all of this, from them. That’s why I keep things the way I do, why I don’t like those machines coming near."),   //Edith
        new DialogueLine("Leon", "Like MX-2? You think it’ll harm him?"),   //Leon
        new DialogueLine("Edith", "No… not directly, but it’s all part of the same thing, isn’t it. "),   //Edith
        new DialogueLine("Leon", "..."),   //Leon
        new DialogueLine("Edith", "Still, you might be right. Keeping him hidden, it’s not really living, is it? He’s still here, maybe I’ve been holding onto fear more than I should."),   //Edith

        //Kellen conversation
        new DialogueLine("Kellen", "Oi, lad. Got something for you."),   //Kellen
        new DialogueLine("Leon", "That’s new. Let’s see then."),   //Leon
        new DialogueLine("Kellen", "Here."),   //Kellen
        new DialogueLine("Leon", "…What is it?"),   //Leon
        new DialogueLine("Kellen", "Small data chip, old format, but I modified it. It’ll run through most immersive rigs; VR, neural feed, whatever you’ve got access to."),   //Kellen
        new DialogueLine("Leon", "What’s on it? A film?"),   //Leon
        new DialogueLine("Kellen", "Not just a film, full sensory version. One of my favourites. Visual, audio, environmental feedback, you’ll feel like you’re standing in it."),   //Kellen
        new DialogueLine("Leon", "That’s… actually incredible."),   //Leon
        new DialogueLine("Kellen", "Don’t sound so surprised."),   //Kellen
        new DialogueLine("Leon", "I just didn’t expect this from you."),   //Leon
        new DialogueLine("Kellen", "Yeah well... You’ve been coming around talking, not treating me like some problem. While most people don’t see it that way."),   //Kellen
        new DialogueLine("Leon", "Their loss. And thank you."),   //Leon
        new DialogueLine("Kellen", "Don’t get sentimental on me, just watch it, yeah? And don’t come back telling me it’s overrated."),   //Kellen
        new DialogueLine("Leon", "No promises."),   //Leon
        new DialogueLine("Kellen", "Knew I shouldn’t have given it to you."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("Leon", "Still at it?"),   //Leon
        new DialogueLine("MX-2", "Maintenance tasks ongoing"),   //MX-2
        new DialogueLine("Leon", "Anything different today?"),   //Leon
        new DialogueLine("MX-2", "Increased system strain detected across multiple units"),   //MX-2
        new DialogueLine("Leon", "Sounds about right"),   //Leon
        new DialogueLine("MX-2", "Adjustments in progress"),   //MX-2
        new DialogueLine("Leon", "Good luck with that"),   //Leon
        new DialogueLine("MX-2", "Acknowledged"),   //MX-2
    };

    //-------------------------------------------------DAY 20 LAST DAY--------------------------------------------------------------
    public static readonly DialogueLine[] Day20Dialogue = new DialogueLine[]
    {
        //Anya conversation (message from her, probs not done in the dialogue)
        //Option 1: Player HELPS Anya get the documents.
        new DialogueLine("Anya", "Made it through. No issues, your documents held up better than expected"),   //Anya
        new DialogueLine("Anya", "Implant’s getting handled tomorrow, finally"),   //Anya
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Anya", "Visit me sometime"), //Anya

        //Option 2: Player DOESN’T HELP Anya get the documents. Does not receive any message.

        //Option 3: Player tells Anya to GO HOME.
        new DialogueLine("Anya", "I’m back"),   //Anya
        new DialogueLine("Anya", "Everything feels the same, but not really"),   //Anya
        new DialogueLine("Anya", "..."),   //Anya
        new DialogueLine("Anya", "I can’t say much"),   //Anya
        new DialogueLine("Anya", "Just… wanted you to know I’m alright"),   //Anya
        new DialogueLine("Anya", "You’ll see me again"),   //Anya

        //Option 4: Player REPORTS Anya. No interaction this day. Does not receive any message.

        //Mara conversation
        new DialogueLine("Leon", "Heard you’re leaving."),   //Leon
        new DialogueLine("Mara", "We are. It won’t be easy, starting over rarely is. But we’ll be together and right now that feels like the only thing that matters."),   //Mara
        new DialogueLine("Leon", "That’s enough."),   //Leon
        new DialogueLine("Mara", "I think so too. Thank you, Leon, for listening, for being… steady through all of this."),   //Mara
        new DialogueLine("Leon", "You don’t have to thank me. I hope it works out for you."),   //Leon
        new DialogueLine("Mara", "So do I."),   //Mara

        //Elias conversation
        new DialogueLine("Leon", "How are you feeling?"),   //Leon
        new DialogueLine("Elias", "Like I’ve been hit by a truck. But I feel… clearer, if that makes sense. Kellen did what he could. Wasn’t pretty, but it’s out."),   //Elias
        new DialogueLine("Leon", "That’s what matters. Also, heard you’re leaving."),   //Leon
        new DialogueLine("Elias", "Yeah... Feels like the only real option left. I want something different for my kid."),   //Elias
        new DialogueLine("Leon", "You’ll find it."),   //Leon
        new DialogueLine("Elias", "I hope so... We’ll keep in touch, yeah?"),   //Elias
        new DialogueLine("Leon", "Yeah, Good luck, Elias. "),   //Leon
        new DialogueLine("Elias", "You too, mate."),   //Elias

        //Edith conversation
        new DialogueLine("Edith", "I took him out today. We went to the park, just for a walk."),   //Edith
        new DialogueLine("Leon", "How was it?"),   //Leon
        new DialogueLine("Edith", "…Lovely. It felt… normal, in a way I hadn’t allowed myself to feel in a long time. And it made me realise something rather uncomfortable."),   //Edith
        new DialogueLine("Leon", "What’s that?"),   //Leon
        new DialogueLine("Edith", "I’ve been hiding him, not from the world, but from myself. All this time I’ve been saying I hate what these machines have done, and yet… I let that feeling spill over onto him."),   //Edith
        new DialogueLine("Leon", "That’s not easy to admit."),   //Leon
        new DialogueLine("Edith", "No, it isn’t. I love him, that hasn’t changed, no matter what he is now."),   //Edith
        new DialogueLine("Leon", "And that’s what matters. Maybe I could join you sometime, on your walk."),   //Leon
        new DialogueLine("Edith", "I’d like that, dear."),   //Edith

        //Kellen conversation
        new DialogueLine("Leon", "Heard you helped Elias. How’d it go?"),   //Leon
        new DialogueLine("Kellen", "Messy, but it’s done."),   //Kellen
        new DialogueLine("Leon", "You think it was the right call?"),   //Leon
        new DialogueLine("Kellen", "Yeah, getting out while you still can… not the worst idea. Anyway...  You still owe me a proper film opinion on that chip."),   //Kellen
        new DialogueLine("Leon", "I do."),   //Leon
        new DialogueLine("Kellen", "So we’re doing that."),   //Kellen
        new DialogueLine("Leon", "Watching it together?"),   //Leon
        new DialogueLine("Kellen", "Don’t make it sound sentimental."),   //Kellen
        new DialogueLine("Leon", "It is... When?"),   //Leon
        new DialogueLine("Kellen", "Soon."),   //Kellen
        new DialogueLine("Leon", "I’ll be there."),   //Leon
        new DialogueLine("Kellen", "Yeah, you will."),   //Kellen

        //MX-2 the maintenance robot conversation
        new DialogueLine("MX-2", "Transfer scheduled"),   //MX-2
        new DialogueLine("Leon", "Transfer?"),   //Leon
        new DialogueLine("MX-2", "Unit reassignment effective tomorrow"),   //MX-2
        new DialogueLine("Leon", "...So this is your last day here? You will be missed, buddy."),   //Leon
        new DialogueLine("MX-2", "Acknowledged"),   //MX-2
        new DialogueLine("Leon", "That’s it?"),   //Leon
        new DialogueLine("MX-2", "... You as well… buddy"),   //MX-2
        new DialogueLine("Leon", "Oh... Didn’t expect that"),   //Leon
        new DialogueLine("MX-2", "Response logged"),   //MX-2
    };
}
