<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Lê văn đại</title>
          <link rel="stylesheet" type="css/text" href="Stylesheet.css"></link> 
        </head>
        <body>
          <div id="dms">
            <h1>Danh Muc Sach</h1>
          </div>
          <xsl:for-each select="//coso">
            <h3>
              Co So: <xsl:value-of select="@tencs"/>
            </h3>
            <xsl:for-each select="nhaxb">
              <h4>
              Nha Xuat Ban <xsl:value-of select="tennxb"/>
              </h4>
              <table border ="2">
                <tr>
                  <th>STT</th>
                  <th>Ten Sach</th>
                  <th>TheLoai</th>
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
                  <xsl:variable name="sotrang1" select="sotrang"/>
                  <td>
                    <xsl:value-of select="$sotrang1*3000"/>
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
