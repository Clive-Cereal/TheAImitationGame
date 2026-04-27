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
        "Sera Lund"
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
        "Holiday. My first time crossing."
    };

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
        "Waste processing assignment."
    };

    public static readonly string[] Dialogue = new string[] //DAY 1 all characters dialogue
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

    public static readonly string[] Dialogue = new string[] //DAY 2
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

    public static readonly string[] Dialogue = new string[] //DAY 3
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

     public static readonly string[] Dialogue = new string[] //DAY 4 the day before the player makes a choice whether they let through a medically dependend person through, but their firmware is slightly out of date, this affects the dialogue.
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

    public static readonly string[] Dialogue = new string[] //DAY 5
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

    public static readonly string[] Dialogue = new string[] //DAY 6 in day 5 player lets through an individual with HC firmware, after that the individual injures 3 people.
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

    public static readonly string[] Dialogue = new string[] //DAY 7
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

    public static readonly string[] Dialogue = new string[] //DAY 8
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

    public static readonly string[] Dialogue = new string[] //DAY 9 there were sirens at night time
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
        "Correlation noted" ,  //MX-2
    };
}
