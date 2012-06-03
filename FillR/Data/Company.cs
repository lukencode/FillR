﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillR.Data
{
    internal static class Company
    {
        internal static List<string> Names =
            new List<string> { "EdgeCo", "CutCom", "InterSlice", "Kwilith", "Eayo", "Voolith", "Eabox", "Gigabox", "Meeveo", "Yombu", "Eire", "Oyonder", "Dynazzy", "Demimbu", "Wikizz", "InnoZ", "Pixonyx", "Snaptags", "Yamia", 
            "Avamm", "Centimia", "Abata", "Feedmix", "Fadeo", "Thoughtbridge", "Thoughtmix", "Agivu", "Janyx", "Bubblemix", "Divape", "Leenti", "Buzzbean", "Agimba", "Jaxspan", "Skyvu", "Flipstorm", 
            "Browseblab", "Edgepulse", "Cogibox", "Lajo", "Realbridge", "Twimm", "Kwinu", "Thoughtstorm", "Flipopia", "Dabshots", "Npath", "Avavee", "BlogXS", "Layo", "Skyba", "Jabbersphere", "Thoughtblab", 
            "Skinix", "Photolist", "Innojam", "Skinder", "Oyope", "Wikizz", "Babbleblab", "Rhyzio", "Yambee", "Divanoodle", "Babbleset", "Topicware", "Yodoo", "Devpoint", "Edgeblab", "Devshare", "Trudoo", 
            "Cogidoo", "Blogpad", "Voonder", "Mynte", "Fatz", "Gabtune", "Mybuzz", "Kayveo", "Kazu", "Vinte", "Photojam", "Meetz", "Zooveo", "Photobug", "Oyoba", "Realcube", "Livefish", "Kare", "Jayo", 
            "Brightbean", "Livepath", "Skynoodle", "Devify", "Dabjam", "Katz", "Zoomzone", "Jaloo", "Browsebug", "Shuffledrive", "Meezzy", "Fivebridge", "Gabspot", "Roomm", "Fivechat", "Blogtag", "Zoonoodle", 
            "Kanoodle", "Camido", "Yadel", "Yodo", "Topicstorm", "Jabbertype", "Jatri", "Kwideo", "Izio", "Voomm", "Jaxbean", "Skipstorm", "Mita", "Gigaclub", "Skimia", "Blogtags", "Vitz", "Dynava", "Jetwire", 
            "Miboo", "Quimba", "Einti", "Oba", "JumpXS", "Voonix", "Jabberstorm", "Thoughtstorm", "Myworks", "Devbug", "Linkbridge", "Dabfeed", "Meembee", "Skiba", "Yoveo", "Eazzy", "Photobug", "Edgeclub", "Oyondu", 
            "Flipbug", "Pixoboo", "Zava", "Tagtune", "Zoombox", "Eidel", "Jaxnation", "Twitterworks", "Wordpedia", "Feednation", "DabZ", "Mudo", "Talane", "Twitterbridge", "Trilith", "Meemm", "Pixope", "Twitterlist", 
            "Ooba", "Trudeo", "Brainverse", "Gigashots", "Rhynoodle", "Realfire", "Yata", "Realblab", "Jetpulse", "Yakidoo", "Tagpad", "Edgewire", "Yacero", "Blognation", "Avaveo", "Oloo", "Lazz", "Flashspan", "Skipfire", 
            "Rooxo", "Realbuzz", "Muxo", "Jayo", "Topdrive", "Ntag", "Topicblab", "Meedoo", "Demizz", "Bluezoom", "Tagfeed", "Kamba", "Mycat", "Dynabox", "Brightdog", "Youspan", "Edgetag", "Roombo", "Feedbug", "Meejo",
            "Flashpoint", "Youbridge", "Gabvine", "Quatz", "Quire", "Camimbo", "Aibox", "Meevee", "Gabcube", "Browsetype", "Shuffletag", "Minyx", "Digitube", "Innotype", "Centidel", "Buzzdog", "Jazzy", "Divavu", "Browsedrive",
            "Voonte", "Quinu", "Quaxo", "Youopia", "Wordify", "Skivee", "Zoomcast", "Skippad", "Vidoo", "Shufflester", "Linklinks", "Youspan", "Quinu", "Topiclounge", "Feedfish", "Oozz", "Centizu", "Skiptube", "Vipe", "Zoomdog",
            "Twimbo", "Lazzy", "Nlounge", "Skidoo", "Teklist", "Kimia", "Twitterwire", "Mynte", "Thoughtsphere", "Rhycero", "Fivespan", "Shufflebeat", "Skyble", "Photospace", "Quimm", "Rhynyx", "Skaboo", "Latz", "Kwimbee", "Fliptune",
            "LiveZ", "Geba", "Wordtune", "Voolia", "Roodel", "Ainyx", "Zoonder", "Wikivu", "Linkbuzz", "Abatz", "Devpulse", "Trunyx", "Ozu", "Zoomlounge", "Mydo", "Tagcat", "Devcast", "Jabbercube", "Skilith", "Realpoint", "Quamba",
            "Wordware", "Gabtype", "Youtags", "Voomm", "Rhybox", "Tazz", "Riffpedia", "Babbleopia", "Zoombeat", "Photobean", "Zoozzy", "Twiyo", "Trupe", "Feedspan", "Mydeo", "Ntags", "Tekfly", "Tavu", "Riffwire", "Cogilith",
            "Topiczoom", "Jaxworks", "Tagchat", "Trilia", "Kaymbo", "Yodel", "Eare", "Gigazoom", "Dabtype", "Chatterpoint", "Plajo", "Tagopia", "Wikido", "Twinder", "Zooxo", "Linktype", "Skajo", "Riffpath", "Avamba", "Edgeify",
            "Midel", "Yozio", "Mymm", "Babblestorm", "Youfeed", "Wikibox", "Skinte", "Brainsphere", "Zoovu", "Flashset", "Ailane", "Zazio", "Brainlounge", "Bubblebox", "Quatz", "Bubbletube", "Browsezoom", "Dazzlesphere",
            "Feedfire", "Yakijo", "Voonyx", "Dabvine", "Skibox", "Buzzster", "Plambee", "Realcube", "Dynabox", "Jabbersphere", "Demivee", "Oyoyo", "Tanoodle", "Jamia", "Skimia", "Brainbox", "Thoughtworks", "Yotz",
            "Blogspan", "Eimbee", "Aivee", "Yabox", "Realmix", "Buzzshare", "Omba", "Chatterbridge", "Skyndu", "Browsecat", "Twitternation", "Fanoodle", "Twitterbeat", "Tambee", "Jabberbean", "Livetube", "Livetube", 
            "Viva", "Vimbo", "Podcat", "Dablist", "Leexo", "Kazio", "Twinte", "Aimbo", "Rhyloo", "Flashdog", "Meevee", "Thoughtbeat", "Gevee", "Vinder", "Eamia", "Fiveclub", "Oodoo", "Tazzy", "Katz", "Bluejam", 
            "Skalith", "Oyoloo", "Aimbu", "Photofeed", "Yakitri", "Topicshots", "Reallinks", "Eade" };
    }
}