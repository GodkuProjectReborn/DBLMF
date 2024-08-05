The **89bb4** file is the file that holds what items you own such as zeni, cc, summon tickets, trade items, costumes, character alt colors, etc. including other info such as character data that includes z power, zenkai level, soul boost level, arts boost levels, etc. It also includes party info and how much of the tutorial you've completed.

![image](https://media.discordapp.net/attachments/1246530079299731559/1247193716679245904/image0.png?ex=66b231a9&is=66b0e029&hm=1d641b29351002d26c31a581643e216e444251e534e7a5b732f77f4b2ccd13f0&=&format=webp&quality=lossless)

First, there's the category known as "item" which has everything I first mentioned, and the first thing being listed is character Z Power, also known as "Character Shards". Several things throughout files have different names that they would have in the game, here you can edit your character's z power count as high as you want but of course nothing really happens once you reach 9,999. "characterType" stands for what character's z power is being listed and "count" of course being how much z power you have. Also note, adding a character that you don't have WILL NOT give you that character, it will just make the game struggle to load a character that you do not have as thing that tracks all the characters in your account is server sided.

![image](https://media.discordapp.net/attachments/1246530079299731559/1247193765324652574/image0.png?ex=66b231b5&is=66b0e035&hm=87a2bb9b34b933d7dd8ede153071cfaa662f8ea169d97768709af2b489c96286&=&format=webp&quality=lossless)

Then there is **"Character Plenty Shards"** which is known as the awakening z power for characters, though all the chartacters even the ones without zenkai are listed, by adding awakened z power to characters that do not have a zenkai will not do anything and will not effect how they preform in any way, though you can of course increase or give characters zenkai that do have a zenkai, and just like regular z power, going above 7,000 will not make characters any stronger either.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261078948172005496/image-6.png?ex=66b29c4a&is=66b14aca&hm=63903e1e4aad9b1f5568e4faac4b8a1dc25f4a57f255e90913bc1126d601ae65&=&format=webp&quality=lossless)

Next we have **"Equip Items"**, where your equipments and their abilities and levels are listed. These are all editable without any limits however editing these at high levels and taking them to online battles is impossible as legends prevents people with modded equips, zenkai, and/or z power to find a match with other players. **"ID"** stands for the unique ID of the equipment, **"equipID"** stands for which equipment the equipment is, **"ability_id"** stands for what ability that specific slot has, **"ability_effect_param"** is for the ability strength percentage,** "ability_high_quality"** is what color the designated slots are with 2 or less for green, 3 for yellow, and 4 for red. **"rank"** is of course what rank is the equip with E starting at 1, D is 2, C is 3, B is 4, A is 5, S is 6, Z is 7, and finally Z+ is 8 (Also Godly is 9), I have not personally modified the other values in this section but of course you can try it out to see what they do for yourself.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079020376952922/image-7.png?ex=66b29c5c&is=66b14adc&hm=87beaf917e379b2f4502812f3f8e78b669b98cfeef193ea38bb72524b979f15f&=&format=webp&quality=lossless&width=341&height=652)

I've no clue as to what this means as I had seen this not even 5 minutes ago, but I believe it might have to do with something about having "dirty" or what I believe means modded equipments.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079082452517047/image-8.png?ex=66b29c6a&is=66b14aea&hm=65154af58692403a1b8c014bab819cb247937ffa190bbd22c3dc656e3f87f665&=&format=webp&quality=lossless)

Next there is currency which is modifiable but is also client sided, as whatever you add onto will not be able to be spent, this includes for all trade items as well.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079135757799484/image-9.png?ex=66b29c77&is=66b14af7&hm=718f5e1711862c2d4eb4ecf279a5817c921d814879a17340a2e4ff2afdbc8658&=&format=webp&quality=lossless)

There is another section where there is **"unlockItems_"** and **"invisibleUnlockItems_"** but I have no clue what these IDs are, and I also have not expiramented with them either so feel free to check out what these values may be.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079189990146209/image-10.png?ex=66b29c84&is=66b14b04&hm=80ca64812df0494e315aa95932c67b3cfa0e6f80a29f956af87fc8a423a1c6fe&=&format=webp&quality=lossless&width=337&height=652)

