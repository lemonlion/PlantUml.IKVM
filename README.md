# PlantUml.IKVM
Generate images from PlantUml in .Net. This is a light wrapper around the PlantUml Java (jar) file (MIT version), using the IKVM Java runtime.

## Example Usage

```
var plantUmlPngByteArray = PlantUmlImageWriter.WriteImage(plantUml, FileFormat.PNG);
```

## Available File Formats

EPS
EPS_TEXT
ATXT
UTXT
XMI_STANDARD
XMI_STAR
XMI_ARGO
XMI_SCRIPT
HTML5
VDX
LATEX
LATEX_NO_PREAMBLE
BRAILLE_PNG
PREPROC
DEBUG
PNG
RAW
SVG


