using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2306.Naming A Company
//https://leetcode.com/problems/naming-a-company/

namespace NamingACompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1
            string[] ideas = { "coffee", "donuts", "time", "toffee" };

            //case2 
            string[] ideas2 = { "lack", "back" };

            //case3
            string[] ideas3 = { "aaa", "baa", "caa", "bbb", "cbb", "dbb" };

            //case4
            string[] ideas4 = { "ufrd", "evjfco", "ojdyeze", "pildaslfj", "bhush", "q", "fvbvd", "gmyfxe", "gsnzuzxd", "acaw", "kv", "ak", "itktagmfvc", "xafbvv", "iucpfg", "lhgxuanmk", "efljasin", "raldgyqnl", "pxcuapwd", "ymfiudiy", "qubqhventm", "htcpug", "bliwkz", "ibd", "wmackcg", "hjy", "frvviojvjl", "ialerc", "xyeppctwam", "fonjranlmq", "pdnwak", "gzjkoyxn", "imyvh", "wxpnt", "kzrdvqrcz", "qvwwvumv", "hvd", "heaqhxvn", "fpqb", "qmwebgbq", "x", "zm", "ad", "jmfqqphb", "fqdsfskyxa", "sxtzh", "s", "bosjkmv", "dxazbbk", "eguj", "cvu", "kr", "uvm", "godsfrbd", "sgj", "cvxrzer", "xbb", "hhcjyc", "p", "sg", "gppoq", "pzenuvvi", "rjhhk", "rdtci", "rp", "ttqacsxhd", "u", "braflwzfvn", "sabfkglhpp", "c", "tamy", "tchuflso", "w", "fgkwtwgkje", "reuvvjnga", "msrfj", "wgwfflbia", "eizpigf", "ezpkwrkfye", "jsd", "bvgvrzvb", "xeb", "jo", "hcsnhodewy", "t", "mebfwel", "grzcebhdm", "mhoyzwc", "zhfnbiodb", "dtwinj", "xph", "oagejrbw", "otlvqywmbj", "nloryp", "bwmwvyhdpk", "tn", "bzpu", "iicrfdnxzg", "zexi", "fcdt", "pwdq", "shthfmmz", "ytupezhd", "li", "ktqyl", "bpaqphrymg", "wq", "iwhagzdr", "dhykysqamu", "euniekj", "sm", "zf", "fnige", "xvnifcpnbm", "lwxm", "qcnbmwavsl", "gmkmlolfp", "merpmw", "ujsito", "vfmqygu", "weemh", "cmqfjc", "bsi", "baycguvsk", "beemh", "xsj", "kpm", "m", "wgvh", "qjpn", "ez", "pabfkglhpp", "jkwaleku", "gujo", "tgpc", "szkgafvpu", "bibwzumdzk", "ucloyz", "dkxazydf", "pjfwbx", "g", "lwwkaypq", "sbx", "sxr", "pwxco", "qmmlqtr", "qjwgtc", "abcunxeuz", "ehqolylwy", "hcjpmhew", "mqjervmdn", "vjnti", "mapr", "hkxru", "idfrdpkdzy", "klxpubomc", "bwwepvrbs", "wsmjuzvyrj", "oz", "ujmxsgkbqw", "bzamyz", "mpuo", "dpbzutc", "ye", "oswzwnqmxt", "ftvdj", "qa", "k", "pewwqberzj", "lkxngnzyhd", "twfbg", "krxqbcw", "rza", "uhnpmcp", "rdnmekawa", "bdtci", "hoccmond", "zovrgabd", "bfptusy", "lcguji", "jrznpo", "h", "jegid", "ccnbmwavsl", "xdxjiu", "czg", "pnksktifrw", "vszouj", "ec", "unoulota", "qbksmdhrfl", "nuemd", "skk", "pyjlymwj", "vetlrnzyp", "lxoj", "yeqgz", "j", "kwswyofcd", "fnadu", "spqq", "tlqgtdbz", "jgtpg", "d", "xjqrbsv", "lu", "qlz", "sguzxjg", "zknw", "kbvt", "iaju", "bm", "om", "hwniqofxmk", "msrqlfqbmz", "zlkljalfuk", "gyqiecft", "kgieoqqged", "uncajn", "zxdttqrcq", "cgien", "tlqjhd", "qh", "kvx", "tnfcip", "uiyaixpzoa", "hlms", "cys", "iez", "fuzrxfx", "tus", "uxhsl", "dyttyyur", "pb", "zwvfbibbzk", "jcv", "geeskwdv", "etrrctme", "cn", "sbkou", "qehxc", "kjmwyep", "nsewcy", "rjnye", "kvus", "joemuly", "vcgkqyacc", "aivr", "uzmvau", "orabkt", "lvmxwdjy", "hugw", "wutq", "imhvii", "ev", "yoda", "cqyligiq", "jhyl", "piqjyenws", "gbjnb", "int", "krouwpcvf", "uaygpmgrxm", "nqakxp", "zsy", "a", "qkobvf", "mld", "gj", "yfrxzp", "qetwhnkav", "junficb", "wpzolbyomp", "ndvafzxgw", "kfetkof", "zeam", "dqyelgc", "hlqizp", "zztfegg", "dkf", "qjmbmwm", "mo", "necijfqgl", "ksus", "gfaqtwokn", "iefzg", "sier", "xbsxppxnof", "ervviojvjl", "uhsmgsfpc", "gyoriyhjv", "apsvhqfku", "zedpul", "dfijydxnbk", "vajpmtv", "xqwfjgkove", "iwxolneugu", "l", "kqixmaljie", "nceqhmky", "umjkdbp", "fauizhiz", "ilovtl", "ntmymf", "b", "blqyeozud", "luubvtaza", "kkqutkavb", "adu", "qlncjz", "nzg", "jypszs", "msevbx", "qifrc", "mbd", "khzmrppp", "phxtvpibnh", "hi", "wegtljkhz", "vygksg", "znnxas", "fxqqastbi", "upviltbs", "mrvtkfxqz", "hbyhawmdf", "sker", "diu", "sqckv", "wrdsfkz", "bhxv", "uqbqs", "riqz", "hw", "iyxjdoyjs", "sksgltkdgh", "pub", "sowbbdpm", "cpidjcktia", "fie", "kyytk", "njq", "ip", "kcwj", "uo", "rgniqun", "timrmt", "gdtgok", "vu", "iyuqgipd", "gczqfwpea", "lixkgpjyt", "weed", "rchhnojpyt", "ipqkvz", "rrjwkzb", "wjoprckvz", "fmlu", "yxsqs", "nuqmyiivf", "gbgizujoz", "bxxxb", "sptrhkof", "f", "uuh", "uyoftrd", "jfblfdro", "fwbh", "lnuvw", "nkhtvzc", "otlnjlmxng", "xrkievj", "qe", "vgur", "jpmchp", "dsmrhmzsav", "xuypdlqf", "ipm", "qdvwhaqirv", "gjdvsg", "ocuvuraln", "nwkpcjfzs", "gftlvkvtsy", "rmvvcpiy", "wfo", "jjdfgz", "dmckkg", "ouqcb", "n", "exp", "hzccsfisdg", "xwfxrked", "oaba", "eajeavpgk", "wmvvcpiy", "phuzhfet", "spvhcjcjkf", "zuaqjn", "mcdp", "ovbcho", "awndm", "nmhwviqsh", "vxicuxvo", "fzxwjrt", "qpzmdtbzm", "mnfcip", "hcqbf", "qfs", "ogyyhjn", "maoemq", "cbsyti", "wndk", "ykk", "dnbqgptwdi", "mdaxwnf", "mkdsh", "bdqcwlunm", "apntxmz", "zkpibygdg", "mknndceh", "kbcftqbvyl", "mlwn", "pkjlb", "ulqy", "lkf", "vdieyjkj", "bupa", "tjv", "opqbpmpt", "gr", "jmkrolrp", "clafjy", "ofxf", "ek", "tcpkl", "ozoijnd", "uybm", "hn", "zythamzz", "ayqdabeg", "nfkp", "seeed", "wpbbf", "fkyvotinr", "nsfhob", "bnsfqa", "bvlebiiljh", "hpycw", "atwyi", "buigtg", "nojhqg", "zeatqt", "nnfcip", "pteqfne", "byzivljxfx", "kngtchkh", "ublip", "bsbevyxreh", "aykodk", "ltwinj", "kvlebiiljh", "bbbeibja", "vbgjnz", "tjvy", "rvo", "ahnghgjx", "clkmga", "znwvzwi", "sdxmvq", "yjcz", "pdvlteoh", "fzqokaw", "iom", "pnjx", "mlsjpedb", "eufhzqyt", "cxasfr", "lp", "scnlouri", "cbpyzhmmpn", "stfmxjpyn", "ixazbbk", "lznzlkkvsr", "gwdiyzot", "mzt", "fz", "ge", "vvj", "uzge", "evvp", "iazduxrwqh", "fpnouyya", "sdrldphp", "r", "hfbsco", "eukeuowg", "jquhlraxje", "ksdvhnc", "cmj", "cgnqev", "soamuijlq", "xx", "mrikzjfdj", "spdgfkb", "ygsrjpglui", "uf", "qygxiduzt", "rbsrpcsuin", "iworwissw", "cnsbagxt", "khf", "bacwrqtmj", "krlo", "xdvnms", "wvh", "bnr", "orcakqbj", "ijhfqvoa", "waf", "vhimahp", "bspizjin", "nvbcho", "rcjts", "mf", "rzoijnd", "omwekniv", "ow", "fp", "ypqzcdkz", "ntaikqd", "wpycw", "hqkjmwm", "cezjxigi", "ifwzxq", "xkommk", "ygdeztnl", "dwin", "hfrgsyjmqj", "nvurxqhage", "ycjts", "fygjo", "ix", "ct", "fuhowzonh", "ziwfbeohxp", "zjjn", "csxemb", "nbrjxkgk", "evmp", "ah", "snxi", "wkjkoyeyn", "ynlvh", "kkumbufht", "rc", "gprtqz", "juro", "tdd", "tyko", "neyisbvnd", "bybmwsxwh", "silpcrif", "agozvuxr", "vgpk", "cgt", "huth", "oppmx", "kb", "nhbf", "qqbzg", "tingkixov", "zsygmj", "vmf", "rgj", "rkkfswqiay", "paqqtsdboi", "hauizhiz", "rpuophvhtg", "tbmwbkgmtc", "pmw", "crr", "ohd", "xrox", "cvf", "ocjje", "gjs", "y", "glqqjnye", "xmmwck", "nxldrwb", "cgubnevt", "yzllnsnuy", "kpoy", "wuuwlqvpvt", "hcl", "z", "kbhhg", "xdelalwwiy", "vbrf", "go", "qd", "uzrdvqrcz", "nj", "qhtmsbuvnl", "vrfpnpkx", "eaafhjvd", "ksocgyzw", "qmx", "ob", "pqyoep", "peizqg", "qb", "rmfk", "csq", "bmnlcmpb", "tycnzkkck", "sijexib", "fu", "npxyo", "jifdm", "bfbsco", "yhaneeeh", "grnrnsowv", "ahywep", "jhcdyajqzw", "hunl", "ozalifegd", "wvdtcrhbus", "rng", "pszouj", "wrxqg", "segzex", "xlpinmkoms", "myehfdqsf", "oamgb", "tp", "qkxay", "muq", "fhlrvjh", "xrq", "yhqolylwy", "fmjidpdq", "nwfp", "plmfzopu", "raq", "aspge", "cg", "wvkcppffli", "ngbft", "mvcx", "tcvvefngzh", "ysvchiviug", "gomvkt", "ekeiqqw", "ygjypjc", "bpciyeibml", "evtqvma", "hkuhjvjyv", "dn", "fyflcpja", "gftzucziet", "wwbxpdudxl", "zmuqndc", "ggoqeid", "nmfqmzrfv", "jqkdw", "kfccwvpsgj", "zzvjrgzt", "lbpr", "chxv", "i", "uuljtgt", "cupdgzqhm", "lg", "jmp", "dr", "tsbsekkmyw", "lzboy", "vuoujrxb", "rsdcjae", "qbdwbk", "tguwbae", "qttta", "nnnhejwho", "jxquldfmaw", "zhiaytjbk", "vouwn", "gxazbbk", "urhytjb", "dkqhvbocjx", "ajjfwoqje", "nmomedocu", "jlikoyj", "jmoo", "mse", "owhoatludb", "eetfffs", "zprofcb", "fgo", "zn", "sreveqqc", "qmlymw", "vswjyppqgc", "ljbcrytui", "bjppk", "wsvowp", "ocjui", "wmnsqnlb", "hts", "getgk", "pbhbgyci", "yxpufkhrp", "pzkpkbka", "zdz", "ykct", "xt", "uilolvbbnj", "o", "lggfvojs", "bpwzvywuzp", "dvpplsvy", "nmfamegpoj", "dgcqfpqkd", "wxoyfq", "seqas", "egljwyfy", "uzedntcz", "tazdpd", "ezytbwuab", "vhabhw", "sgpdl", "mptqovn", "nrimahca", "ubtfxqtg", "urt", "qlm", "ynakzoo", "wgvuipkblf", "iarjzugcd", "gs", "xnapihbkmm", "jfkomz", "xszsw", "xlc", "tultq", "xmt", "pwr", "ecqmkrw", "rtmnwbnd", "oczlg", "fwgvyyef", "puxqkvnwj", "vua", "usq", "ysgrk" };



            Console.WriteLine(DistinctNames2(ideas)); //6
            Console.WriteLine(DistinctNames2(ideas2)); //0
            Console.WriteLine(DistinctNames2(ideas3)); //2
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(DistinctNames2(ideas4)); //503418 //TimeLimitExceed
            watch.Stop();
            //distinct1 -> 4623ms simple one
            //distinct2.1 -> 4524 ms 
            //distinct2.2 -> 4448  ms grouping
            //distinct2.3 -> 2434  ms

            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
            Console.ReadKey();
        }
        string[] sthElse = { "coffee", "donuts", "time", "toffee" };


        //Second Algoritm 
        public static long DistinctNames2(string[] ideas)
        {
            var newNames = new List<string>();
            var newIdeas = ideas.GroupBy(x => x[0]).ToDictionary(g => g.Key, g => g.ToList());
            List<char> charGroups = new List<char>(); 
            foreach (var dictItem in newIdeas/*.Where(x=>!keies.Contains(x.Key))*/)
            {
                if (charGroups.Contains(dictItem.Key))
                    continue;

                charGroups.Add(dictItem.Key);
                foreach (var dictValueitem in dictItem.Value)
                {
                    //var removedDictList = newIdeas.Where(x => x.Key != dictItem.Key).SelectMany(x => x.Value).ToList();
                    var removedDictList = newIdeas.Where(x => !charGroups.Contains(x.Key)).SelectMany(x => x.Value).ToList();
                    foreach (var item in removedDictList)
                    {
                        var swapNames = SwapFirstLetter(dictValueitem, item);

                        //The idea must not include the swapping names.
                        var findNamesResult = ideas.Contains(swapNames[0]) || ideas.Contains(swapNames[1]);
                        //var findNamesResult = newIdeas.SelectMany(x=<).Contains(swapNames[0]) || ideas.Contains(swapNames[1]);

                        if (!findNamesResult)
                        {
                            newNames.Add(swapNames[0] + " " + swapNames[1]);
                            newNames.Add(swapNames[1] + " " + swapNames[0]);
                        }
                    }
                }
                  //newIdeas.Remove(dictItem.Key);
                  //newIdeas.Keys.
            }

            //foreach (var first in newIdeas)
            //{
            //    var key = first.Key;
            //    foreach (var second in first)
            //    {
            //        //if (first[0] == second[0])
            //        //    continue;

            //        //the item must not consider with itself
            //        if (first.CompareTo(second) == 0)
            //            continue;

            //        var swapNames = SwapFirstLetter(first, second);

            //        //The idea must not include the swapping names.
            //        var findNamesResult = ideas.Contains(swapNames[0]) || ideas.Contains(swapNames[1]);

            //        if (!findNamesResult)
            //            newNames.Add(swapNames[0] + " " + swapNames[1]);
            //    }
            //}

            //Distinct Num of Valid Names
            return newNames.Distinct().Count();
        }


        //First Algoritm - Pass All test Case But "Time Limit Exceeded" Error
        public static long DistinctNames1(string[] ideas)
        {
            var newNames = new List<string>();

            foreach (var first in ideas)
            {
                foreach (var second in ideas)
                {
                    //the item must not consider with itself
                    if (first.CompareTo(second) == 0)
                        continue;

                    var swapNames = SwapFirstLetter(first, second);

                    //The idea must not include the swapping names.
                    var findNamesResult = ideas.Contains(swapNames[0]) || ideas.Contains(swapNames[1]);

                    if (!findNamesResult)
                        newNames.Add(swapNames[0] + " " + swapNames[1]);
                }
            }

            //Distinct Num of Valid Names
            return newNames.Distinct().Count();
        }

        public static List<string> SwapFirstLetter(string firstWord, string secondWord)
        {
            return new List<string>()
            {
                secondWord[0] + firstWord.Remove(0, 1), //Swaped First Word
                firstWord[0] + secondWord.Remove(0, 1)  //Swaped Second Word
            };
        }
    }
}
