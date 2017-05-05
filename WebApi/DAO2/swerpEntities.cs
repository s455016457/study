namespace DAO2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class swerpEntities : DbContext
    {
        public swerpEntities()
            : base("name=swerpEntities")
        {
        }

        public virtual DbSet<ACC> ACC { get; set; }
        public virtual DbSet<ACCCATEGORY> ACCCATEGORY { get; set; }
        public virtual DbSet<ACCPROJECT> ACCPROJECT { get; set; }
        public virtual DbSet<ACCRPT> ACCRPT { get; set; }
        public virtual DbSet<ACCRPTCATEGORY> ACCRPTCATEGORY { get; set; }
        public virtual DbSet<ACCRPTCOMPANY> ACCRPTCOMPANY { get; set; }
        public virtual DbSet<ACCRPTDEPARTMENT> ACCRPTDEPARTMENT { get; set; }
        public virtual DbSet<ACCRPTDTL> ACCRPTDTL { get; set; }
        public virtual DbSet<ACCRPTJOUTYPE> ACCRPTJOUTYPE { get; set; }
        public virtual DbSet<ACCRPTPROJECT> ACCRPTPROJECT { get; set; }
        public virtual DbSet<ACCTYPE> ACCTYPE { get; set; }
        public virtual DbSet<APAY> APAY { get; set; }
        public virtual DbSet<APAYADJUST> APAYADJUST { get; set; }
        public virtual DbSet<APAYADJUSTDTL> APAYADJUSTDTL { get; set; }
        public virtual DbSet<APAYDC> APAYDC { get; set; }
        public virtual DbSet<APAYDTL> APAYDTL { get; set; }
        public virtual DbSet<APCLET> APCLET { get; set; }
        public virtual DbSet<APPLOG> APPLOG { get; set; }
        public virtual DbSet<APPTKT> APPTKT { get; set; }
        public virtual DbSet<APREQA> APREQA { get; set; }
        public virtual DbSet<APREQB> APREQB { get; set; }
        public virtual DbSet<APRFND> APRFND { get; set; }
        public virtual DbSet<AQL> AQL { get; set; }
        public virtual DbSet<ARCLET> ARCLET { get; set; }
        public virtual DbSet<AREC> AREC { get; set; }
        public virtual DbSet<ARECADJUST> ARECADJUST { get; set; }
        public virtual DbSet<ARECADJUSTDTL> ARECADJUSTDTL { get; set; }
        public virtual DbSet<ARECDC> ARECDC { get; set; }
        public virtual DbSet<ARECDTL> ARECDTL { get; set; }
        public virtual DbSet<BANKAC> BANKAC { get; set; }
        public virtual DbSet<BDMODA> BDMODA { get; set; }
        public virtual DbSet<BDMODB> BDMODB { get; set; }
        public virtual DbSet<BDMODC> BDMODC { get; set; }
        public virtual DbSet<BEGITEMSBAL> BEGITEMSBAL { get; set; }
        public virtual DbSet<BEGPAYBAL> BEGPAYBAL { get; set; }
        public virtual DbSet<BEGRECBAL> BEGRECBAL { get; set; }
        public virtual DbSet<BOM> BOM { get; set; }
        public virtual DbSet<BOMDTL> BOMDTL { get; set; }
        public virtual DbSet<BOMSCA> BOMSCA { get; set; }
        public virtual DbSet<BOMSCB> BOMSCB { get; set; }
        public virtual DbSet<BOOKMARK> BOOKMARK { get; set; }
        public virtual DbSet<BTNMNU> BTNMNU { get; set; }
        public virtual DbSet<BUYER> BUYER { get; set; }
        public virtual DbSet<CALDAR> CALDAR { get; set; }
        public virtual DbSet<COMINF> COMINF { get; set; }
        public virtual DbSet<COORAA> COORAA { get; set; }
        public virtual DbSet<COORAB> COORAB { get; set; }
        public virtual DbSet<CRAPLY> CRAPLY { get; set; }
        public virtual DbSet<CRMABA> CRMABA { get; set; }
        public virtual DbSet<CRMATV> CRMATV { get; set; }
        public virtual DbSet<CRMBOA> CRMBOA { get; set; }
        public virtual DbSet<CRMBOB> CRMBOB { get; set; }
        public virtual DbSet<CRMBOC> CRMBOC { get; set; }
        public virtual DbSet<CRMCPA> CRMCPA { get; set; }
        public virtual DbSet<CRMCPB> CRMCPB { get; set; }
        public virtual DbSet<CRMCPC> CRMCPC { get; set; }
        public virtual DbSet<CRMCSA> CRMCSA { get; set; }
        public virtual DbSet<CRMCSB> CRMCSB { get; set; }
        public virtual DbSet<CRMCSC> CRMCSC { get; set; }
        public virtual DbSet<CRMCSD> CRMCSD { get; set; }
        public virtual DbSet<CRMCSE> CRMCSE { get; set; }
        public virtual DbSet<CRMCTA> CRMCTA { get; set; }
        public virtual DbSet<CRMCTB> CRMCTB { get; set; }
        public virtual DbSet<CRMCUS> CRMCUS { get; set; }
        public virtual DbSet<CRMTSK> CRMTSK { get; set; }
        public virtual DbSet<CRMWPA> CRMWPA { get; set; }
        public virtual DbSet<CRMWPB> CRMWPB { get; set; }
        public virtual DbSet<CRMWPC> CRMWPC { get; set; }
        public virtual DbSet<CSTACC> CSTACC { get; set; }
        public virtual DbSet<CSTBFA> CSTBFA { get; set; }
        public virtual DbSet<CSTBFB> CSTBFB { get; set; }
        public virtual DbSet<CSTCPA> CSTCPA { get; set; }
        public virtual DbSet<CSTCPB> CSTCPB { get; set; }
        public virtual DbSet<CSTELT> CSTELT { get; set; }
        public virtual DbSet<CSTMAA> CSTMAA { get; set; }
        public virtual DbSet<CSTMAB> CSTMAB { get; set; }
        public virtual DbSet<CSTOPH> CSTOPH { get; set; }
        public virtual DbSet<CSTRPT> CSTRPT { get; set; }
        public virtual DbSet<CSTSCA> CSTSCA { get; set; }
        public virtual DbSet<CSTSCB> CSTSCB { get; set; }
        public virtual DbSet<CSTSCC> CSTSCC { get; set; }
        public virtual DbSet<CSTSCD> CSTSCD { get; set; }
        public virtual DbSet<CURR> CURR { get; set; }
        public virtual DbSet<CUSEVA> CUSEVA { get; set; }
        public virtual DbSet<CUSITEMS> CUSITEMS { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<CUSTYPE> CUSTYPE { get; set; }
        public virtual DbSet<DEFECTHANDLING> DEFECTHANDLING { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual DbSet<DEVINF> DEVINF { get; set; }
        public virtual DbSet<DICTAA> DICTAA { get; set; }
        public virtual DbSet<DICTAB> DICTAB { get; set; }
        public virtual DbSet<DISAMA> DISAMA { get; set; }
        public virtual DbSet<DISAMB> DISAMB { get; set; }
        public virtual DbSet<DOCUPDATEMESSAGEA> DOCUPDATEMESSAGEA { get; set; }
        public virtual DbSet<DOCUPDATEMESSAGEB> DOCUPDATEMESSAGEB { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<ECITYA> ECITYA { get; set; }
        public virtual DbSet<ECNBOM> ECNBOM { get; set; }
        public virtual DbSet<ECNBOMDTL> ECNBOMDTL { get; set; }
        public virtual DbSet<ECNTEA> ECNTEA { get; set; }
        public virtual DbSet<ECNTEB> ECNTEB { get; set; }
        public virtual DbSet<EDISTR> EDISTR { get; set; }
        public virtual DbSet<EFILEA> EFILEA { get; set; }
        public virtual DbSet<EFILEB> EFILEB { get; set; }
        public virtual DbSet<EFILEC> EFILEC { get; set; }
        public virtual DbSet<EFILED> EFILED { get; set; }
        public virtual DbSet<EGROUP> EGROUP { get; set; }
        public virtual DbSet<EINBOX> EINBOX { get; set; }
        public virtual DbSet<EMEMBR> EMEMBR { get; set; }
        public virtual DbSet<ENOTES> ENOTES { get; set; }
        public virtual DbSet<EOPTON> EOPTON { get; set; }
        public virtual DbSet<EPROVI> EPROVI { get; set; }
        public virtual DbSet<ETYPEA> ETYPEA { get; set; }
        public virtual DbSet<ETYPEB> ETYPEB { get; set; }
        public virtual DbSet<EXPCOT> EXPCOT { get; set; }
        public virtual DbSet<EXPORT> EXPORT { get; set; }
        public virtual DbSet<FACDAR> FACDAR { get; set; }
        public virtual DbSet<FLWDAD> FLWDAD { get; set; }
        public virtual DbSet<FLWDAT> FLWDAT { get; set; }
        public virtual DbSet<FLWMID> FLWMID { get; set; }
        public virtual DbSet<FLWNTF> FLWNTF { get; set; }
        public virtual DbSet<FLWSTP> FLWSTP { get; set; }
        public virtual DbSet<FLWTPL> FLWTPL { get; set; }
        public virtual DbSet<FLWUSR> FLWUSR { get; set; }
        public virtual DbSet<FOMLAA> FOMLAA { get; set; }
        public virtual DbSet<FOMLAB> FOMLAB { get; set; }
        public virtual DbSet<FPERIOD> FPERIOD { get; set; }
        public virtual DbSet<FXDINV> FXDINV { get; set; }
        public virtual DbSet<FXDSTM> FXDSTM { get; set; }
        public virtual DbSet<GRACRA> GRACRA { get; set; }
        public virtual DbSet<GRACRB> GRACRB { get; set; }
        public virtual DbSet<GRACRC> GRACRC { get; set; }
        public virtual DbSet<GRADATA> GRADATA { get; set; }
        public virtual DbSet<GRADEDATA> GRADEDATA { get; set; }
        public virtual DbSet<GRADVA> GRADVA { get; set; }
        public virtual DbSet<GRADVB> GRADVB { get; set; }
        public virtual DbSet<GRADVC> GRADVC { get; set; }
        public virtual DbSet<GRADVD> GRADVD { get; set; }
        public virtual DbSet<GRAMPA> GRAMPA { get; set; }
        public virtual DbSet<GRAMPB> GRAMPB { get; set; }
        public virtual DbSet<GRN> GRN { get; set; }
        public virtual DbSet<GRNDTL> GRNDTL { get; set; }
        public virtual DbSet<INQUIRY> INQUIRY { get; set; }
        public virtual DbSet<INQUIRYDTL> INQUIRYDTL { get; set; }
        public virtual DbSet<INSPECTIONITEM> INSPECTIONITEM { get; set; }
        public virtual DbSet<INVENTORY> INVENTORY { get; set; }
        public virtual DbSet<INVOICEREQUEST> INVOICEREQUEST { get; set; }
        public virtual DbSet<INVOICEREQUESTDTL> INVOICEREQUESTDTL { get; set; }
        public virtual DbSet<INVTYPE> INVTYPE { get; set; }
        public virtual DbSet<IPLIST> IPLIST { get; set; }
        public virtual DbSet<IQC> IQC { get; set; }
        public virtual DbSet<IQCDTL> IQCDTL { get; set; }
        public virtual DbSet<ITEMACYA> ITEMACYA { get; set; }
        public virtual DbSet<ITEMACYB> ITEMACYB { get; set; }
        public virtual DbSet<ITEMCN> ITEMCN { get; set; }
        public virtual DbSet<ITEMGRP> ITEMGRP { get; set; }
        public virtual DbSet<ITEMPM> ITEMPM { get; set; }
        public virtual DbSet<ITEMPV> ITEMPV { get; set; }
        public virtual DbSet<ITEMRA> ITEMRA { get; set; }
        public virtual DbSet<ITEMRB> ITEMRB { get; set; }
        public virtual DbSet<ITEMS> ITEMS { get; set; }
        public virtual DbSet<ITEMSP> ITEMSP { get; set; }
        public virtual DbSet<ITEMTA> ITEMTA { get; set; }
        public virtual DbSet<ITEMTYPE> ITEMTYPE { get; set; }
        public virtual DbSet<MAGENT> MAGENT { get; set; }
        public virtual DbSet<MATSCU> MATSCU { get; set; }
        public virtual DbSet<MATSTM> MATSTM { get; set; }
        public virtual DbSet<MENUITEM> MENUITEM { get; set; }
        public virtual DbSet<MESINV> MESINV { get; set; }
        public virtual DbSet<MESOPA> MESOPA { get; set; }
        public virtual DbSet<MESRFA> MESRFA { get; set; }
        public virtual DbSet<MESRFB> MESRFB { get; set; }
        public virtual DbSet<MESSOA> MESSOA { get; set; }
        public virtual DbSet<MESSOB> MESSOB { get; set; }
        public virtual DbSet<MESTPA> MESTPA { get; set; }
        public virtual DbSet<MESTPB> MESTPB { get; set; }
        public virtual DbSet<MESTPC> MESTPC { get; set; }
        public virtual DbSet<MESWEA> MESWEA { get; set; }
        public virtual DbSet<MESWEB> MESWEB { get; set; }
        public virtual DbSet<MESWOA> MESWOA { get; set; }
        public virtual DbSet<MESWOB> MESWOB { get; set; }
        public virtual DbSet<MESWOC> MESWOC { get; set; }
        public virtual DbSet<METAAA> METAAA { get; set; }
        public virtual DbSet<METAAB> METAAB { get; set; }
        public virtual DbSet<METAAC> METAAC { get; set; }
        public virtual DbSet<MI> MI { get; set; }
        public virtual DbSet<MIBKFH> MIBKFH { get; set; }
        public virtual DbSet<MIDTL> MIDTL { get; set; }
        public virtual DbSet<MIDTL2> MIDTL2 { get; set; }
        public virtual DbSet<MITYPE> MITYPE { get; set; }
        public virtual DbSet<MNUCTG> MNUCTG { get; set; }
        public virtual DbSet<MODULEACTION> MODULEACTION { get; set; }
        public virtual DbSet<MODULES> MODULES { get; set; }
        public virtual DbSet<MR> MR { get; set; }
        public virtual DbSet<MRDTL> MRDTL { get; set; }
        public virtual DbSet<MRPDOCQUERY> MRPDOCQUERY { get; set; }
        public virtual DbSet<MRPINT> MRPINT { get; set; }
        public virtual DbSet<MRPMIPLANA> MRPMIPLANA { get; set; }
        public virtual DbSet<MRPMIPLANB> MRPMIPLANB { get; set; }
        public virtual DbSet<MRPOUT> MRPOUT { get; set; }
        public virtual DbSet<MRPRESULT> MRPRESULT { get; set; }
        public virtual DbSet<MRPRLT> MRPRLT { get; set; }
        public virtual DbSet<MRPSCA> MRPSCA { get; set; }
        public virtual DbSet<MRPSCB> MRPSCB { get; set; }
        public virtual DbSet<MRPSCC> MRPSCC { get; set; }
        public virtual DbSet<MRPSCHEME> MRPSCHEME { get; set; }
        public virtual DbSet<MRPSCHEME1> MRPSCHEME1 { get; set; }
        public virtual DbSet<MRPSCHEME2> MRPSCHEME2 { get; set; }
        public virtual DbSet<MRPSCHEME3> MRPSCHEME3 { get; set; }
        public virtual DbSet<MRPWOPLAN> MRPWOPLAN { get; set; }
        public virtual DbSet<MRTYPE> MRTYPE { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigrequest> MSpeer_conflictdetectionconfigrequest { get; set; }
        public virtual DbSet<MSpeer_lsns> MSpeer_lsns { get; set; }
        public virtual DbSet<MYJOB> MYJOB { get; set; }
        public virtual DbSet<OCURRN> OCURRN { get; set; }
        public virtual DbSet<OCURTE> OCURTE { get; set; }
        public virtual DbSet<OGRNEN> OGRNEN { get; set; }
        public virtual DbSet<OPRJCT> OPRJCT { get; set; }
        public virtual DbSet<ORDERLEVEL> ORDERLEVEL { get; set; }
        public virtual DbSet<OTHAPA> OTHAPA { get; set; }
        public virtual DbSet<OTHAPD> OTHAPD { get; set; }
        public virtual DbSet<OTHARA> OTHARA { get; set; }
        public virtual DbSet<OTHARD> OTHARD { get; set; }
        public virtual DbSet<OTHEND> OTHEND { get; set; }
        public virtual DbSet<OTHENT> OTHENT { get; set; }
        public virtual DbSet<OTHGRN> OTHGRN { get; set; }
        public virtual DbSet<OWCRPT> OWCRPT { get; set; }
        public virtual DbSet<OWCRTT> OWCRTT { get; set; }
        public virtual DbSet<PAYMETHOD> PAYMETHOD { get; set; }
        public virtual DbSet<PAYTERM> PAYTERM { get; set; }
        public virtual DbSet<PO> PO { get; set; }
        public virtual DbSet<PODTL> PODTL { get; set; }
        public virtual DbSet<POTYPE> POTYPE { get; set; }
        public virtual DbSet<PPCAPA> PPCAPA { get; set; }
        public virtual DbSet<PR> PR { get; set; }
        public virtual DbSet<PRDCTA> PRDCTA { get; set; }
        public virtual DbSet<PRDCTB> PRDCTB { get; set; }
        public virtual DbSet<PRDCTC> PRDCTC { get; set; }
        public virtual DbSet<PRDCTD> PRDCTD { get; set; }
        public virtual DbSet<PRDCTE> PRDCTE { get; set; }
        public virtual DbSet<PRDIN2> PRDIN2 { get; set; }
        public virtual DbSet<PRDIN3> PRDIN3 { get; set; }
        public virtual DbSet<PRDIN4> PRDIN4 { get; set; }
        public virtual DbSet<PRDIN5> PRDIN5 { get; set; }
        public virtual DbSet<PRDIN6> PRDIN6 { get; set; }
        public virtual DbSet<PRDIN7> PRDIN7 { get; set; }
        public virtual DbSet<PRDINB> PRDINB { get; set; }
        public virtual DbSet<PRDINV> PRDINV { get; set; }
        public virtual DbSet<PRDOTB> PRDOTB { get; set; }
        public virtual DbSet<PRDRTA> PRDRTA { get; set; }
        public virtual DbSet<PRDST2> PRDST2 { get; set; }
        public virtual DbSet<PRDSTM> PRDSTM { get; set; }
        public virtual DbSet<PRDTL> PRDTL { get; set; }
        public virtual DbSet<PREGSA> PREGSA { get; set; }
        public virtual DbSet<PREGSB> PREGSB { get; set; }
        public virtual DbSet<PRLSCA> PRLSCA { get; set; }
        public virtual DbSet<PRLSCB> PRLSCB { get; set; }
        public virtual DbSet<PROCST> PROCST { get; set; }
        public virtual DbSet<PROCTA> PROCTA { get; set; }
        public virtual DbSet<PROCTB> PROCTB { get; set; }
        public virtual DbSet<PROINA> PROINA { get; set; }
        public virtual DbSet<PROINB> PROINB { get; set; }
        public virtual DbSet<PROITEMSCRAP> PROITEMSCRAP { get; set; }
        public virtual DbSet<PROITEMSCRAPDTL> PROITEMSCRAPDTL { get; set; }
        public virtual DbSet<PROLINE> PROLINE { get; set; }
        public virtual DbSet<PRORECORD> PRORECORD { get; set; }
        public virtual DbSet<PRORECORDDTL> PRORECORDDTL { get; set; }
        public virtual DbSet<PROSCH> PROSCH { get; set; }
        public virtual DbSet<PRSYSA> PRSYSA { get; set; }
        public virtual DbSet<PRSYSB> PRSYSB { get; set; }
        public virtual DbSet<PUR> PUR { get; set; }
        public virtual DbSet<PURAPA> PURAPA { get; set; }
        public virtual DbSet<PURAPB> PURAPB { get; set; }
        public virtual DbSet<PURDTL> PURDTL { get; set; }
        public virtual DbSet<PURIEN> PURIEN { get; set; }
        public virtual DbSet<PURIND> PURIND { get; set; }
        public virtual DbSet<PURINV> PURINV { get; set; }
        public virtual DbSet<PURRET> PURRET { get; set; }
        public virtual DbSet<PWKGRP> PWKGRP { get; set; }
        public virtual DbSet<QC> QC { get; set; }
        public virtual DbSet<QCDTL> QCDTL { get; set; }
        public virtual DbSet<QCITEM> QCITEM { get; set; }
        public virtual DbSet<QCMETHOD> QCMETHOD { get; set; }
        public virtual DbSet<QCSCHM> QCSCHM { get; set; }
        public virtual DbSet<QCTEAM> QCTEAM { get; set; }
        public virtual DbSet<QCWORKPROC> QCWORKPROC { get; set; }
        public virtual DbSet<QUERYA> QUERYA { get; set; }
        public virtual DbSet<QUOTATION> QUOTATION { get; set; }
        public virtual DbSet<QUOTATIONDTL> QUOTATIONDTL { get; set; }
        public virtual DbSet<QUTYPE> QUTYPE { get; set; }
        public virtual DbSet<RANKING> RANKING { get; set; }
        public virtual DbSet<RANKINGDTL> RANKINGDTL { get; set; }
        public virtual DbSet<RANKSTD> RANKSTD { get; set; }
        public virtual DbSet<RANKSTDDTL> RANKSTDDTL { get; set; }
        public virtual DbSet<REGHOR> REGHOR { get; set; }
        public virtual DbSet<REPACKING> REPACKING { get; set; }
        public virtual DbSet<REPACKINGDTL> REPACKINGDTL { get; set; }
        public virtual DbSet<REPORTS> REPORTS { get; set; }
        public virtual DbSet<ROLEACTION> ROLEACTION { get; set; }
        public virtual DbSet<RPINVA> RPINVA { get; set; }
        public virtual DbSet<RPINVB> RPINVB { get; set; }
        public virtual DbSet<RPTEXCEL> RPTEXCEL { get; set; }
        public virtual DbSet<SALESINVOICE> SALESINVOICE { get; set; }
        public virtual DbSet<SALESINVOICEDTL> SALESINVOICEDTL { get; set; }
        public virtual DbSet<SALESPERSON> SALESPERSON { get; set; }
        public virtual DbSet<SALESREGION> SALESREGION { get; set; }
        public virtual DbSet<SALFRD> SALFRD { get; set; }
        public virtual DbSet<SALFRT> SALFRT { get; set; }
        public virtual DbSet<SALRPA> SALRPA { get; set; }
        public virtual DbSet<SALRPB> SALRPB { get; set; }
        public virtual DbSet<SAMPSTD> SAMPSTD { get; set; }
        public virtual DbSet<SAMPSTDDTL> SAMPSTDDTL { get; set; }
        public virtual DbSet<SCCSTA> SCCSTA { get; set; }
        public virtual DbSet<SCCSTB> SCCSTB { get; set; }
        public virtual DbSet<SCCSTC> SCCSTC { get; set; }
        public virtual DbSet<SCCSTD> SCCSTD { get; set; }
        public virtual DbSet<SEMIWD> SEMIWD { get; set; }
        public virtual DbSet<SEMIWP> SEMIWP { get; set; }
        public virtual DbSet<SETPRN> SETPRN { get; set; }
        public virtual DbSet<SHIPPINGNOTE> SHIPPINGNOTE { get; set; }
        public virtual DbSet<SHIPPINGNOTEDTL> SHIPPINGNOTEDTL { get; set; }
        public virtual DbSet<SINV> SINV { get; set; }
        public virtual DbSet<SINVDATA> SINVDATA { get; set; }
        public virtual DbSet<SINVDTL> SINVDTL { get; set; }
        public virtual DbSet<SINVDTL2> SINVDTL2 { get; set; }
        public virtual DbSet<SINVDTL3> SINVDTL3 { get; set; }
        public virtual DbSet<SO> SO { get; set; }
        public virtual DbSet<SOACYA> SOACYA { get; set; }
        public virtual DbSet<SOACYB> SOACYB { get; set; }
        public virtual DbSet<SODTL> SODTL { get; set; }
        public virtual DbSet<SOFILE> SOFILE { get; set; }
        public virtual DbSet<SOPROREQUIRE> SOPROREQUIRE { get; set; }
        public virtual DbSet<SOPRVA> SOPRVA { get; set; }
        public virtual DbSet<SOPRVB> SOPRVB { get; set; }
        public virtual DbSet<SOPRVC> SOPRVC { get; set; }
        public virtual DbSet<SOPRVD> SOPRVD { get; set; }
        public virtual DbSet<SOREVW> SOREVW { get; set; }
        public virtual DbSet<SOTYPE> SOTYPE { get; set; }
        public virtual DbSet<SR> SR { get; set; }
        public virtual DbSet<SRAPPA> SRAPPA { get; set; }
        public virtual DbSet<SRAPPB> SRAPPB { get; set; }
        public virtual DbSet<SRCTYPE> SRCTYPE { get; set; }
        public virtual DbSet<SRDATA> SRDATA { get; set; }
        public virtual DbSet<SRDTL> SRDTL { get; set; }
        public virtual DbSet<SRDTL2> SRDTL2 { get; set; }
        public virtual DbSet<ST> ST { get; set; }
        public virtual DbSet<STDTL> STDTL { get; set; }
        public virtual DbSet<STDWKF> STDWKF { get; set; }
        public virtual DbSet<STOCKADJUST> STOCKADJUST { get; set; }
        public virtual DbSet<STOCKADJUSTDTL> STOCKADJUSTDTL { get; set; }
        public virtual DbSet<STOCKCOUNT> STOCKCOUNT { get; set; }
        public virtual DbSet<STOCKCOUNTDTL> STOCKCOUNTDTL { get; set; }
        public virtual DbSet<SUBGRN> SUBGRN { get; set; }
        public virtual DbSet<SUBGRNDTL> SUBGRNDTL { get; set; }
        public virtual DbSet<SUBSOA> SUBSOA { get; set; }
        public virtual DbSet<SUBSOD> SUBSOD { get; set; }
        public virtual DbSet<SYLOCK> SYLOCK { get; set; }
        public virtual DbSet<SYSPARAMETER> SYSPARAMETER { get; set; }
        public virtual DbSet<SYSPARVALUE> SYSPARVALUE { get; set; }
        public virtual DbSet<sysreplservers> sysreplservers { get; set; }
        public virtual DbSet<TRADETERM> TRADETERM { get; set; }
        public virtual DbSet<UNSCWA> UNSCWA { get; set; }
        public virtual DbSet<UNSCWB> UNSCWB { get; set; }
        public virtual DbSet<UOM> UOM { get; set; }
        public virtual DbSet<URPTAA> URPTAA { get; set; }
        public virtual DbSet<URPTAB> URPTAB { get; set; }
        public virtual DbSet<URPTAC> URPTAC { get; set; }
        public virtual DbSet<URPTAD> URPTAD { get; set; }
        public virtual DbSet<URPTAE> URPTAE { get; set; }
        public virtual DbSet<USERLOG> USERLOG { get; set; }
        public virtual DbSet<USEROP> USEROP { get; set; }
        public virtual DbSet<USERROLES> USERROLES { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<USRPRF> USRPRF { get; set; }
        public virtual DbSet<VBSTYP> VBSTYP { get; set; }
        public virtual DbSet<VENDOR> VENDOR { get; set; }
        public virtual DbSet<VENEVA> VENEVA { get; set; }
        public virtual DbSet<VENITEMS> VENITEMS { get; set; }
        public virtual DbSet<VENTYPE> VENTYPE { get; set; }
        public virtual DbSet<VOUCHR> VOUCHR { get; set; }
        public virtual DbSet<VOUENY> VOUENY { get; set; }
        public virtual DbSet<WAFERDATA> WAFERDATA { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSE { get; set; }
        public virtual DbSet<WHPLNE> WHPLNE { get; set; }
        public virtual DbSet<WHQRYA> WHQRYA { get; set; }
        public virtual DbSet<WIP> WIP { get; set; }
        public virtual DbSet<WIPDTL> WIPDTL { get; set; }
        public virtual DbSet<WIPDTL2> WIPDTL2 { get; set; }
        public virtual DbSet<WIPTYPE> WIPTYPE { get; set; }
        public virtual DbSet<WMSTER> WMSTER { get; set; }
        public virtual DbSet<WO> WO { get; set; }
        public virtual DbSet<WOCHANGE> WOCHANGE { get; set; }
        public virtual DbSet<WOMATERIALA> WOMATERIALA { get; set; }
        public virtual DbSet<WOMATERIALB> WOMATERIALB { get; set; }
        public virtual DbSet<WONLNE> WONLNE { get; set; }
        public virtual DbSet<WORKPROC> WORKPROC { get; set; }
        public virtual DbSet<WORKSHOP> WORKSHOP { get; set; }
        public virtual DbSet<WOTYPE> WOTYPE { get; set; }
        public virtual DbSet<WPBOMA> WPBOMA { get; set; }
        public virtual DbSet<WPBOMB> WPBOMB { get; set; }
        public virtual DbSet<WPCAPA> WPCAPA { get; set; }
        public virtual DbSet<WRKPRC> WRKPRC { get; set; }
        public virtual DbSet<BKFOTA> BKFOTA { get; set; }
        public virtual DbSet<BKFOUT> BKFOUT { get; set; }
        public virtual DbSet<CSTCPC> CSTCPC { get; set; }
        public virtual DbSet<CSTCPD> CSTCPD { get; set; }
        public virtual DbSet<CSTCPE> CSTCPE { get; set; }
        public virtual DbSet<CSTPAM> CSTPAM { get; set; }
        public virtual DbSet<FXDINA> FXDINA { get; set; }
        public virtual DbSet<FXDOUT> FXDOUT { get; set; }
        public virtual DbSet<MATINA> MATINA { get; set; }
        public virtual DbSet<MATOUT> MATOUT { get; set; }
        public virtual DbSet<MPARAM> MPARAM { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigresponse> MSpeer_conflictdetectionconfigresponse { get; set; }
        public virtual DbSet<MSpeer_originatorid_history> MSpeer_originatorid_history { get; set; }
        public virtual DbSet<MSpeer_request> MSpeer_request { get; set; }
        public virtual DbSet<MSpeer_response> MSpeer_response { get; set; }
        public virtual DbSet<MSpeer_topologyrequest> MSpeer_topologyrequest { get; set; }
        public virtual DbSet<MSpeer_topologyresponse> MSpeer_topologyresponse { get; set; }
        public virtual DbSet<MSpub_identity_range> MSpub_identity_range { get; set; }
        public virtual DbSet<OPARAM> OPARAM { get; set; }
        public virtual DbSet<PPARAM> PPARAM { get; set; }
        public virtual DbSet<PRDINA> PRDINA { get; set; }
        public virtual DbSet<PRDOUT> PRDOUT { get; set; }
        public virtual DbSet<SPARAM> SPARAM { get; set; }
        public virtual DbSet<sysarticlecolumns> sysarticlecolumns { get; set; }
        public virtual DbSet<sysarticles> sysarticles { get; set; }
        public virtual DbSet<sysarticleupdates> sysarticleupdates { get; set; }
        public virtual DbSet<syspublications> syspublications { get; set; }
        public virtual DbSet<sysschemaarticles> sysschemaarticles { get; set; }
        public virtual DbSet<syssubscriptions> syssubscriptions { get; set; }
        public virtual DbSet<SYSTEMINIT> SYSTEMINIT { get; set; }
        public virtual DbSet<systranschemas> systranschemas { get; set; }
        public virtual DbSet<VersionInfo> VersionInfo { get; set; }
        public virtual DbSet<AVLSALESREJECT> AVLSALESREJECT { get; set; }
        public virtual DbSet<LACC> LACC { get; set; }
        public virtual DbSet<OUTSTANDINGPO> OUTSTANDINGPO { get; set; }
        public virtual DbSet<OUTSTANDINGPR> OUTSTANDINGPR { get; set; }
        public virtual DbSet<OUTSTANDINGSO> OUTSTANDINGSO { get; set; }
        public virtual DbSet<OUTSTANDINGWO> OUTSTANDINGWO { get; set; }
        public virtual DbSet<syncobj_0x3737364133353237> syncobj_0x3737364133353237 { get; set; }
        public virtual DbSet<syncobj_0x4436464438373633> syncobj_0x4436464438373633 { get; set; }
        public virtual DbSet<sysextendedarticlesview> sysextendedarticlesview { get; set; }
        public virtual DbSet<V_ACCGRN> V_ACCGRN { get; set; }
        public virtual DbSet<V_API_REPORT_GRNHistory> V_API_REPORT_GRNHistory { get; set; }
        public virtual DbSet<V_API_REPORT_OutstandingPO> V_API_REPORT_OutstandingPO { get; set; }
        public virtual DbSet<V_API_REPORT_OutstandingPR> V_API_REPORT_OutstandingPR { get; set; }
        public virtual DbSet<V_API_REPORT_OutstandingSO> V_API_REPORT_OutstandingSO { get; set; }
        public virtual DbSet<V_API_REPORT_OutstandingWO> V_API_REPORT_OutstandingWO { get; set; }
        public virtual DbSet<V_API_REPORT_PO> V_API_REPORT_PO { get; set; }
        public virtual DbSet<V_API_REPORT_POHistory> V_API_REPORT_POHistory { get; set; }
        public virtual DbSet<V_API_REPORT_PRHistory> V_API_REPORT_PRHistory { get; set; }
        public virtual DbSet<V_API_REPORT_SiHistory> V_API_REPORT_SiHistory { get; set; }
        public virtual DbSet<V_API_REPORT_SOHistory> V_API_REPORT_SOHistory { get; set; }
        public virtual DbSet<V_API_REPORT_WipHistory> V_API_REPORT_WipHistory { get; set; }
        public virtual DbSet<V_API_REPORT_WO> V_API_REPORT_WO { get; set; }
        public virtual DbSet<V_API_REPORT_WOHistory> V_API_REPORT_WOHistory { get; set; }
        public virtual DbSet<V_API_RESORT_SO> V_API_RESORT_SO { get; set; }
        public virtual DbSet<V_COMPANY> V_COMPANY { get; set; }
        public virtual DbSet<V_GRADEINVENTORY> V_GRADEINVENTORY { get; set; }
        public virtual DbSet<V_INVENTORY> V_INVENTORY { get; set; }
        public virtual DbSet<V_INVENTORYITEMS> V_INVENTORYITEMS { get; set; }
        public virtual DbSet<V_IQCDTLITEM> V_IQCDTLITEM { get; set; }
        public virtual DbSet<V_MIDTL> V_MIDTL { get; set; }
        public virtual DbSet<V_PAYEE> V_PAYEE { get; set; }
        public virtual DbSet<V_PO_HISTORY> V_PO_HISTORY { get; set; }
        public virtual DbSet<V_PR_HISTORY> V_PR_HISTORY { get; set; }
        public virtual DbSet<V_QCDTLITEM> V_QCDTLITEM { get; set; }
        public virtual DbSet<V_QCWO> V_QCWO { get; set; }
        public virtual DbSet<V_QUERYSEQNUM> V_QUERYSEQNUM { get; set; }
        public virtual DbSet<V_SINV_HISTORY> V_SINV_HISTORY { get; set; }
        public virtual DbSet<V_SINVDTL> V_SINVDTL { get; set; }
        public virtual DbSet<V_SINVDTL2> V_SINVDTL2 { get; set; }
        public virtual DbSet<V_SINVSCAN_HISTORY> V_SINVSCAN_HISTORY { get; set; }
        public virtual DbSet<V_SO_HISTORY> V_SO_HISTORY { get; set; }
        public virtual DbSet<V_STOCKADJUST> V_STOCKADJUST { get; set; }
        public virtual DbSet<V_STOCKADJUSTDTL> V_STOCKADJUSTDTL { get; set; }
        public virtual DbSet<V_UNSETGRNFORPI> V_UNSETGRNFORPI { get; set; }
        public virtual DbSet<V_UNSETGRNFORPI_BAK> V_UNSETGRNFORPI_BAK { get; set; }
        public virtual DbSet<V_UNSETSINVFORINVOICE> V_UNSETSINVFORINVOICE { get; set; }
        public virtual DbSet<V_WAFERINVENTORY> V_WAFERINVENTORY { get; set; }
        public virtual DbSet<V_WIP> V_WIP { get; set; }
        public virtual DbSet<V_WIP_HISTORY> V_WIP_HISTORY { get; set; }
        public virtual DbSet<V_WIPDTL> V_WIPDTL { get; set; }
        public virtual DbSet<V_WIPSCAN_HISTORY> V_WIPSCAN_HISTORY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC>()
                .Property(e => e.PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC>()
                .Property(e => e.BAL)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.BAL1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.DR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.CR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.YDR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.YCR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ACC>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCCATEGORY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCCATEGORY>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ACCPROJECT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCPROJECT>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPT>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPT>()
                .Property(e => e.JOUFROM)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPT>()
                .Property(e => e.JOUTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTCATEGORY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTCATEGORY>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTCOMPANY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTCOMPANY>()
                .Property(e => e.COMPID)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTDEPARTMENT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTDEPARTMENT>()
                .Property(e => e.DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTDTL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTDTL>()
                .Property(e => e.ACC)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTJOUTYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTJOUTYPE>()
                .Property(e => e.JOUTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTPROJECT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCRPTPROJECT>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<ACCTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.APNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.PAYEE)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<APAY>()
                .Property(e => e.CHK)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.CHKACC)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAY>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAY>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.AANUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUST>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.AANUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<APAYADJUSTDTL>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.APNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.LINEMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.DEBIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.APNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.BASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APAYDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.BASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APCLET>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<APPLOG>()
                .Property(e => e.APPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<APPLOG>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<APPLOG>()
                .Property(e => e.METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<APPLOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<APPTKT>()
                .Property(e => e.APPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<APPTKT>()
                .Property(e => e.APPSECRET)
                .IsUnicode(false);

            modelBuilder.Entity<APPTKT>()
                .Property(e => e.ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.AQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<APREQA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.AQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.ODNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APREQB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.PAYEE)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.CHK)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.CHKACC)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<APRFND>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<AQL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AQL>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<AQL>()
                .Property(e => e.AQLDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.BASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARCLET>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.ARNUM)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.RECACC)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<AREC>()
                .Property(e => e.CHK)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.CHKACC)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<AREC>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<AREC>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.PRJNUM)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<AREC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.AANUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.RECACC)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUST>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.AANUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ARECADJUSTDTL>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.ARNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.LINEMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.DEBIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.ARNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.BASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.CURR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ARECDTL>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.CURRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<BANKAC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODA>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODA>()
                .Property(e => e.TABLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODA>()
                .Property(e => e.SHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODB>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODB>()
                .Property(e => e.SHOWFIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODB>()
                .Property(e => e.FIELDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODB>()
                .Property(e => e.SHOWTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODC>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODC>()
                .Property(e => e.SHOWFIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODC>()
                .Property(e => e.FIELDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BDMODC>()
                .Property(e => e.SHOWTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.UPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(28, 12);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BEGITEMSBAL>()
                .Property(e => e.INVACC)
                .IsUnicode(false);

            modelBuilder.Entity<BEGPAYBAL>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<BEGPAYBAL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BEGPAYBAL>()
                .Property(e => e.INVAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BEGPAYBAL>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<BEGRECBAL>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<BEGRECBAL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BEGRECBAL>()
                .Property(e => e.INVAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BEGRECBAL>()
                .Property(e => e.RECACC)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.ADDONS)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BOM>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.SCPRATE)
                .HasPrecision(10, 7);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<BOMDTL>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.ADDONS)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCA>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.SCPRATE)
                .HasPrecision(10, 7);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<BOMSCB>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BOOKMARK>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<BOOKMARK>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BOOKMARK>()
                .Property(e => e.PREFIX)
                .IsUnicode(false);

            modelBuilder.Entity<BOOKMARK>()
                .Property(e => e.CY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOOKMARK>()
                .Property(e => e.CM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMACTION)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMREPORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BTNMNU>()
                .Property(e => e.ITEMSCRIPT)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .Property(e => e.BUYERTEL)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .Property(e => e.BUYERFAX)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .Property(e => e.SYSUID)
                .IsUnicode(false);

            modelBuilder.Entity<BUYER>()
                .HasMany(e => e.PO)
                .WithOptional(e => e.BUYER1)
                .HasForeignKey(e => e.BUYER);

            modelBuilder.Entity<BUYER>()
                .HasMany(e => e.VENDOR)
                .WithOptional(e => e.BUYER1)
                .HasForeignKey(e => e.BUYER);

            modelBuilder.Entity<CALDAR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CALDAR>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.COMPNAMECHN)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.COMPNAMEENG)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.ADDRCHN)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.ADDRENG)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.TEL1)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.TEL2)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SINSUREACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SHANDLEACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PINSUREACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PHANDLEACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SALESTAXACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PURTAXACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.TRANSACC)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PTEL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.PFAX)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.STEL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.SFAX)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WTEL)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WFAX)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.WADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.LICENSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.VERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.REPORTSPATH)
                .IsUnicode(false);

            modelBuilder.Entity<COMINF>()
                .Property(e => e.LOGOPATH)
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.VIEWJSON)
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<COORAA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<COORAB>()
                .Property(e => e.SHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<COORAB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<COORAB>()
                .Property(e => e.FONTCOLOUR)
                .IsUnicode(false);

            modelBuilder.Entity<COORAB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<COORAB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.CANUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.OUTSOAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.CLBAL)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.CRDLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.OLDXLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.NEWXLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRAPLY>()
                .Property(e => e.NEWCREDITLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.ABNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.ABNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.ABTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.ICQ)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.MSN)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.ALIIM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.YAHOO)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.GOOGLE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.WEIBO)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.OTHERIM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMABA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.REFOBJECT)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.REFKEY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMATV>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CBONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CONTACTTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CONTACTFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CONTACTMOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CONTACTEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.OPPORTUNITYSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.PROBABILITY)
                .HasPrecision(10, 5);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.COMPLETEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.CBONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.PRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.DISCOUNTRATE)
                .HasPrecision(10, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.DISCOUNTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.DISCOUNTEDAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOC>()
                .Property(e => e.CBONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOC>()
                .Property(e => e.OPPORTUNITYSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOC>()
                .Property(e => e.PROBABILITY)
                .HasPrecision(10, 5);

            modelBuilder.Entity<CRMBOC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMBOC>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.CPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.COMPETITIVELEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.ZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPB>()
                .Property(e => e.CPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPC>()
                .Property(e => e.CPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPC>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCPC>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CONTACTTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CONTACTFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CONTACTMOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CONTACTEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.REFDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.REFUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.PROCDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.PROCUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.SATISFACTION)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.RETUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.COMPLETEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.CSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.PRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSC>()
                .Property(e => e.CSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSC>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSC>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSD>()
                .Property(e => e.CSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSD>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSD>()
                .Property(e => e.PROCUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSD>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.CSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.SATISFACTION)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.RETUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCSE>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.CTANUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.RELATION)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.FAMILY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.EDUCATION)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.MARITALSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.IMPORTANCE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.ZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.OFFICEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.OFFICEFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.HOMEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.MSN)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.ALIIM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.YAHOO)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.GOOGLE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.WEIBO)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.OTHERIM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CTBNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CONTACTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.MEANS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CONTACTTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CONTACTFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CONTACTMOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CONTACTEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.EXPENSE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCTB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CUSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.ZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.ASSISTANT)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CUSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CUSLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.PRICELEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CREDITLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.NATURE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.SCALE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.TAXPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.REFCUSID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMCUS>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.PRIORITY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.COMPLETEDRATE)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.REFOBJECT)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.REFKEY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMTSK>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.WPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.WPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.WPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.APPRAISALBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CRMWPC>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CSTACC>()
                .Property(e => e.CSTELT)
                .IsUnicode(false);

            modelBuilder.Entity<CSTACC>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.CSTBFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(28, 5);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.CSTBFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.UPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(28, 5);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTBFB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.PARTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.MITYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.REFPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.REFWONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPA>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDWRK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDWRKRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDWRK2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDWRK2RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.WORKHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.WORKHOUR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.LABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.FACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.FUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALWRKHR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALWRKHR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALLABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALFACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALFUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDMATCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALSTDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALSTDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALSTDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.TOTALSTDCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.STDUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<CSTCPB>()
                .Property(e => e.PROLINENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CSTELT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTELT>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.CSTMANUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAB>()
                .Property(e => e.CSTMANUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTMAB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTMAB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTOPH>()
                .Property(e => e.OPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.MQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.LYAVGUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YPUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.MACTUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YACTAVGUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.MLTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.MYPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.MACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YLACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YYPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTRPT>()
                .Property(e => e.YYACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.CSTSCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCB>()
                .Property(e => e.CSTSCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCB>()
                .Property(e => e.SCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTSCB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCC>()
                .Property(e => e.SCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCC>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCC>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCC>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTSCC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCD>()
                .Property(e => e.SCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCD>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCD>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTSCD>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTSCD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CENUM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CUSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CREDITLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.REGISTERCAPITAL)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.VALIDPERIOD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BUSINESSSCOPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.LEGALMASTER)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PURCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PURMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PURTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PURFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.PURADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHIPTOCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHIPTOMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHIPTOTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHIPTOFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SHIPTOADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BILLTOCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BILLTOMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BILLTOTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BILLTOFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.BILLTOADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.RECACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.SALESACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.ARACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.RECTMPACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.ORACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.INVOUTACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSEVA>()
                .Property(e => e.RANKLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CUSITEMS>()
                .Property(e => e.LABELNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PURCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PURMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PURTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PURFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PURADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTOCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTOMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTOTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTOFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTOADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BILLTOCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BILLTOMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BILLTOTEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BILLTOFAX)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BILLTOADDR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREDITLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CLBAL)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.XCREDITLIMIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.RECACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SALESACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ARACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.RECTMPACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ORACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.INVOUTACC)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ASSISTANT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SOREMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.RANKLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ORDERLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<DEFECTHANDLING>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DEFECTHANDLING>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.CREATEDBY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.UPDATEUSER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.ESN)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.IMEI)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.MEID)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.MODELID)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.STORAGE)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.LOTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.PROGRESS)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.REQUESTPARAM)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.REQUESTCOOKIE)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.RESPONDRAW)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.ERRORMESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.HTMLSTRING)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.DEVICENAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<DEVINF>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAA>()
                .Property(e => e.DICTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAA>()
                .Property(e => e.DICTTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DICTFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DICTFIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DICTFIELDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.CTLTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DATASRC)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DATAVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<DICTAB>()
                .Property(e => e.DATATEXT)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.DISAMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DISAMA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.DISAMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<DISAMB>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEA>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEA>()
                .Property(e => e.TABLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEA>()
                .Property(e => e.TABLESHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEA>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEA>()
                .Property(e => e.FIELDSHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEB>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUPDATEMESSAGEB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<ECITYA>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<ECITYA>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<ECITYA>()
                .Property(e => e.ASSISTANT)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.ADDONS)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.ECNBOMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOM>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.SCPRATE)
                .HasPrecision(10, 7);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ECNBOMDTL>()
                .Property(e => e.ECNBOMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.ECNTENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.ECNTETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.ECNTENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.PARTNUM1)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.UOM1)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.QTY1)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.SCPRATE1)
                .HasPrecision(10, 7);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.PARTNUM2)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.UOM2)
                .IsUnicode(false);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.QTY2)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.SCPRATE2)
                .HasPrecision(10, 7);

            modelBuilder.Entity<ECNTEB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<EDISTR>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<EDISTR>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EDISTR>()
                .Property(e => e.DISTRICT)
                .IsUnicode(false);

            modelBuilder.Entity<EDISTR>()
                .Property(e => e.ASSISTANT)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.TYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.REFKEY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.EXTENSION)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.CONTENTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEB>()
                .Property(e => e.TYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEB>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEB>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILEC>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILED>()
                .Property(e => e.SHARETO)
                .IsUnicode(false);

            modelBuilder.Entity<EFILED>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EFILED>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EGROUP>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<EGROUP>()
                .Property(e => e.GRPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EINBOX>()
                .Property(e => e.RECIPIENT)
                .IsUnicode(false);

            modelBuilder.Entity<EINBOX>()
                .Property(e => e.FOLDER)
                .IsUnicode(false);

            modelBuilder.Entity<EMEMBR>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<EMEMBR>()
                .Property(e => e.MAILID)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.SENDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.RECIPIENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.COPYRECIPIENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.SUBJECT)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.DATAPARAMS)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.MSGDATA)
                .IsUnicode(false);

            modelBuilder.Entity<ENOTES>()
                .Property(e => e.ATTACHMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EOPTON>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<EPROVI>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<EPROVI>()
                .Property(e => e.ASSISTANT)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEA>()
                .Property(e => e.MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEA>()
                .Property(e => e.GROUPID)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEB>()
                .Property(e => e.MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEB>()
                .Property(e => e.GROUPID)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEB>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ETYPEB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<EXPCOT>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<EXPCOT>()
                .Property(e => e.COST1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<EXPCOT>()
                .Property(e => e.COST2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<EXPCOT>()
                .Property(e => e.COST3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<EXPORT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EXPORT>()
                .Property(e => e.FIELD)
                .IsUnicode(false);

            modelBuilder.Entity<EXPORT>()
                .Property(e => e.DATATYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EXPORT>()
                .Property(e => e.FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<FACDAR>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<FACDAR>()
                .Property(e => e.WORKHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FACDAR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAD>()
                .Property(e => e.USRID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAD>()
                .Property(e => e.FSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAD>()
                .Property(e => e.STPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAD>()
                .Property(e => e.AGENTUID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAD>()
                .Property(e => e.APPROVALBY)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAT>()
                .Property(e => e.USRID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAT>()
                .Property(e => e.DOCENTRY)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAT>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAT>()
                .Property(e => e.FSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FLWDAT>()
                .Property(e => e.ISDRAFT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.SRCPATH)
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.TABLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.PKFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.DETAILTABLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLWMID>()
                .Property(e => e.DETAILPKFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FLWNTF>()
                .Property(e => e.RESTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<FLWNTF>()
                .Property(e => e.USRID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWSTP>()
                .Property(e => e.STPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLWSTP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.WFNAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<FLWTPL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<FLWUSR>()
                .Property(e => e.USRID)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAA>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAA>()
                .Property(e => e.DATASRC)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAA>()
                .Property(e => e.FILTERFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAB>()
                .Property(e => e.TYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAB>()
                .Property(e => e.DATASRC)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAB>()
                .Property(e => e.SELECTFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAB>()
                .Property(e => e.FILTERFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FOMLAB>()
                .Property(e => e.INPUTFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINV>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.MIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDSTM>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.LABELIDSEPARATOR)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.LABELNAMESEPARATOR_B)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.WFSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.ISPRINTED)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.RANKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.LABELNAMESEPARATOR_C)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.NAMECOMBINATIONMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRB>()
                .Property(e => e.LABELIDCOMBINATIONMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.RANKSTDDTL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.MIN)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.MAX)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.RANGEUOM)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.X1)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.Y1)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.X2)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.Y2)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.X3)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.Y3)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.X4)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.Y4)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRACRC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.LABELDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.VIEWJSON)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADATA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFAID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVAID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDAID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFBID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVBID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDBID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFCID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVCID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDCID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS1X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS1Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS2X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS2Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS3X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS3Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS4X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POS4Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CTID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.FLUXID)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.POWERSUPPLY)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CHIPSIZE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CHIPSUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.SHELLCOLOR)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.CABLETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADEDATA>()
                .Property(e => e.LABELDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVA>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.MIN)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.MAX)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.AVG)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.X)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.Y)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.Z)
                .HasPrecision(19, 9);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVD>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVD>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRADVD>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.VIEWJSON)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.DATATYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.SHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.FONTCOLOUR)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRAMPB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.YOURREF)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.GTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.GRNACC)
                .IsUnicode(false);

            modelBuilder.Entity<GRN>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.POLOT)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.GTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.INVACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<GRNDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.ISNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRY>()
                .Property(e => e.COMPLETEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.ISNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INQUIRYDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTIONITEM>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTIONITEM>()
                .Property(e => e.INSPITEMID)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTIONITEM>()
                .Property(e => e.INSPITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.INVREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.IRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.APPROVEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUEST>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.IRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INVOICEREQUESTDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INVTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<INVTYPE>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<INVTYPE>()
                .Property(e => e.INPUTVAT)
                .IsUnicode(false);

            modelBuilder.Entity<INVTYPE>()
                .Property(e => e.OUTPUTVAT)
                .IsUnicode(false);

            modelBuilder.Entity<INVTYPE>()
                .HasMany(e => e.PO)
                .WithOptional(e => e.INVTYPE1)
                .HasForeignKey(e => e.INVTYPE);

            modelBuilder.Entity<INVTYPE>()
                .HasMany(e => e.VENDOR)
                .WithOptional(e => e.INVTYPE1)
                .HasForeignKey(e => e.INVTYPE);

            modelBuilder.Entity<IPLIST>()
                .Property(e => e.IPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IPLIST>()
                .Property(e => e.IP1)
                .IsUnicode(false);

            modelBuilder.Entity<IPLIST>()
                .Property(e => e.IP2)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.IQCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.INSPECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQC>()
                .Property(e => e.CHECKQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQC>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQC>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQC>()
                .Property(e => e.DEFECTHANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.HANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQC>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IQC>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.IQCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.QCMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.QCITEM)
                .IsUnicode(false);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.QCUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.LOWERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.UPPERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.TARGETQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.PASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.SAMPLEPASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<IQCDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMACYB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.ITEMCNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.OLDITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.NEWITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.OLDSPEC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.NEWSPEC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ITEMCN>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMGRP>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMGRP>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMGRP>()
                .Property(e => e.ATTRIB)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMGRP>()
                .HasMany(e => e.ITEMS)
                .WithOptional(e => e.ITEMGRP1)
                .HasForeignKey(e => e.ITEMGRP);

            modelBuilder.Entity<ITEMPM>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMPM>()
                .Property(e => e.PARAMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMPV>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMPV>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMPV>()
                .Property(e => e.PARAMVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.IREPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.IREPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMRB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.EXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.ANGLE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.VENDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.CITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.VITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.COST1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.LASTPOUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.LASTPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.LASTSOUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.LASTSONUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.MINPACKQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.DENYUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.REFUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.REFUOM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMS>()
                .Property(e => e.STYLETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.SYSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.QTY1)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.QTY2)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.UPRICE1)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.UPRICE2)
                .HasPrecision(28, 12);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.LASTAPPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.CUSVEN)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMSP>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTA>()
                .Property(e => e.ITEMTYPEATTID)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTA>()
                .Property(e => e.ITEMTYPEATTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.ATTRIBTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.INVACC)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.OVERQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.OVERRATE)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.PREFIX)
                .IsUnicode(false);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.MINSCPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<ITEMTYPE>()
                .Property(e => e.MAXSCPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MAGENT>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<MAGENT>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<MAGENT>()
                .Property(e => e.AGENTID)
                .IsUnicode(false);

            modelBuilder.Entity<MATSCU>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATSCU>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATSCU>()
                .Property(e => e.SCITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATSCU>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.MIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATSTM>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.MNUCTG)
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.ORD)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.INVREMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESINV>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.PRODUCTIONLINE)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.DEVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESOPA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.MESRFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.MESRFTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.ORIDOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESRFA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.MESRFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESRFB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.MESSONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.MESSOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.ORIDOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESSOA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.MESSONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESSOB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.MESTPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.PRODUCTIONLINE)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.DEVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.TOTALINPUTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.TOTALOUTPUTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.MESTPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.DEVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.BINNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.MESTPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESTPC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.MESWENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.MESWETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESWEA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.MESWENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWEB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.SOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.PRODUCTIONLINE)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MESWOA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.BINNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFAID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVAID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDAID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFBID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVBID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDBID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDCID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS1X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS1Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS2X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS2Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS3X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS3Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS4X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.POS4Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.CTID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.FLUXID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOB>()
                .Property(e => e.RANKQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.DEVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.BINNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.SERIESNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MESWOC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.Entity)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.Table)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.Column)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.Property)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.RefTable)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.RefColumn)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.ThisColumns)
                .IsUnicode(false);

            modelBuilder.Entity<METAAA>()
                .Property(e => e.ThatColumns)
                .IsUnicode(false);

            modelBuilder.Entity<METAAB>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<METAAB>()
                .Property(e => e.Entity)
                .IsUnicode(false);

            modelBuilder.Entity<METAAB>()
                .Property(e => e.ParentEntity)
                .IsUnicode(false);

            modelBuilder.Entity<METAAB>()
                .Property(e => e.ThisProperties)
                .IsUnicode(false);

            modelBuilder.Entity<METAAB>()
                .Property(e => e.ThatProperties)
                .IsUnicode(false);

            modelBuilder.Entity<METAAC>()
                .Property(e => e.Entity)
                .IsUnicode(false);

            modelBuilder.Entity<METAAC>()
                .Property(e => e.Column)
                .IsUnicode(false);

            modelBuilder.Entity<METAAC>()
                .Property(e => e.Property)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.MITYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MI>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MI>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.WOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MIBKFH>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.ISSUEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.SCPRATE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.FREJECTEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MIDTL2>()
                .Property(e => e.INVREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MITYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MITYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MNUCTG>()
                .Property(e => e.MNUCTG1)
                .IsUnicode(false);

            modelBuilder.Entity<MNUCTG>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MNUCTG>()
                .Property(e => e.ORD)
                .IsUnicode(false);

            modelBuilder.Entity<MODULEACTION>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<MODULEACTION>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.MNUCTG)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MODULES>()
                .Property(e => e.ADDED)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.MRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.MRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MR>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.MRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<MRDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPDOCQUERY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MRPDOCQUERY>()
                .Property(e => e.QUERYMODULE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPDOCQUERY>()
                .Property(e => e.EXPORTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.DOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.ORDERQTY)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.RECVQTY)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.INTRANSITQTY)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MRPINT>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.MPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.WPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.MPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.SCPRATE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPMIPLANB>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.DOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.REFITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.ORDERQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.ISSUEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.OUTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MRPOUT>()
                .Property(e => e.PROLINENAME)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.ORDERTYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.ORIGIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPRESULT>()
                .Property(e => e.STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.INSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.INTRANSIT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.OUTSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.REQUESTS)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPRLT>()
                .Property(e => e.AVAILABLEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.ITEMNUM1)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.ITEMNUM2)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.EXECUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCB>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCB>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCC>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCC>()
                .Property(e => e.EXECUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.ITEMNUM1)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.ITEMNUM2)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.FCTABS)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME>()
                .Property(e => e.SORTBY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME1>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME1>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.INITIAL)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.INSTOCK)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.OUTSTOCK)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.FINAL)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME2>()
                .Property(e => e.REQUESTS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.MRPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.QUANTITY)
                .HasPrecision(19, 6);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.BASEDOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.BASELOT)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.STOCKTYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.PARENTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPSCHEME3>()
                .Property(e => e.ORDERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.WPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRPWOPLAN>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MRTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MRTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<MYJOB>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<MYJOB>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.CURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.CURRNAME)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.CHKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.CHK100NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.FRGNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .Property(e => e.F100NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OCURRN>()
                .HasMany(e => e.OCURTE)
                .WithRequired(e => e.OCURRN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OCURTE>()
                .Property(e => e.CURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<OCURTE>()
                .Property(e => e.RATE)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.OGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OGRNEN>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<OPRJCT>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<OPRJCT>()
                .Property(e => e.PRJNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLEVEL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLEVEL>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLEVEL>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLEVEL>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.OPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPA>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.OPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHAPD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.ORNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHARA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.ORNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHARD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.OENUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OTHEND>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.OENUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OTHENT>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.OGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.YOURREF)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OTHGRN>()
                .Property(e => e.DOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.RID)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.FORMULA)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.NumberFormatLocal)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.FontName)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.FontFontStyle)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.ColumnWidth)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OWCRPT>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.RID)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.FORMULA)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.NumberFormatLocal)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.FontName)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.FontFontStyle)
                .IsUnicode(false);

            modelBuilder.Entity<OWCRTT>()
                .Property(e => e.ColumnWidth)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PAYMETHOD>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMETHOD>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMETHOD>()
                .HasMany(e => e.PO)
                .WithRequired(e => e.PAYMETHOD1)
                .HasForeignKey(e => e.PAYMETHOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAYMETHOD>()
                .HasMany(e => e.SO)
                .WithRequired(e => e.PAYMETHOD1)
                .HasForeignKey(e => e.PAYMETHOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAYTERM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PAYTERM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<PAYTERM>()
                .Property(e => e.DISCOUNT)
                .HasPrecision(6, 4);

            modelBuilder.Entity<PAYTERM>()
                .HasMany(e => e.PO)
                .WithRequired(e => e.PAYTERM1)
                .HasForeignKey(e => e.PAYTERM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<PO>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PO>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.EXTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.EXTEXPENSE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PODTL>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<POTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<POTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<PPCAPA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PPCAPA>()
                .Property(e => e.WRKPROCID)
                .IsUnicode(false);

            modelBuilder.Entity<PPCAPA>()
                .Property(e => e.CAPACITY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PR>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.PROPOSER)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.PRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.PURREP)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.EXECDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PR>()
                .Property(e => e.TOTALQTY)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.OPENQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.OPENAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.FGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.FGQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.FGAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.ENDWIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.ENDWIPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.STDWRK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.STDWRKRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.STDWRK2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.STDWRK2RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WORKHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WORKHOUR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALWRKHR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALWRKHR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALLABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALFACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALFUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.LABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.FACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.FUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.MAINMATCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.BKFHCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALSTDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALSTDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALSTDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.TOTALSTDCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.STDUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.ADJUSTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WOTYPENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTA>()
                .Property(e => e.PROLINENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.PARTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.OPENWIP)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.OPENUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.OPENAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.PERIODIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FG1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FG2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FG3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FG4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FGUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.FGAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.ENDWIP)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.ENDWIPUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.ENDWIPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.TOTALFG1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.TOTALFG2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.TOTALFG3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.TOTALFG4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.TOTALFGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTB>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTC>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTC>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTC>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTC>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDWRK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDWRKRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDWRK2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDWRK2RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.WORKHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.WORKHOUR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.LABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.FACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.FUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALWRKHR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALWRKHR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALLABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALFACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALFUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDMATCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALSTDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALSTDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALSTDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.TOTALSTDCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.STDUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTD>()
                .Property(e => e.PROLINENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.PARTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.MITYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.REFPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.REFWONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDCTE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN2>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN3>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN4>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN5>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN6>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDIN7>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.NONETAXUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.NONETAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINB>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINV>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.WOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.SOUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.SOAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.SOTAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.NONETAXSOUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.NONETAXSOAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.REWONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.RESONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOTB>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.MQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.LYAVGUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YPUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.MACTUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YACTAVGUCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.MLTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.MYPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.MACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YLACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YYPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDRTA>()
                .Property(e => e.YYACTAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.WIPAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.SIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDST2>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.WIPAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.SIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDSTM>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.ORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.POQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PRDTL>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.PREGSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.SNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PREGSA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.PREGSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PREGSB>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.PRLSCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.PRLSCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.SYSQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.SCQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRLSCB>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.PARTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.OPENWIP)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.OPENUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.OPENAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.PERIODIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FG1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FG2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FG3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FG4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FGUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.FGAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.ENDWIP)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.ENDWIPUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.ENDWIPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.TOTALFG1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.TOTALFG2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.TOTALFG3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.TOTALFG4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.TOTALFGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCST>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.OPENQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.OPENAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.FGQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.FGQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.FGAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.ENDWIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.ENDWIPAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.STDWRK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.STDWRKRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.STDWRK2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.STDWRK2RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WORKHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WORKHOUR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALWRKHR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALWRKHR2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALLABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALFACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALFUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.LABORCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.FACOVRHAD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.FUELCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.MAINMATCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.BKFHCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.BKFHLOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALSTDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALSTDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALSTDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.TOTALSTDCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.STDUPRICE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.ADJUSTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WOTYPENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTA>()
                .Property(e => e.PROLINENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTB>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROCTB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROCTB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.PROINNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.TEAM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.DEVICE)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROINA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.PROINNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PROINB>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.PISNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAP>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.PISNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.SCPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.REPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.SCRAPREASON)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PROITEMSCRAPDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROLINE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PROLINE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<PROLINE>()
                .Property(e => e.PROLINEWH)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.PRORECNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.LABORHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.STARTHOUR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.STARTMINUTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.PREVWORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORD>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.PRORECNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.TEAM)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.DEVICE)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.PERDAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.HR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.MU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 9);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.PASSQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRORECORDDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.WRKPROCID)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.CREATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<PROSCH>()
                .Property(e => e.UPDATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.PRSYSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.SYSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.CUSVEN)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.PRSYSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.QTY1)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.QTY2)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.UPRICE1)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.UPRICE2)
                .HasPrecision(28, 12);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PRSYSB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.PURNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PUR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PUR>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PUR>()
                .Property(e => e.GRNACC)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<PUR>()
                .Property(e => e.REFPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.PURAPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PURAPA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.PURAPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.REJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURAPB>()
                .Property(e => e.ACTUALREJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.PURNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.POLOT)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.REJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<PURDTL>()
                .Property(e => e.PURAPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.PINUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIEN>()
                .Property(e => e.BASEAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.PINUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.BASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.REFDOC)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.REFLOT)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURIND>()
                .Property(e => e.REFINFO)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.PINUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 6);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.AMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.BASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.APPROVEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.SELECTEDBASEAMT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.RECINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURINV>()
                .Property(e => e.TAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.PRTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.EXREJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.REJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.REJECTEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.DRN)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.INVACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.REPLENISHQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PURRET>()
                .Property(e => e.PURAPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.STARTHOUR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.STARTMINUTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.ENDHOUR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PWKGRP>()
                .Property(e => e.ENDMINUTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.QCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.INSPECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QC>()
                .Property(e => e.CHECKQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QC>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QC>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QC>()
                .Property(e => e.DEFECTHANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.HANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.QCTEAM)
                .IsUnicode(false);

            modelBuilder.Entity<QC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.QCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.QCMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.QCITEM)
                .IsUnicode(false);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.QCUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.LOWERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.UPPERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.TARGETQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.PASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.SAMPLEPASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<QCDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.ANALYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.INSPBASIS)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.QCMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.INSPTOOL)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.SAMPSTD)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.DEFECTGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<QCITEM>()
                .Property(e => e.QCSCHMID)
                .IsUnicode(false);

            modelBuilder.Entity<QCMETHOD>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<QCMETHOD>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<QCSCHM>()
                .Property(e => e.QCSCHMID)
                .IsUnicode(false);

            modelBuilder.Entity<QCSCHM>()
                .Property(e => e.QCSCHMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<QCSCHM>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<QCSCHM>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<QCTEAM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<QCTEAM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<QCWORKPROC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<QCWORKPROC>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.Entity)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.Property)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.DefaultValue)
                .IsUnicode(false);

            modelBuilder.Entity<QUERYA>()
                .Property(e => e.Option)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.QTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.QUTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATION>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.QTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 0);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUOTATIONDTL>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<QUTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<QUTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<QUTYPE>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<QUTYPE>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<RANKING>()
                .Property(e => e.RANKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKING>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKING>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKING>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<RANKING>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RANKINGDTL>()
                .Property(e => e.RANKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKINGDTL>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKINGDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<RANKINGDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RANKSTD>()
                .Property(e => e.RANKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTD>()
                .Property(e => e.RANKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTD>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.RANKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.RANKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.RANGE1)
                .HasPrecision(9, 4);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.RANGE2)
                .HasPrecision(9, 4);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.RANGEUOM)
                .IsUnicode(false);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS1X)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS1Y)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS2X)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS2Y)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS3X)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS3Y)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS4X)
                .HasPrecision(9, 3);

            modelBuilder.Entity<RANKSTDDTL>()
                .Property(e => e.POS4Y)
                .HasPrecision(9, 3);

            modelBuilder.Entity<REGHOR>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<REGHOR>()
                .Property(e => e.DAILYHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.ORISEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKING>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKINGDTL>()
                .Property(e => e.ORISEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKINGDTL>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKINGDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<REPACKINGDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.RPTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.RPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEACTION>()
                .Property(e => e.UID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ROLEACTION>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.RPINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.EXPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.RPINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RPINVB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<RPTEXCEL>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.SINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.BASEAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.APPROVEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.RECINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.SSTATNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICE>()
                .Property(e => e.TAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.SINVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.BASEAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALESINVOICEDTL>()
                .Property(e => e.DOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.SUPERVISOR)
                .IsUnicode(false);

            modelBuilder.Entity<SALESPERSON>()
                .Property(e => e.DESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<SALESREGION>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALESREGION>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SALESREGION>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<SALESREGION>()
                .HasMany(e => e.SO)
                .WithRequired(e => e.SALESREGION1)
                .HasForeignKey(e => e.SALESREGION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.SFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRD>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.SFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALFRT>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.SALRPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.CUSREFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.EXPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPA>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.SALRPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SALRPB>()
                .Property(e => e.UPDATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTD>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTD>()
                .Property(e => e.SAMPLEMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTD>()
                .Property(e => e.QCLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTD>()
                .Property(e => e.YGD)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTD>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.LOTSIZE)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.SQMPQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.FORMULA)
                .IsUnicode(false);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.AQQTY1)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.REQTY1)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.ACQTY2)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SAMPSTDDTL>()
                .Property(e => e.REQTY2)
                .HasPrecision(28, 10);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.MIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNQTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNQTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.MATCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.PROCESSCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.TOTALCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<SCCSTB>()
                .Property(e => e.ADJUSTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.LASTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.MIPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNQTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTC>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.FGITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.LASTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.LASTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.MIAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNQTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNQTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNQTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNQTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.GRNAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.MATCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.PROCESSCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.TOTALCOST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<SCCSTD>()
                .Property(e => e.ADJUSTAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.SWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWD>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.SWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.SWTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEMIWP>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SETPRN>()
                .Property(e => e.RPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SETPRN>()
                .Property(e => e.PRINTERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SETPRN>()
                .Property(e => e.PAPERSIZE)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.SNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTE>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.SNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.SHIPRANK)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SHIPPINGNOTEDTL>()
                .Property(e => e.PREPAREDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<SINV>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<SINV>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINV>()
                .Property(e => e.EXPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINV>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.CUSSHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.PSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.STYLETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.SOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDATA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.CUSTOMPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.PSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.SELECTEDUID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.SOLOT)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL2>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.SOLOT)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SINVDTL3>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<SO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<SO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SOLDTO)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SOINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SO>()
                .Property(e => e.QTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.ORDERLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOACYA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOACYA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOACYB>()
                .Property(e => e.REPLENISHQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.LABELNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SODTL>()
                .Property(e => e.REPLENISHQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.CONTENTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.FILEPATH)
                .IsUnicode(false);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SOFILE>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.VIEWJSON)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPROREQUIRE>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVA>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.MIN)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.MAX)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.AVG)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.X)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.Y)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.Z)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVC>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVD>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVD>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOPRVD>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOREVW>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SOREVW>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOREVW>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOREVW>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SOTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SOTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.SRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.CUSREF)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SR>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SR>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<SR>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.SRAPPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.REFUNDREASON)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.SRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPA>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.SRAPPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.REJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SRAPPB>()
                .Property(e => e.REPLENISHQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRCTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SRCTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.SRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.CUSSHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.PSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.STYLETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SRDATA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.SRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.REJECT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.REJECTEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.PSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL>()
                .Property(e => e.REPLENISHQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.SRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.SOLOT)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SRDTL2>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.STNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.OPERATOR)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.CONFIRMBY)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.STNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.LOCIDIN)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<STDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDWRK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDWRKRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDWRK2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDWRK2RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDLABORCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDFACOVRHAD)
                .HasPrecision(28, 12);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDFUELCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<STDWKF>()
                .Property(e => e.STDMATCOST)
                .HasPrecision(28, 12);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.SANUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUST>()
                .Property(e => e.SATYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.SANUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.CURRQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.ADJQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKADJUSTDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.SCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.SCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNT>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.SCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.SYSQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.SCQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<STOCKCOUNTDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.SGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.YOURREF)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRN>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.SGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBGRNDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.SSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.SSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSOD>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<SYLOCK>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYLOCK>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.PARID)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.PARGROUP)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.PARTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARAMETER>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.PARID)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.VALUEID)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.VALUE)
                .HasPrecision(19, 9);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<SYSPARVALUE>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<TRADETERM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TRADETERM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.SCHEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.NONESCHEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<UNSCWA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<UNSCWB>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWB>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<UNSCWB>()
                .Property(e => e.WRKPROCID)
                .IsUnicode(false);

            modelBuilder.Entity<UOM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<UOM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAA>()
                .Property(e => e.TYPENAME)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAB>()
                .Property(e => e.RPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAB>()
                .Property(e => e.DICTID)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAC>()
                .Property(e => e.LEFTSYMBOL)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAC>()
                .Property(e => e.FIELDEXP)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAC>()
                .Property(e => e.DEFAULTVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAC>()
                .Property(e => e.EXPCON)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAC>()
                .Property(e => e.RIGHTSYMBOL)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAE>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<URPTAE>()
                .Property(e => e.LASTVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<USERLOG>()
                .Property(e => e.UID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERLOG>()
                .Property(e => e.IP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERLOG>()
                .Property(e => e.LOGDATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERLOG>()
                .Property(e => e.LOGTIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERLOG>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<USEROP>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<USEROP>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<USEROP>()
                .Property(e => e.OPACTION)
                .IsUnicode(false);

            modelBuilder.Entity<USERROLES>()
                .Property(e => e.UID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERROLES>()
                .Property(e => e.ROLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.PWD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.DEPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<USRPRF>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<USRPRF>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<USRPRF>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<VBSTYP>()
                .Property(e => e.VTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VBSTYP>()
                .Property(e => e.VTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VBSTYP>()
                .Property(e => e.DOCPATH)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.VENTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SALESCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SALESMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SALESTEL)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SALESFAX)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SALESADDR)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ACCCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ACCMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ACCTEL)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ACCFAX)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ACCADDR)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.TAXRATE)
                .HasPrecision(10, 5);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.TMPAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PURACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.APACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.OPACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.BANKACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.TMTAXACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.RANKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SCACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.VENNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.VENUM)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.VENNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.VENTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SALESCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SALESMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SALESTEL)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SALESFAX)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SALESADDR)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ACCCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ACCMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ACCTEL)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ACCFAX)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ACCADDR)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(10, 5);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.TMPAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.PURACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.PAYACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.APACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.OPACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.BANKACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.TMTAXACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.RANKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.SCACC)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENEVA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<VENITEMS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<VENTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<VENTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<VENTYPE>()
                .HasMany(e => e.VENDOR)
                .WithOptional(e => e.VENTYPE1)
                .HasForeignKey(e => e.VENTYPE);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.VID)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.VTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.VREFINFO)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.VBASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.VBASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.PRJCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.PAYEE)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.PAYEETYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<VOUCHR>()
                .Property(e => e.APPROVEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.VID)
                .IsUnicode(false);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.ACCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.LINEMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.ORIAMT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.RATE)
                .HasPrecision(19, 6);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.CURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.DEBIT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<VOUENY>()
                .Property(e => e.CREDIT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.BIN)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WAFER)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.DICEHEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.LOPCOV)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFAID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDAID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WAVELENGTHSIGMA)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVAID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFBID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVBID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDBID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFCID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVCID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDCID)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS)
                .IsUnicode(false);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS1X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS1Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS2X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS2Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS3X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS3Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS4X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAFERDATA>()
                .Property(e => e.POS4Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<WHPLNE>()
                .Property(e => e.WAREHOUSE)
                .IsUnicode(false);

            modelBuilder.Entity<WHPLNE>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<WHPLNE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WHQRYA>()
                .Property(e => e.WAREHOUSE)
                .IsUnicode(false);

            modelBuilder.Entity<WHQRYA>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<WHQRYA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.WIPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WIP>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WIPDTL2>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<WIPTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WIPTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WIPTYPE>()
                .HasMany(e => e.WIP)
                .WithOptional(e => e.WIPTYPE1)
                .HasForeignKey(e => e.WIPTYPE);

            modelBuilder.Entity<WMSTER>()
                .Property(e => e.WAREHOUSE)
                .IsUnicode(false);

            modelBuilder.Entity<WMSTER>()
                .Property(e => e.MASTERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMSTER>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WO>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.PRIMATDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.FIRSTWORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.SCHEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WO>()
                .Property(e => e.SOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WO>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.OLDWOREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.NEWWOREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.CHANGEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WOCREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WOCHANGE>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.WMINUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.WMINUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.MIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.ISSUEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.EXISSUEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.DOSAGE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.SCPRATE)
                .HasPrecision(28, 12);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.FREJECTEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.CREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WOMATERIALB>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WONLNE>()
                .Property(e => e.UID)
                .IsUnicode(false);

            modelBuilder.Entity<WONLNE>()
                .Property(e => e.MID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROC>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WOTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WOTYPE>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WOTYPE>()
                .HasMany(e => e.WO)
                .WithRequired(e => e.WOTYPE1)
                .HasForeignKey(e => e.WOTYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.ANCESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.ADDONS)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMA>()
                .Property(e => e.UPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.WORKPROCEDURE)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.QTY)
                .HasPrecision(28, 12);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.SCPRATE)
                .HasPrecision(10, 7);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.MASTERITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.EXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.EXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<WPBOMB>()
                .Property(e => e.REPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WPCAPA>()
                .Property(e => e.PROLINEID)
                .IsUnicode(false);

            modelBuilder.Entity<WPCAPA>()
                .Property(e => e.WORKPROCID)
                .IsUnicode(false);

            modelBuilder.Entity<WPCAPA>()
                .Property(e => e.TOTALHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WRKPRC>()
                .Property(e => e.WRKPROCID)
                .IsUnicode(false);

            modelBuilder.Entity<WRKPRC>()
                .Property(e => e.WRKPROCNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WRKPRC>()
                .Property(e => e.LOADRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<WRKPRC>()
                .Property(e => e.FIXEDHOUR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOTA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BKFOUT>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.WIPUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.WIPAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.SIUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.WIPUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.WIPAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.SIUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.WIPUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.WIPAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.SIUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<CSTCPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CSTPAM>()
                .Property(e => e.MATERIALITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<CSTPAM>()
                .Property(e => e.PRODUCTITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<CSTPAM>()
                .Property(e => e.FIXEDASSETSITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.NONETAXUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.NONETAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.SCITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.SCUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.VNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.AQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.WFSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<FXDINA>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.WOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<FXDOUT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.NONETAXUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.NONETAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.SCITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.SCUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.VNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.AQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.WFSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<MATINA>()
                .Property(e => e.SCRAPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.WOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MATOUT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MPARAM>()
                .Property(e => e.DEFAULTEXECDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<MPARAM>()
                .Property(e => e.DEFAULTPOPURREP)
                .IsUnicode(false);

            modelBuilder.Entity<MPARAM>()
                .Property(e => e.DEFAULTSCPURREP)
                .IsUnicode(false);

            modelBuilder.Entity<OPARAM>()
                .Property(e => e.POCOMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<OPARAM>()
                .Property(e => e.SCCOMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<OPARAM>()
                .Property(e => e.SCGRNOVERACTRATE)
                .HasPrecision(6, 3);

            modelBuilder.Entity<OPARAM>()
                .Property(e => e.OVERMIPLANRATE)
                .HasPrecision(9, 3);

            modelBuilder.Entity<PPARAM>()
                .Property(e => e.OVRATE)
                .HasPrecision(6, 3);

            modelBuilder.Entity<PPARAM>()
                .Property(e => e.WIPOVERIN)
                .HasPrecision(6, 3);

            modelBuilder.Entity<PPARAM>()
                .Property(e => e.OVERMIPLANRATE)
                .HasPrecision(6, 3);

            modelBuilder.Entity<PPARAM>()
                .Property(e => e.WIPOVERACTRATE)
                .HasPrecision(6, 3);

            modelBuilder.Entity<PPARAM>()
                .Property(e => e.PROFLOWCONTROLRATIO)
                .HasPrecision(10, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.NONETAXUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.NONETAXAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDINA>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.WOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.QTY1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.QTY2)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.QTY3)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.QTY4)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.SOUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.SOAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.SOTAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.NONETAXSOAMOUNT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.REWONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.RESONUM)
                .IsUnicode(false);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.NONETAXSOUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<PRDOUT>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<sysarticles>()
                .Property(e => e.schema_option)
                .IsFixedLength();

            modelBuilder.Entity<syspublications>()
                .Property(e => e.snapshot_jobid)
                .IsFixedLength();

            modelBuilder.Entity<syspublications>()
                .Property(e => e.min_autonosync_lsn)
                .IsFixedLength();

            modelBuilder.Entity<sysschemaarticles>()
                .Property(e => e.schema_option)
                .IsFixedLength();

            modelBuilder.Entity<syssubscriptions>()
                .Property(e => e.distribution_jobid)
                .IsFixedLength();

            modelBuilder.Entity<syssubscriptions>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<systranschemas>()
                .Property(e => e.startlsn)
                .IsFixedLength();

            modelBuilder.Entity<systranschemas>()
                .Property(e => e.endlsn)
                .IsFixedLength();

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.AVLQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<AVLSALESREJECT>()
                .Property(e => e.REJEDQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<LACC>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LACC>()
                .Property(e => e.PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<LACC>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LACC>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<LACC>()
                .Property(e => e.DR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<LACC>()
                .Property(e => e.CR)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.EXRATE)
                .HasPrecision(38, 19);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.UPRICE)
                .HasPrecision(38, 6);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.POQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.RECQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.OUTQTY)
                .HasPrecision(21, 5);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.PROPOSER)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.POQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.OUTQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.EXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.EXQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OUTSTANDINGPR>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.SOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.OUTQTY)
                .HasPrecision(21, 5);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGSO>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.OUTQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.INQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<OUTSTANDINGWO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.ATTRIBTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.INVACC)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.OVERQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.OVERRATE)
                .HasPrecision(10, 5);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.PREFIX)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.MINSCPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<syncobj_0x3737364133353237>()
                .Property(e => e.MAXSCPRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<syncobj_0x4436464438373633>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x4436464438373633>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<syncobj_0x4436464438373633>()
                .Property(e => e.ATTRIB)
                .IsUnicode(false);

            modelBuilder.Entity<sysextendedarticlesview>()
                .Property(e => e.schema_option)
                .IsFixedLength();

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.POLOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.UPRICE)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ACCGRN>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.YOURREF)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.GTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.GRNACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.CHECKEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.POLOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.BUYERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_GRNHistory>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.CLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DTLAMOUNT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DTLCREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.EXTEXPENSE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.EXTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.POTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.BUYERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.UNGRNQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPO>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PROPOSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PURREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.EXECDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.TOTALQTY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.CLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLCLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLPOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLCREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DTLUPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.UNPOQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingPR>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SOLDTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SOINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.QTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.LABELNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.UNSIQTY)
                .HasPrecision(21, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.CUSNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.PAYMETHODDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SALESPERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SALESREGIONDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingSO>()
                .Property(e => e.SOINVTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.PRIMATDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.FIRSTWORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SCHEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.WOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.PROLINEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_OutstandingWO>()
                .Property(e => e.UNWIPQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.CLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DTLAMOUNT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DTLCREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.EXTEXPENSE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.EXTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.POTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.BUYERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.UNGRNQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_PO>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.CLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DTLAMOUNT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DTLCREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.EXTEXPENSE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.EXTUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.GRNQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.POTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.BUYERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.UNGRNQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_POHistory>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PROPOSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PURREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.EXECDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.TOTALQTY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.CLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLCLOSEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLPOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SUITENAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SUITENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SUITEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLCREATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DTLUPDATEDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.UNPOQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_PRHistory>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.EXPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DTLAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DTLCUSPONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CUSTOMPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.INVNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.PSNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SELECTEDUID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DTLSONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.CREATEDUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.INVTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.SALESREPDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.PAYMETHODDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SiHistory>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SOLDTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SOINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.TOTALQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.QTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ORDERLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.LABELNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.UNSIQTY)
                .HasPrecision(21, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.CUSNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.PAYMETHODDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SALESPERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SALESREGIONDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_SOHistory>()
                .Property(e => e.SOINVTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WIPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.COMPLETEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.DOCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.CREATEDUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.PROLINEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WipHistory>()
                .Property(e => e.LABELDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.PRIMATDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.FIRSTWORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SCHEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.WOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.PROLINEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WO>()
                .Property(e => e.UNWIPQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WIPQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.PRIMATDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WOTYPE2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SCHEMENUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.FIRSTWORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SCHEDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SOITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.WOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.PROLINEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_REPORT_WOHistory>()
                .Property(e => e.UNWIPQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SOLDTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ISPRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.OBJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SOINVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.TOTALAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ACCOUNTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WFSTATUSDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CTMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CTMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.FLUXMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.FLUXMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.FUTUREYIELD)
                .HasPrecision(5, 2);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.LABELNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.REJECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.DTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SIQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.UNSIQTY)
                .HasPrecision(21, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMSUPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CREATEDBYDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.CUSNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.PAYMETHODDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SALESPERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SALESREGIONDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_API_RESORT_SO>()
                .Property(e => e.SOINVTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_COMPANY>()
                .Property(e => e.COMPID)
                .IsUnicode(false);

            modelBuilder.Entity<V_COMPANY>()
                .Property(e => e.COMPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFBID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVBID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDBID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDBMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDBMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.VFCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.IVCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDCMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.WDCMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS1X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS1Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS2X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS2Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS3X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS3Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS4X)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.POS4Y)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.ANGLE)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_GRADEINVENTORY>()
                .Property(e => e.INVREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORY>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMDESCRENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SPECCHN)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SPECENG)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.DRAWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ECNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMSUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SAFETYSTOCK)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.COST)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SRCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.MAXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.MINORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.FIXORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ECONLOTSIZE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.REORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.BATCHPRINC)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ORDPOLICY)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.ABC)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.YIELD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.INSPECGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.INSPECDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.INSPECLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.SAMPLESSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.AQL)
                .IsUnicode(false);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.WIDTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.HEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.LENGTH)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_INVENTORYITEMS>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.IQCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.QCMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.QCITEM)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.QCUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.LOWERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.UPPERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.TARGETQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.PASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.SAMPLEPASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.ANALYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.INSPBASIS)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.QCITEMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.INSPTOOL)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.SAMPSTD)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.DEFECTGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<V_IQCDTLITEM>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.MITYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.MINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.PART)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.PARTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.ISSQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_MIDTL>()
                .Property(e => e.MITYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.NAME2)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PAYEE>()
                .Property(e => e.REGION)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.POTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.VENITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PAYMETHODDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.BUYERDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.EXQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.PODTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.EXGRNQTY)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_PO_HISTORY>()
                .Property(e => e.EXREJECTQTY)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.PRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.PROPOSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.ORDQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.PURPOSE)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.PRDTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_PR_HISTORY>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.QCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.QCMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.QCITEM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.QCUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.LOWERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.UPPERLIMITQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.TARGETQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.PASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.SAMPLEPASSQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.INSPITEMID)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.INSPITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCDTLITEM>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.QCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.DOCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WORKPROC)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.PROLINE)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.INSPECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.CHECKQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.SAMPLEQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.DEFECTQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.DEFECTHANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.HANDLING)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WOSRC)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WOWORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WOREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.WORKPROCDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.QCTEAM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QCWO>()
                .Property(e => e.QCTEAMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.RANKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_QUERYSEQNUM>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.DTLAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.CURRDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.PAYMTDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.SOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINV_HISTORY>()
                .Property(e => e.WFSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SINVDTLAMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SINVDTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SOREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.SODETAILREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.SOLOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVDTL2>()
                .Property(e => e.SCANQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SHIPVIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.INSURE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.HANDLE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.DELIVERYCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.MISCHRG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.MISCHRGTIT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.MISCACC)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SOLOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.TRADETERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.PAYTERMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.CURRDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.PAYMTDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SOQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SINVDTL2QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SINVSCAN_HISTORY>()
                .Property(e => e.SINVDTLQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.REV)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.PAYTERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.PAYMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.TRADETERM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SHIPMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.VIA)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SOLDTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SALESREP)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SALESREGION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.PROJECT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.CUSITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.SOTYPEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SO_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.SANUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.CURRQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.ADJQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_STOCKADJUST>()
                .Property(e => e.COMPLETEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.SANUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.CURRQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.ADJQTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.MQTY)
                .HasPrecision(20, 5);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.UPDATEUSER)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_STOCKADJUSTDTL>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.QTY)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.UPRICE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.EXUOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.ORIAMT)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.BASEAMT)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.BASEBAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.BAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI>()
                .Property(e => e.REFINFO)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.BASETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.GRNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.RATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.BASEAMOUNT)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.BASEBAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.BAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.TAXRATE)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.INVTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETGRNFORPI_BAK>()
                .Property(e => e.VENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.SONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.SINUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.CUSID)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 7);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.BASEAMOUNT)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.TAXRATE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.RATE)
                .HasPrecision(9, 4);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.BAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.BASEBAL)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_UNSETSINVFORINVOICE>()
                .Property(e => e.CUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.REFNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.BIN)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WAFER)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.DICEHEIGHT)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.LOPCOV)
                .HasPrecision(18, 0);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VFAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VFAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VFAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VFAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VFASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WDAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WDAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WDAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WDAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WDASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.WAVELENGTHSIGMA)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.IVAID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.IVAMIN)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.IVAMAX)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.IVAAVG)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.IVASTD)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.ITEMGRP)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.ITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.VENID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WAFERINVENTORY>()
                .Property(e => e.PONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.WIPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.COMPLETEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.WIPDTLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.ITEMDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIP_HISTORY>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.CUSTOMLABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPDTL>()
                .Property(e => e.SCANQTY)
                .HasPrecision(38, 5);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.WIPNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.LOCID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.WONUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.COMPLETEDDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.ITEMNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(19, 5);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.SEQNUM)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.LABELID)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.WAREHOUSEDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<V_WIPSCAN_HISTORY>()
                .Property(e => e.WIPDTLQTY)
                .HasPrecision(19, 5);
        }
    }
}
