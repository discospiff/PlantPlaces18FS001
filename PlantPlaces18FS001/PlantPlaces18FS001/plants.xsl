<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
        <head>
            <meta charset="utf-8" />
            <title></title>
        </head>
        <body>
            <table style="width:100%;">
                <tr>
                    <th>Latituide</th><th>Longitude</th><th>Description</th><th>Planted By</th>
                </tr>
                <xsl:for-each select="/plant/specimens/specimen">
                    <tr>
                        <td></td><td></td><td></td><td></td>
                    </tr>
                </xsl:for-each>
            </table>

        </body>
        </html>
        </xsl:template>
    </xsl:stylesheet>