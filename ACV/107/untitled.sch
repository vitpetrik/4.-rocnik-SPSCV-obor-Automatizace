<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE eagle SYSTEM "eagle.dtd">
<eagle version="7.7.0">
<drawing>
<settings>
<setting alwaysvectorfont="no"/>
<setting verticaltext="up"/>
</settings>
<grid distance="0.1" unitdist="inch" unit="inch" style="lines" multiple="1" display="no" altdistance="0.01" altunitdist="inch" altunit="inch"/>
<layers>
<layer number="1" name="Top" color="4" fill="1" visible="no" active="no"/>
<layer number="16" name="Bottom" color="1" fill="1" visible="no" active="no"/>
<layer number="17" name="Pads" color="2" fill="1" visible="no" active="no"/>
<layer number="18" name="Vias" color="2" fill="1" visible="no" active="no"/>
<layer number="19" name="Unrouted" color="6" fill="1" visible="no" active="no"/>
<layer number="20" name="Dimension" color="15" fill="1" visible="no" active="no"/>
<layer number="21" name="tPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="22" name="bPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="23" name="tOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="24" name="bOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="25" name="tNames" color="7" fill="1" visible="no" active="no"/>
<layer number="26" name="bNames" color="7" fill="1" visible="no" active="no"/>
<layer number="27" name="tValues" color="7" fill="1" visible="no" active="no"/>
<layer number="28" name="bValues" color="7" fill="1" visible="no" active="no"/>
<layer number="29" name="tStop" color="7" fill="3" visible="no" active="no"/>
<layer number="30" name="bStop" color="7" fill="6" visible="no" active="no"/>
<layer number="31" name="tCream" color="7" fill="4" visible="no" active="no"/>
<layer number="32" name="bCream" color="7" fill="5" visible="no" active="no"/>
<layer number="33" name="tFinish" color="6" fill="3" visible="no" active="no"/>
<layer number="34" name="bFinish" color="6" fill="6" visible="no" active="no"/>
<layer number="35" name="tGlue" color="7" fill="4" visible="no" active="no"/>
<layer number="36" name="bGlue" color="7" fill="5" visible="no" active="no"/>
<layer number="37" name="tTest" color="7" fill="1" visible="no" active="no"/>
<layer number="38" name="bTest" color="7" fill="1" visible="no" active="no"/>
<layer number="39" name="tKeepout" color="4" fill="11" visible="no" active="no"/>
<layer number="40" name="bKeepout" color="1" fill="11" visible="no" active="no"/>
<layer number="41" name="tRestrict" color="4" fill="10" visible="no" active="no"/>
<layer number="42" name="bRestrict" color="1" fill="10" visible="no" active="no"/>
<layer number="43" name="vRestrict" color="2" fill="10" visible="no" active="no"/>
<layer number="44" name="Drills" color="7" fill="1" visible="no" active="no"/>
<layer number="45" name="Holes" color="7" fill="1" visible="no" active="no"/>
<layer number="46" name="Milling" color="3" fill="1" visible="no" active="no"/>
<layer number="47" name="Measures" color="7" fill="1" visible="no" active="no"/>
<layer number="48" name="Document" color="7" fill="1" visible="no" active="no"/>
<layer number="49" name="Reference" color="7" fill="1" visible="no" active="no"/>
<layer number="51" name="tDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="52" name="bDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="90" name="Modules" color="5" fill="1" visible="yes" active="yes"/>
<layer number="91" name="Nets" color="2" fill="1" visible="yes" active="yes"/>
<layer number="92" name="Busses" color="1" fill="1" visible="yes" active="yes"/>
<layer number="93" name="Pins" color="2" fill="1" visible="no" active="yes"/>
<layer number="94" name="Symbols" color="4" fill="1" visible="yes" active="yes"/>
<layer number="95" name="Names" color="7" fill="1" visible="yes" active="yes"/>
<layer number="96" name="Values" color="7" fill="1" visible="yes" active="yes"/>
<layer number="97" name="Info" color="7" fill="1" visible="yes" active="yes"/>
<layer number="98" name="Guide" color="6" fill="1" visible="yes" active="yes"/>
</layers>
<schematic xreflabel="%F%N/%S.%C%R" xrefpart="/%S.%C%R">
<libraries>
<library name="74ttl-din">
<description>&lt;b&gt;TTL Devices with DIN Symbols&lt;/b&gt;&lt;p&gt;
CadSoft and the author do not warrant that this library is free from error
or will meet your specific requirements.&lt;p&gt;
&lt;author&gt;Created by Holger Bettenbühl, hol.bet.@rhein-main.net&lt;/author&gt;</description>
<packages>
<package name="DIL14">
<description>&lt;b&gt;Dual In Line Package&lt;/b&gt;</description>
<wire x1="8.89" y1="2.921" x2="-8.89" y2="2.921" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="-2.921" x2="8.89" y2="-2.921" width="0.1524" layer="21"/>
<wire x1="8.89" y1="2.921" x2="8.89" y2="-2.921" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="2.921" x2="-8.89" y2="1.016" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="-2.921" x2="-8.89" y2="-1.016" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="1.016" x2="-8.89" y2="-1.016" width="0.1524" layer="21" curve="-180"/>
<pad name="1" x="-7.62" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="2" x="-5.08" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="7" x="7.62" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="8" x="7.62" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="3" x="-2.54" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="4" x="0" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="6" x="5.08" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="5" x="2.54" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="9" x="5.08" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="10" x="2.54" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="11" x="0" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="12" x="-2.54" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="13" x="-5.08" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="14" x="-7.62" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<text x="-9.271" y="-3.048" size="1.27" layer="25" ratio="10" rot="R90">&gt;NAME</text>
<text x="-6.731" y="-0.635" size="1.27" layer="27" ratio="10">&gt;VALUE</text>
</package>
</packages>
<symbols>
<symbol name="+UB">
<circle x="0" y="-0.635" radius="0.635" width="0.1524" layer="94"/>
<text x="1.27" y="-1.27" size="1.524" layer="95">&gt;NAME</text>
<pin name="+UB" x="0" y="2.54" visible="pad" length="short" direction="pwr" rot="R270"/>
</symbol>
<symbol name="-UB">
<wire x1="0" y1="-0.635" x2="0" y2="0.635" width="0" layer="94"/>
<wire x1="0.635" y1="0" x2="-0.635" y2="0" width="0" layer="94"/>
<circle x="0" y="0.635" radius="0.635" width="0.1524" layer="94"/>
<text x="1.27" y="0" size="1.524" layer="95">&gt;NAME</text>
<pin name="-UB" x="0" y="-2.54" visible="pad" length="short" direction="pwr" rot="R90"/>
</symbol>
<symbol name="02">
<wire x1="-0.635" y1="0" x2="0.635" y2="0" width="0" layer="94"/>
<wire x1="0" y1="0.635" x2="0" y2="-0.635" width="0" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="-5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="5.08" y2="1.27" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="7.62" y1="0" x2="5.08" y2="1.27" width="0.1524" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.1524" layer="94"/>
<wire x1="5.08" y1="0" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="2.54" x2="-5.08" y2="2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="2.54" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-2.54" x2="-5.08" y2="-2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-2.54" x2="-5.08" y2="2.54" width="0.254" layer="94"/>
<wire x1="-1.27" y1="1.651" x2="0.127" y2="1.651" width="0.1524" layer="94"/>
<text x="-5.08" y="5.715" size="2.032" layer="95">&gt;NAME</text>
<text x="-5.08" y="-8.255" size="2.032" layer="96">&gt;VALUE</text>
<text x="-1.27" y="1.905" size="2.032" layer="94">&gt;1</text>
<pin name="A" x="-10.16" y="2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="B" x="-10.16" y="-2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="Y" x="10.16" y="0" visible="pad" length="short" direction="out" rot="R180"/>
</symbol>
<symbol name="04">
<wire x1="-5.08" y1="-5.08" x2="-5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="5.08" y2="1.27" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="7.62" y1="0" x2="5.08" y2="1.27" width="0.1524" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.1524" layer="94"/>
<wire x1="5.08" y1="0" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="0" x2="-5.08" y2="0" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="0" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<text x="-5.08" y="5.715" size="2.032" layer="95">&gt;NAME</text>
<text x="-5.08" y="-8.255" size="2.032" layer="96">&gt;VALUE</text>
<text x="-0.3302" y="1.905" size="2.032" layer="94">1</text>
<pin name="A" x="-10.16" y="0" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="Y" x="10.16" y="0" visible="pad" length="short" direction="out" rot="R180"/>
</symbol>
<symbol name="00">
<wire x1="-0.635" y1="0" x2="0.635" y2="0" width="0" layer="94"/>
<wire x1="0" y1="0.635" x2="0" y2="-0.635" width="0" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="-5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="5.08" y2="1.27" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="7.62" y1="0" x2="5.08" y2="1.27" width="0.1524" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.1524" layer="94"/>
<wire x1="5.08" y1="0" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="2.54" x2="-5.08" y2="2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="2.54" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-2.54" x2="-5.08" y2="-2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-2.54" x2="-5.08" y2="2.54" width="0.254" layer="94"/>
<text x="-5.08" y="5.715" size="2.032" layer="95">&gt;NAME</text>
<text x="-5.08" y="-8.255" size="2.032" layer="96">&gt;VALUE</text>
<text x="-0.635" y="1.905" size="2.032" layer="94">&amp;</text>
<pin name="A" x="-10.16" y="2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="B" x="-10.16" y="-2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="Y" x="10.16" y="0" visible="pad" length="short" direction="out" rot="R180"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="74*02" prefix="V">
<description>Quad 2-input &lt;b&gt;NOR&lt;/b&gt; gate</description>
<gates>
<gate name="/+UB" symbol="+UB" x="15.24" y="12.7" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="15.24" y="5.08" addlevel="request"/>
<gate name="/1" symbol="02" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="02" x="0" y="17.78" swaplevel="1"/>
<gate name="/3" symbol="02" x="-22.86" y="0" swaplevel="1"/>
<gate name="/4" symbol="02" x="-22.86" y="17.78" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="A" pad="2"/>
<connect gate="/1" pin="B" pad="3"/>
<connect gate="/1" pin="Y" pad="1"/>
<connect gate="/2" pin="A" pad="5"/>
<connect gate="/2" pin="B" pad="6"/>
<connect gate="/2" pin="Y" pad="4"/>
<connect gate="/3" pin="A" pad="8"/>
<connect gate="/3" pin="B" pad="9"/>
<connect gate="/3" pin="Y" pad="10"/>
<connect gate="/4" pin="A" pad="11"/>
<connect gate="/4" pin="B" pad="12"/>
<connect gate="/4" pin="Y" pad="13"/>
</connects>
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="74*04" prefix="V">
<description>Hex &lt;b&gt;INVERTER&lt;/b&gt;</description>
<gates>
<gate name="/+UB" symbol="+UB" x="15.24" y="12.7" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="15.24" y="5.08" addlevel="request"/>
<gate name="/1" symbol="04" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="04" x="0" y="17.78" swaplevel="1"/>
<gate name="/3" symbol="04" x="0" y="35.56" swaplevel="1"/>
<gate name="/4" symbol="04" x="-25.4" y="0" swaplevel="1"/>
<gate name="/5" symbol="04" x="-25.4" y="17.78" swaplevel="1"/>
<gate name="/6" symbol="04" x="-25.4" y="35.56" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="A" pad="1"/>
<connect gate="/1" pin="Y" pad="2"/>
<connect gate="/2" pin="A" pad="3"/>
<connect gate="/2" pin="Y" pad="4"/>
<connect gate="/3" pin="A" pad="5"/>
<connect gate="/3" pin="Y" pad="6"/>
<connect gate="/4" pin="A" pad="9"/>
<connect gate="/4" pin="Y" pad="8"/>
<connect gate="/5" pin="A" pad="11"/>
<connect gate="/5" pin="Y" pad="10"/>
<connect gate="/6" pin="A" pad="13"/>
<connect gate="/6" pin="Y" pad="12"/>
</connects>
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="74*00" prefix="V">
<description>Quad 2-input &lt;b&gt;NAND&lt;/b&gt; gate</description>
<gates>
<gate name="/+UB" symbol="+UB" x="15.24" y="12.7" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="15.24" y="5.08" addlevel="request"/>
<gate name="/1" symbol="00" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="00" x="0" y="17.78" swaplevel="1"/>
<gate name="/3" symbol="00" x="-22.86" y="0" swaplevel="1"/>
<gate name="/4" symbol="00" x="-22.86" y="17.78" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="A" pad="1"/>
<connect gate="/1" pin="B" pad="2"/>
<connect gate="/1" pin="Y" pad="3"/>
<connect gate="/2" pin="A" pad="4"/>
<connect gate="/2" pin="B" pad="5"/>
<connect gate="/2" pin="Y" pad="6"/>
<connect gate="/3" pin="A" pad="9"/>
<connect gate="/3" pin="B" pad="10"/>
<connect gate="/3" pin="Y" pad="8"/>
<connect gate="/4" pin="A" pad="12"/>
<connect gate="/4" pin="B" pad="13"/>
<connect gate="/4" pin="Y" pad="11"/>
</connects>
<technologies>
<technology name=""/>
<technology name="HC"/>
<technology name="HCT"/>
<technology name="LS"/>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
<library name="supply2">
<description>&lt;b&gt;Supply Symbols&lt;/b&gt;&lt;p&gt;
GND, VCC, 0V, +5V, -5V, etc.&lt;p&gt;
Please keep in mind, that these devices are necessary for the
automatic wiring of the supply signals.&lt;p&gt;
The pin name defined in the symbol is identical to the net which is to be wired automatically.&lt;p&gt;
In this library the device names are the same as the pin names of the symbols, therefore the correct signal names appear next to the supply symbols in the schematic.&lt;p&gt;
&lt;author&gt;Created by librarian@cadsoft.de&lt;/author&gt;</description>
<packages>
</packages>
<symbols>
<symbol name="VCC">
<circle x="0" y="1.27" radius="1.27" width="0.254" layer="94"/>
<text x="-1.905" y="3.175" size="1.778" layer="96">&gt;VALUE</text>
<pin name="VCC" x="0" y="-2.54" visible="off" length="short" direction="sup" rot="R90"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="VCC" prefix="SUPPLY">
<description>&lt;b&gt;SUPPLY SYMBOL&lt;/b&gt;</description>
<gates>
<gate name="G$1" symbol="VCC" x="0" y="0"/>
</gates>
<devices>
<device name="">
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
</libraries>
<attributes>
</attributes>
<variantdefs>
</variantdefs>
<classes>
<class number="0" name="default" width="0" drill="0">
</class>
</classes>
<parts>
<part name="IO1" library="74ttl-din" deviceset="74*02" device="N"/>
<part name="IO3" library="74ttl-din" deviceset="74*04" device="N"/>
<part name="IO2" library="74ttl-din" deviceset="74*00" device="N"/>
<part name="IO4" library="74ttl-din" deviceset="74*00" device="N"/>
<part name="SUPPLY1" library="supply2" deviceset="VCC" device="" value="A"/>
<part name="SUPPLY2" library="supply2" deviceset="VCC" device="" value="B"/>
<part name="SUPPLY3" library="supply2" deviceset="VCC" device="" value="C"/>
</parts>
<sheets>
<sheet>
<plain>
<text x="-33.02" y="99.06" size="1.778" layer="91">c</text>
<text x="-30.48" y="99.06" size="1.778" layer="91">b</text>
<text x="-27.94" y="99.06" size="1.778" layer="91">a</text>
</plain>
<instances>
<instance part="IO1" gate="/1" x="-12.7" y="88.9"/>
<instance part="IO1" gate="/2" x="35.56" y="78.74"/>
<instance part="IO3" gate="/1" x="-12.7" y="71.12"/>
<instance part="IO3" gate="/2" x="60.96" y="78.74"/>
<instance part="IO3" gate="/3" x="-12.7" y="10.16"/>
<instance part="IO2" gate="/1" x="-12.7" y="50.8"/>
<instance part="IO2" gate="/2" x="12.7" y="60.96"/>
<instance part="IO2" gate="/3" x="-12.7" y="33.02"/>
<instance part="IO2" gate="/4" x="12.7" y="25.4"/>
<instance part="IO4" gate="/1" x="10.16" y="2.54"/>
<instance part="IO4" gate="/2" x="35.56" y="-5.08"/>
<instance part="SUPPLY1" gate="G$1" x="76.2" y="78.74" smashed="yes" rot="R270">
<attribute name="VALUE" x="79.375" y="79.375" size="1.778" layer="96"/>
</instance>
<instance part="SUPPLY2" gate="G$1" x="73.66" y="25.4" smashed="yes" rot="R270">
<attribute name="VALUE" x="76.835" y="26.035" size="1.778" layer="96"/>
</instance>
<instance part="SUPPLY3" gate="G$1" x="71.12" y="-5.08" smashed="yes" rot="R270">
<attribute name="VALUE" x="74.295" y="-4.445" size="1.778" layer="96"/>
</instance>
</instances>
<busses>
</busses>
<nets>
<net name="N$1" class="0">
<segment>
<wire x1="-33.02" y1="96.52" x2="-33.02" y2="71.12" width="0.1524" layer="91"/>
<pinref part="IO3" gate="/1" pin="A"/>
<wire x1="-33.02" y1="71.12" x2="-33.02" y2="35.56" width="0.1524" layer="91"/>
<wire x1="-33.02" y1="35.56" x2="-33.02" y2="0" width="0.1524" layer="91"/>
<wire x1="-33.02" y1="0" x2="-33.02" y2="-12.7" width="0.1524" layer="91"/>
<wire x1="-22.86" y1="71.12" x2="-33.02" y2="71.12" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/3" pin="A"/>
<wire x1="-22.86" y1="35.56" x2="-33.02" y2="35.56" width="0.1524" layer="91"/>
<junction x="-33.02" y="35.56"/>
<junction x="-33.02" y="71.12"/>
<wire x1="2.54" y1="0" x2="-33.02" y2="0" width="0.1524" layer="91"/>
<junction x="-33.02" y="0"/>
</segment>
<segment>
<wire x1="-30.48" y1="-12.7" x2="-30.48" y2="-7.62" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/1" pin="B"/>
<wire x1="-30.48" y1="-7.62" x2="-30.48" y2="22.86" width="0.1524" layer="91"/>
<wire x1="-30.48" y1="22.86" x2="-30.48" y2="48.26" width="0.1524" layer="91"/>
<wire x1="-30.48" y1="48.26" x2="-30.48" y2="86.36" width="0.1524" layer="91"/>
<wire x1="-30.48" y1="86.36" x2="-30.48" y2="96.52" width="0.1524" layer="91"/>
<wire x1="-22.86" y1="86.36" x2="-30.48" y2="86.36" width="0.1524" layer="91"/>
<wire x1="-22.86" y1="48.26" x2="-30.48" y2="48.26" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/1" pin="B"/>
<pinref part="IO2" gate="/4" pin="B"/>
<wire x1="2.54" y1="22.86" x2="-30.48" y2="22.86" width="0.1524" layer="91"/>
<junction x="-30.48" y="22.86"/>
<junction x="-30.48" y="48.26"/>
<junction x="-30.48" y="86.36"/>
<pinref part="IO4" gate="/2" pin="B"/>
<wire x1="25.4" y1="-7.62" x2="-30.48" y2="-7.62" width="0.1524" layer="91"/>
<junction x="-30.48" y="-7.62"/>
</segment>
<segment>
<wire x1="-27.94" y1="-12.7" x2="-27.94" y2="10.16" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/1" pin="A"/>
<wire x1="-27.94" y1="10.16" x2="-27.94" y2="30.48" width="0.1524" layer="91"/>
<wire x1="-27.94" y1="30.48" x2="-27.94" y2="53.34" width="0.1524" layer="91"/>
<wire x1="-27.94" y1="53.34" x2="-27.94" y2="91.44" width="0.1524" layer="91"/>
<wire x1="-27.94" y1="91.44" x2="-27.94" y2="96.52" width="0.1524" layer="91"/>
<wire x1="-22.86" y1="91.44" x2="-27.94" y2="91.44" width="0.1524" layer="91"/>
<wire x1="-22.86" y1="53.34" x2="-27.94" y2="53.34" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/1" pin="A"/>
<pinref part="IO2" gate="/3" pin="B"/>
<wire x1="-22.86" y1="30.48" x2="-27.94" y2="30.48" width="0.1524" layer="91"/>
<pinref part="IO3" gate="/3" pin="A"/>
<wire x1="-22.86" y1="10.16" x2="-27.94" y2="10.16" width="0.1524" layer="91"/>
<junction x="-27.94" y="30.48"/>
<junction x="-27.94" y="53.34"/>
<junction x="-27.94" y="91.44"/>
</segment>
</net>
<net name="N$2" class="0">
<segment>
<pinref part="IO3" gate="/1" pin="Y"/>
<wire x1="-2.54" y1="71.12" x2="0" y2="71.12" width="0.1524" layer="91"/>
<wire x1="0" y1="71.12" x2="0" y2="63.5" width="0.1524" layer="91"/>
<wire x1="0" y1="63.5" x2="2.54" y2="63.5" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/2" pin="A"/>
</segment>
</net>
<net name="N$3" class="0">
<segment>
<wire x1="-2.54" y1="50.8" x2="0" y2="50.8" width="0.1524" layer="91"/>
<wire x1="0" y1="50.8" x2="0" y2="58.42" width="0.1524" layer="91"/>
<wire x1="0" y1="58.42" x2="2.54" y2="58.42" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/1" pin="Y"/>
<pinref part="IO2" gate="/2" pin="B"/>
</segment>
</net>
<net name="N$4" class="0">
<segment>
<pinref part="IO1" gate="/1" pin="Y"/>
<wire x1="-2.54" y1="88.9" x2="17.78" y2="88.9" width="0.1524" layer="91"/>
<wire x1="17.78" y1="88.9" x2="17.78" y2="81.28" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/2" pin="A"/>
<wire x1="17.78" y1="81.28" x2="25.4" y2="81.28" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$5" class="0">
<segment>
<wire x1="22.86" y1="60.96" x2="25.4" y2="60.96" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/2" pin="B"/>
<wire x1="25.4" y1="60.96" x2="25.4" y2="76.2" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/2" pin="Y"/>
</segment>
</net>
<net name="N$6" class="0">
<segment>
<pinref part="IO1" gate="/2" pin="Y"/>
<pinref part="IO3" gate="/2" pin="A"/>
<wire x1="45.72" y1="78.74" x2="50.8" y2="78.74" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$7" class="0">
<segment>
<pinref part="IO2" gate="/3" pin="Y"/>
<wire x1="-2.54" y1="33.02" x2="0" y2="33.02" width="0.1524" layer="91"/>
<wire x1="0" y1="33.02" x2="0" y2="27.94" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/4" pin="A"/>
<wire x1="0" y1="27.94" x2="2.54" y2="27.94" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$8" class="0">
<segment>
<pinref part="IO3" gate="/3" pin="Y"/>
<wire x1="-2.54" y1="10.16" x2="0" y2="10.16" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/1" pin="A"/>
<wire x1="0" y1="10.16" x2="0" y2="5.08" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$9" class="0">
<segment>
<pinref part="IO4" gate="/1" pin="Y"/>
<wire x1="20.32" y1="2.54" x2="22.86" y2="2.54" width="0.1524" layer="91"/>
<wire x1="22.86" y1="2.54" x2="22.86" y2="-2.54" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/2" pin="A"/>
<wire x1="22.86" y1="-2.54" x2="25.4" y2="-2.54" width="0.1524" layer="91"/>
</segment>
</net>
<net name="VCC" class="0">
<segment>
<pinref part="SUPPLY1" gate="G$1" pin="VCC"/>
<pinref part="IO3" gate="/2" pin="Y"/>
<wire x1="73.66" y1="78.74" x2="71.12" y2="78.74" width="0.1524" layer="91"/>
</segment>
<segment>
<pinref part="IO2" gate="/4" pin="Y"/>
<pinref part="SUPPLY2" gate="G$1" pin="VCC"/>
<wire x1="22.86" y1="25.4" x2="71.12" y2="25.4" width="0.1524" layer="91"/>
</segment>
<segment>
<pinref part="IO4" gate="/2" pin="Y"/>
<pinref part="SUPPLY3" gate="G$1" pin="VCC"/>
<wire x1="45.72" y1="-5.08" x2="68.58" y2="-5.08" width="0.1524" layer="91"/>
</segment>
</net>
</nets>
</sheet>
</sheets>
</schematic>
</drawing>
</eagle>
