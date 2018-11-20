<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
        <head>
            <meta charset="utf-8" />
            <title></title>
        </head>
        <body>
            <div>
            <h1> My favorite plants!</h1>
                <table style="width:100%;" border="1">
                    <tr>
                        <th>Latituide</th><th>Longitude</th><th>Description</th><th>Planted By</th>
                    </tr>
                    <xsl:for-each select="/plant/specimens/specimen">
                        <tr>
                            <td>
                                <xsl:value-of select="latitude"/>
                            </td>
                            <td>
                                <xsl:value-of select="longitude"/>
                            </td>
                            <td>
                                <xsl:value-of select="description"/>
                            </td>
                            <td>
                                <xsl:value-of select="planted_by"/>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </div>
        </body>
        </html>
        </xsl:template>
    </xsl:stylesheet>