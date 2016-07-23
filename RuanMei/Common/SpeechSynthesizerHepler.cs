using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 语音播放类
    /// </summary>
    public class SpeechSynthesizerHepler
    {
        private static SpeechSynthesizerHepler speechSynthesizerHepler;
        private SpeechSynthesizer synth;
        private LogHelper log;
        private static Object lock_object = new Object();

        private SpeechSynthesizerHepler()
        {
            synth = new SpeechSynthesizer();
            log = LogHelper.Create();
        }

        public static SpeechSynthesizerHepler Create()
        {
            if (speechSynthesizerHepler == null)
            {
                lock (lock_object)
                {
                    if (speechSynthesizerHepler == null)
                    {
                        speechSynthesizerHepler = new SpeechSynthesizerHepler();
                    }
                }
            }
            return speechSynthesizerHepler;
        }

        /// <summary>
        /// 同步播放文本中类容
        /// </summary>
        /// <param name="path"></param>
        public void SpeakTxt(String path)
        {
            var iOHelper = IOHelper.Create();
#if DEBUG
            log.WriteLog("开始阅读{0}", path);
#endif
            foreach (var content in iOHelper.ReadText(path))
            {
                SpeakContent(content);
            }
#if DEBUG
            log.WriteLog("开始阅读完成");
#endif
        }

        /// <summary>
        /// 同步播放字符串中内容
        /// </summary>
        /// <param name="content"></param>
        public void SpeakContent(string content)
        {
#if DEBUG
            log.WriteLog("开始阅读:{0}", content);
#endif
            synth.Speak(content);
            //切换语言
            //synth.SelectVoice(synth.GetInstalledVoices()[synth.GetInstalledVoices().Count - 1].VoiceInfo.Name);
#if DEBUG
            log.WriteLog("开始阅读完成");
#endif
        }

        /// <summary>
        /// 异步播放字符串中内容
        /// </summary>
        /// <param name="content"></param>
        public void SperkCAsyncContent(String content)
        {
#if DEBUG
            log.WriteLog("开始阅读:{0}", content);
#endif
            synth.SpeakAsync(content);
#if DEBUG
            log.WriteLog("开始阅读完成");
#endif
        }
    }
}
