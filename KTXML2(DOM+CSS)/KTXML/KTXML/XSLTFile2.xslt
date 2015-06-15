<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>
            Lê văn đại
          </title>
        </head>
        <body>
          <h1>Danh Mục Sách</h1>
          <xsl:for-each select="//coso">
            Co So : <xsl:value-of select="@tencoso"/><br/>
            <xsl:for-each select="nhaxb">
              Nha Xuat Ban : <xsl:value-of select="tennxb"/><br/>
              <table border="2" allign="center">
                <tr>
                  <th>STT</th>
                  <th>Tên Sách</th>
                  <th>The Loai</th>
                  <th>So Trang</th>
                  <th>Gia</th>
                  <th>Ma Sach</th>
                </tr>
                <xsl:for-each select="sach">
                  <tr>
                    <td>
                      <xsl:value-of select="position()"/>
                    </td>
                    <td>
                      <xsl:value-of select="tensach"/>
                    </td>
                    <td>
                      <xsl:value-of select="theloai"/>
                    </td>
                    <td>
                      <xsl:value-of select="sotrang"/>
                    </td>
                    <xsl:variable name="so_trang" select="sotrang"></xsl:variable>
                    <td>
                      <xsl:value-of select="$so_trang*3000"/>
                    </td>
                    <td>
                      <xsl:value-of select="@masach"/>
                    </td>
                  </tr>
                </xsl:for-each>
              </table>
            </xsl:for-each>
          </xsl:for-each>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
