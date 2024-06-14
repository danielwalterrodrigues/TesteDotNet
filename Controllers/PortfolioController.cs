using Microsoft.AspNetCore.Mvc;

namespace TesteDotNet.Controllers
{
    [ApiController]
    [Route("api/portfolioDaniel")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProject()
        {
            var project = new
            {
                gliControl = new
                {
                    title = "gliControl",
                    subTitle = "android app",
                    backContent = "Aplicativo para registro de glicemia",
                    backContent2 = "",
                    description = "O GliControl é um aplicativo simples para registros médicos distribuído gratuitamente na Play Storre, permitindo ao usuário criar momentos ao longo do dia nos quais deseja fazer registros glicêmicos, e armazenar os valores diários de seus registros. Projeto pessoal criado, desenhado e programado em apenas 2 dias.",
                    logo = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FlogoGliControl.png?alt=media&token=4d8367ce-289d-48d3-8615-9847acfdde9b",
                    numImages = 6,
                    gallery = new[]
                    {
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1718225478.png?alt=media&token=26425289-9b6a-4a1f-ac3a-20d222a6de85" },
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1718225448.png?alt=media&token=7d9e7ebf-c26d-4b52-96fc-0c4f4b85d37e" },
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1717449784.png?alt=media&token=1457ee0b-7aea-4313-a85f-3e0141c4af39" },
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1718225538.png?alt=media&token=b1d85faa-fbaa-4a58-9887-daf7039f17a0" },
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1718225565.png?alt=media&token=4ff4c5b5-0012-44c6-a42f-df20c8e84cdb" },
                        new { img = "https://firebasestorage.googleapis.com/v0/b/portfolio-daniel-rodrigues.appspot.com/o/gliControl%2FScreenshot_1718225572.png?alt=media&token=1c651b71-cb5c-4b2d-a495-add86dabebc5" }
                    },
                    tags = new[]
                    {
                        new { tag = "react-native" },
                        new { tag = "Context API" },
                        new { tag = "design" },
                        new { tag = "UX/UI" },
                        new { tag = "Android" },
                        new { tag = "Expo" },
                        new { tag = "Logotipia" },
                        new { tag = "Design" },
                        new { tag = "Idealização" },
                        new { tag = "Adobe Photoshop" }
                    }
                }
            };

            return Ok(project);
        }
    }
}
