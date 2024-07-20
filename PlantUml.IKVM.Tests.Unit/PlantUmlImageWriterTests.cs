using FluentAssertions;

namespace PlantUml.IKVM.Tests.Unit
{
    public class PlantUmlImageWriterTests
    {
        [Fact]
        public void TestAllFormats()
        {
            var plantUml = @"
@startuml
Bob -> Alice : hello
@enduml
".Trim();
            var images = new List<byte[]>
            {
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.EPS),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.EPS_TEXT),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.ATXT),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.UTXT),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.XMI_STANDARD),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.XMI_STAR),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.XMI_ARGO),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.XMI_SCRIPT),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.HTML5),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.VDX),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.LATEX),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.LATEX_NO_PREAMBLE),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.BRAILLE_PNG),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.PREPROC),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.DEBUG),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.PNG),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.RAW),
                PlantUmlImageWriter.WriteImage(plantUml, FileFormat.SVG)
            };

            foreach (var image in images)
                image.Should().NotBeEmpty();
        }
    }
}