using java.io;
using net.sourceforge.plantuml;

namespace PlantUml.IKVM;

public class PlantUmlImageWriter
{
    public static byte[] WriteImage(string plantUml, FileFormat format)
    {
        using var imageByteStream = new ByteArrayOutputStream();
        var imageReader = new SourceStringReader(plantUml);
        var fileFormat = net.sourceforge.plantuml.FileFormat.values()[(int)format];
        imageReader.outputImage(imageByteStream, new FileFormatOption(fileFormat));
        var imageAsBytes = imageByteStream.toByteArray();
        return imageAsBytes;
    }
}