Now there is this section labeled **"otherItems_"**, which contains all tradable items, tickets, dragon balls, costumes, sleeves, character alternate colors, etc. You may notice the number 10 where it says **"type"**, and this of course is the category of item. Item IDs are a bit complicated at first but are understandable very quickly. There are a total of roughly 30-40 category types for otherItem IDs with a second ID pointing out the specific item for that category. The item categories are named as such, taken from the game's directory as well:
```
STONE = 1,

ZENY = 2,

SHARD = 3,

SOUL = 4,

TRAINING = 5,

DISPATCH = 6,

EQUIPMENT = 7,

EXCHANGE = 8,

GASHA_TICKET = 9,

AVATAR_COSTUME = 10,

AVATAR_ACCESSORY = 11,

AVATAR_HAIR = 12,

AVATAR_HAIRCOLOR = 13,

AVATAR_EYECOLOR = 14,

AVATAR_SKIN_COLOR = 15,

DRAGONBALL = 16,

SKIP_TICKET = 17,

SPARKING_POINT = 18,

GENERAL = 19,

ENERGY_TICKET = 20,

FORM_CHANGE = 21,

TITLE = 23,

TOURNAMENT_TICKET = 24,

PVP_MESSAGE = 25,

BLUEPRINT = 26,

PIECE = 27,

MULTI_SHARD = 28,

PLENTY_SHARD = 29,

ENERGY_TANK = 31,

CONTENTS_TRIGGER_KEY = 32,

TYPE_TACT_ENERGY = 33,

CONTENTS_TRIGGER_INVISIBLE_KEY = 34,

ARTS_BOOST_BASE = 35,

ARTS_BOOST_SPHERE = 36,

ITEM_PACK = 41,

PROFILE_CHARACTER_BG = 42,
 
PROFILE_FRAME = 43,

PROFILE_PARAM_BG = 44,

CREATE_UNIT = 103,

MISSIONPLAN_POINT = 104,

DAILYSTAMP_POINT = 105
```

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079277424611408/image-16.png?ex=66b29c99&is=66b14b19&hm=0a50fb85d3e638b2febff95df747423758ce306860b47da7386e5cbccc713ad2&=&format=webp&quality=lossless)

Of course not all of these IDs can be found in your 89bb4 folder, as some of them practically have no use, and some of them seem out of place including the ones with AVATAR in their name, but these have been in beta and seem to just be there with no actual use.
There is then the secondary IDs that identify which specific item it is in which category but itself is a list far too big to go through and one that not even I have gone and listed each and every item.
Also, if you need character IDs for editing the 89bb4 file when you do not know what ID a specific unit has, you can reffer to the following website where a character's ID is at the end of the link as shown in this example:

[DBLegends.net (recommended)](https://dblegends.net)
[DBZ Space](https://legends.dbz.space/characters/)

The link ends with 539 as 539 is Tag Goku and Freiza's ID

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079411403526287/Screenshot_20230619_025407_Brave.png?ex=66b29cb9&is=66b14b39&hm=2909c278d14449cc11f036941d0417277b6a465c19dc89bd03c4a22e80c485df&=&format=webp&quality=lossless&width=327&height=653)

Regarding otherItems_, I will be discussing on how to add items such as alternate colors and sleeves in your account in a seperate channel, and remember that file editing will stay how you edit it until either the game updates, the file is deleted, or you login into your account elsewhere

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079527073906791/image.png?ex=66b29cd4&is=66b14b54&hm=17c8810bbc335aff50f117a8599c91d16fe06131c4c93ac2654e86e3f1b0e0f8&=&format=webp&quality=lossless)

Of course **"id"** represents character ID, **"exp"** just refers to experience though I do not think changing this does anything, **"level"** is their level and is capped at 9,999 from what I've experienced though feel free to try and make it go higher. **"isTraining"** and** "isDispatch"** means if the unit is training or if they are in adventures, **"boost"** are of course the boost boards with there being 7 different values. For a maxed out boost board, the number in **"releaseFlags_Low"** needs to be "2305843009213693951" for regular characters and for zenkai characters it can be a little try as for example with a fully soul boosted Z7 Purple Android 21 their numbers are different for each boost board.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079573513371841/image.png?ex=66b29ce0&is=66b14b60&hm=65147ea1a07ed8e1d0c39fb205ae33fb3e61e3e4f22be093bb40f5f33f773ab4&=&format=webp&quality=lossless&width=418&height=653)

Then there is **"createTime"** which I believe is a timestamp for when you pulled the character, and I think it's for when you are sorting characters by earliest or latest recieved, and the friendship points which cannot be used for anything else other than visual effect.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079630065045604/image.png?ex=66b29ced&is=66b14b6d&hm=57a0102b6dd96b70d3b1ad5b020640c0bfdc0c5e855ba1c3fd88a5aade982821&=&format=webp&quality=lossless)

