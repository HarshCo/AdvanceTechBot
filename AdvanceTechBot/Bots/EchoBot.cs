// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.18.1

using AdvanceTechBot.NLUService;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AdvanceTechBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            try
            {


                var userQuery = turnContext.Activity.Text;
                var activity = turnContext.Activity as Activity;

                LuisResponseParse luisResponse = await LuisService.ProcessUserInputAsync(userQuery);
                if (luisResponse != null)
                {
                    string answer = string.Empty;
                    string link = "\n\n<strong>For more technical information kindly</strong> <a href=\"#link\">Click Here</a> ";
                    if (luisResponse.topScoringIntent.intent.Equals("FlashIMEI", System.StringComparison.OrdinalIgnoreCase))
                    {
                        answer = "You will need to flash IMEI Number in your Android Mobile Phone after flashing Stock ROM (Firmware).\n\n" +
                                "You have to flash the Stock ROM (Firmware) in your Android Mobile Phone for any of the following reasons:\n\nYour mobile phone gets hanged too often.\n\nYour phone gets hanged at company logo and doesn’t boot.\n\nYou want to update the latest software / operating system in your phone.\n\nYou have forgotten the lock pattern or password and want to unlock the phone.\n\nYour Android Mobile phone or tablet is dead because of software issues.";
                        answer += link.Replace("#link", $"https://www.mobilecellphonerepairing.com/how-to-flash-imei-number-in-android-mobile-phone.html");
                        await SendResponse(turnContext, answer, activity, cancellationToken);

                    }
                    if (luisResponse.topScoringIntent.intent.Equals("RemoveHeadphoneIcon", System.StringComparison.OrdinalIgnoreCase))
                    {
                        answer = "These Tips to Fix the Headphone Icon Problem is applicable to all Brands of Android Phone including – Xiaomi (Redmi), Realme, Gionee, Alcatel, Blu, Celkon, Coolpad, Hitech, Fly, Huawei, Lava, Lenovo, Micromax, Oppo, Samsung, Vivo,  Panasonic, ZTE etc.\n\nProblems Caused when Head phone Icon Stuck in Notification Bar\n\nHeadphone Symbol Not Going and Stuck\n\nThe phone goes in headphone mode even when the headphone is not plugged-in.\n\nWhen you increase or decrease volume of any media player including YouTube App, it will not work. The phone is actually increasing or decreasing Volume of the Headphone and NOT your Phone Speaker.\n\nDuring incoming calls, you won’t be able to listen any Ringtone as the Phone thinks the Headphone is plugged-in and it rings in the headphone.\n\nThe phone OS will do everything as if the headphone is plugged-in even though it is actually not plugged-in.\n\nYou may have headache because of this 👿 .";
                        answer += link.Replace("#link", $"https://www.mobilecellphonerepairing.com/headphone-symbol-icon-problem-solution.html");
                        await SendResponse(turnContext, answer, activity, cancellationToken);

                    }
                    if (luisResponse.topScoringIntent.intent.Equals("PartsIdentification", System.StringComparison.OrdinalIgnoreCase))
                    {
                        
                        // answer = "**Network Section** and\n\n**Power Section**\n\nWhen identifying parts, electronic components and ICs on the PCB of a mobile cell phone or smartphone, it is important to keep these two sections in mind.\n\nNetwork Section: The section below antenna point and above power section is called network section.\n\n1. Antenna Point\n\nThe point where antenna is connected is called antenna point. It is normally located at the top of the [Printed Circuit Board (PCB)](http://www.electronicsandyou.com/blog/what-is-printed-circuit-board.html) of a mobile phone / smartphone.\n\n2. Antenna Switch\n\nAntenna Switch found in the network section and is made from metal and non-metal. It has 16 points or legs. In some mobile phones, the antenna switch is merged with PFO.\n\n[Image](https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Antenna-Switch.jpg?resize=238%2C115)\n\n3. PFO\n\nPower Frequency Oscillator. It is present beside the antenna switch.\n\n[Image](https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/PFO.jpg?resize=235%2C120)\n\n4. Network IC\n\nIt is below or beside the antenna switch and PFO. In some mobile phones, the Network IC is merged with the CPU. E.g.: Nokia 1200, 1650, 1208, 1209 etc.\n\n[Image](https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Network-IC.jpg?resize=238%2C128)\n\nPower Section: This section is below the Network Section.\n\n5. Power IC\n\nIn the Power Section, the IC around which there are several brown-colored capacitors is called Power IC. In some mobile phones there are 2 Power ICs.\n\n[Image](https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Power-IC.jpg?resize=236%2C125)\n\n6. CPU\n\nCentral Processing Unit. In the power section, the largest IC is the CPU. In some sets there are 2 CPU.\n\n7. Flash IC\n\nThis IC is found beside the CPU.\n\n8. Logic IC\n\nThe IC with 20 legs is the Logic IC.\n\n9. Charging IC\n\nIn the Power Section, the IC beside R22 is the Charging IC.\n\n10. Audio IC\n\nThe IC parallel to Power IC is the Audio IC.";
                        answer = "**Network Section** and\n\n**Power Section**\n\nWhen identifying parts, electronic components and ICs on the PCB of a mobile cell phone or smartphone, it is important to keep these two sections in mind.\n\nNetwork Section:The section below antenna point and above power section is called network section.\n\n1. Antenna Point\n\nThe point where antenna is connected is called antenna point. It is normally located at the top of the <a href=\"http://www.electronicsandyou.com/blog/what-is-printed-circuit-board.html\">Printed Circuit Board (PCB)</a> of a mobile phone / smartphone.\n\n2. Antenna Switch\n\nAntenna Switch found in the network section and is made from metal and non-metal. It has 16 points or legs. In some mobile phones, the antenna switch is merged with PFO.\n\n<a href=\"https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Antenna-Switch.jpg?resize=238%2C115\">Image</a>\n\n\n3. PFO\n\nPower Frequency Oscillator. It is present beside the antenna switch.\n\n<a href=\"https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/PFO.jpg?resize=235%2C120\">Image</a>\n\n4. Network IC\n\nIt is below or beside the antenna switch and PFO. In some mobile phones, the Network IC is merged with the CPU. E.g.: Nokia 1200, 1650, 1208, 1209 etc.\n\n<a href=\"https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Network-IC.jpg?resize=238%2C128\">Image</a>\n\nPower Section: This section is below the Network Section.\n\n5. Power IC\n\nIn the Power Section, the IC around which there are several brown-colored capacitors is called Power IC. In some mobile phones there are 2 Power ICs.\n\n<a href=\"https://i0.wp.com/www.mobilecellphonerepairing.com/wp-content/uploads/2012/09/Power-IC.jpg?resize=236%2C125\">Image</a>\n\n6. CPU\n\nCentral Processing Unit. In the power section, the largest IC is the CPU. In some sets there are 2 CPU.\n\n7. Flash IC\n\nThis IC is found beside the CPU.\n\n8. Logic IC\n\nThe IC with 20 legs is the Logic IC.\n\n9. Charging IC\n\nIn the Power Section, the IC beside R22 is the Charging IC.\n\n10. Audio IC\n\nThe IC parallel to Power IC is the Audio IC.\n";
                        answer += link.Replace("#link", $"https://www.mobilecellphonerepairing.com/mobile-phone-parts-identification-how-to-identify-parts-components-on-pcb-of-mobile-phone.html");
                        await SendResponse(turnContext, answer, activity, cancellationToken);

                    }
                    if (luisResponse.topScoringIntent.intent.Equals("None", System.StringComparison.OrdinalIgnoreCase))
                    {
                        answer = "I am demo bot for Advance tech who can help in following area\n\n**flashing IMEI number issue** \n\n**Mobile Parts Identification**\n\n**Headphone icon freeze**\n\nright now trying to learn more about mobile repair in order to help you. Kindly rephrase your question and me try to understand your querymore clearly";
                        await SendResponse(turnContext, answer, activity, cancellationToken);


                    }
                    if (luisResponse.topScoringIntent.intent.Equals("Small Talk", System.StringComparison.OrdinalIgnoreCase))
                    {
                        answer = "Hey I am Advance MTG Bot (Advance Tech Mobile Guru Bot) who can help in following area right now\n\n**flashing IMEI number issue** \n\n**Mobile Parts Identification**\n\n**Headphone icon freeze**\n\n";
                        await SendResponse(turnContext, answer, activity, cancellationToken);


                    }

                }
            }
            catch (System.Exception ex)
            {

                var err = ex;
            }
        }

        private static async Task SendResponse(ITurnContext<IMessageActivity> turnContext, string answer, Activity activity, CancellationToken cancellationToken)
        {
            activity.Text = answer;
            activity.TextFormat = TextFormatTypes.Xml;

            await turnContext.SendActivityAsync(activity, cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
