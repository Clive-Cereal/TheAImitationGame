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

    public static readonly string[] Dialogue = new string[] //DAY 3
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
}