The next section is **"party"**, here you can modify your party in any way such as changing the party's name to whatever you want, what characters are in the party including the same character in all 6 slots of the party, and which equipments the characters have

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079630065045604/image.png?ex=66b29ced&is=66b14b6d&hm=57a0102b6dd96b70d3b1ad5b020640c0bfdc0c5e855ba1c3fd88a5aade982821&=&format=webp&quality=lossless)

There is **"id_"** which is party id, this goes from 0 to 5, then there is **"partyName_"** which you can change to whatever you want, and then there is **"characters_"** which lists all 6 characters in what slot they are and with what equipments they have.

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079734448558102/image.png?ex=66b29d06&is=66b14b86&hm=b6253ac74f6a3800c605a41faaae8106afb1f14531c26a32ab00a8c8e15c04bf&=&format=webp&quality=lossless)

**"characterId_"** of course is what character is in the party, you can make this all the same character so that it'll look like this in game, however note that you cannot actually use the same character 3 times with this method,

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079817147777034/image.png?ex=66b29d1a&is=66b14b9a&hm=50d8d2eae3c3865ff02396710ae8e8966589b8d3a93c6ae99dc80e6ba260719a&=&format=webp&quality=lossless)


![image](https://media.discordapp.net/attachments/1246530079299731559/1261079817395245077/image.png?ex=66b29d1a&is=66b14b9a&hm=63831254f312a792680c9485e6cc382afa0fbb0b821af058e983199e72151d8a&=&format=webp&quality=lossless)

**"number_"** is what member slot the character is in, and **"equips"** has the unique equipment ID mentioned earlier

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079884524949596/image.png?ex=66b29d2a&is=66b14baa&hm=56980aa780e986107625d0da4b8cf52dd162e7e2d3d406c154e8f65c8d2e7dd5&=&format=webp&quality=lossless)

There is tutorial. Here for new accounts there will be several zeroes, as this lets the game know how much of the tutorial you have completed, by changing all of the zeroes to ones, it tells the game that every tutorial has been done. Here is the string of ones in case you need to copy and paste it:

1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111

![image](https://media.discordapp.net/attachments/1246530079299731559/1261079933585985620/image.png?ex=66b29d35&is=66b14bb5&hm=c0c617b5b8c1bd8373f281bcde0821d6ec9f5d89cdd3fc18bd7ef06cc844c4ad&=&format=webp&quality=lossless)

There is also **"avatarInfo_"** which gives detail on what you have set on Shallot, here you can modify costumes, transformations, and what special arts card he has

![image](https://media.discordapp.net/attachments/1246530079299731559/1261080006977654795/image.png?ex=66b29d47&is=66b14bc7&hm=760216d277f1ee42d08ddd38392ac92fff7d1e470796fdc4b607a1aa4f4e7e8b&=&format=webp&quality=lossless)

**"avatarPartsIds"** has his costume and accessory, though from my experience the first and third zero have no effect while the second number represents costume ID and fourth value represents accessory ID.
**"inheritCharacterId"** is for what special arts card Shallot is equipped with, though note that if you give Shallot a special arts that is not trainable, you will experience the game freezing when you load up a match and is entirely useless.
As for **"formId"** and **"formIds"**,these are to tell the game what forms you may have unlocked, and as for what each value represents in **"formIds"**:
0 = Hero Base
1 = Hero SSJ
2 = Hero SS2
3 = Hero SS3
4 = Hero SSG
800 = Sparking Base
801 = Sparking SSJ
802 = Sparking SS2
803 = Sparking SS3
804 = Sparking SSG

...and for **"formId"**, this is what form Shallot is equipped with.
Note, if you are changing transformations while you are equipped with an outfit you do not own, the game will give you an error message saying that you do not own this costume and will take you back to the main screen and delete your modded 89bb4 and redownload a fresh one from the server. Do not be scared of this happening as it has happened to me countless times and I have not faced any reprecussions.
And for those that want the World Champion Uniform or the SHOWDOWN Varsity Jacket, here are thir IDs:

World Champion Uniform = 1,000
SHOWDOWN Varsity Jacket = 1,001

![image](https://media.discordapp.net/attachments/1246530079299731559/1261080149831716884/79401673ff451.png?ex=66b29d69&is=66b14be9&hm=25beb356c6ec8deeb0f8d75357ab08f302b3c522bf395dad5890640b7e78e34d&=&format=webp&quality=lossless&width=635&height=653)



# CREDITS TO SPOON
