using System;
using System.Collections.Generic;
using NUnit.Framework;
using wcWinAnalog;

namespace Tests
{
    public class Tests
    {
        private wcCounter counter;
        private wcSettings _settings;
        
        [SetUp]
        public void Init()
        {
            counter = new wcCounter();
        }

        [Test]
        public void TestCounterRunClassic()
        {
            // Arrange
            long wcount = 6;
            long lcount = 2;
            long bcount = 34;
            
            // Act
            counter.Run("../../../../Tests/CounterTestClassic.txt");
            
            // Assert
            Assert.AreEqual(wcount, counter.wcount);
            Assert.AreEqual(lcount, counter.lcount);
            Assert.AreEqual(bcount, counter.bcount);
        }
        
        [Test]
        public void TestCounterRunNoInput()
        {
            // Arrange
            long wcount = 0;
            long lcount = 0;
            long bcount = 0;
            
            // Act
            counter.Run("../../../../Tests/CounterTestNoInput.txt");
            
            // Assert
            Assert.AreEqual(wcount, counter.wcount);
            Assert.AreEqual(lcount, counter.lcount);
            Assert.AreEqual(bcount, counter.bcount);
        }
        
        [Test]
        public void TestWcSettingsConstructorClassic()
        {
            // Act
            _settings = new wcSettings(new ParsingTarget(), new string[0]);

            // Assert
            Assert.IsEmpty(_settings.Flags);
            Assert.IsEmpty(_settings.Paths);
        }
        
        [Test]
        public void TestWcSettingsConstructorConstraint()
        {
            // Arrange
            ParsingTarget p = new ParsingTarget();
            p.fLines = true;
            p.fSymbols = true;
            p.fVolume = false;
            p.fWords = false;
            List<String> expectedFlags = new List<string>() {"m", "l"};
            string[] paths = new[] {"firstpath.txt", "secpath.txt"};
            
            //Act
            _settings = new wcSettings(p, paths);

            // Assert
            Assert.AreEqual(expectedFlags, _settings.Flags);
            Assert.AreEqual(paths, _settings.Paths);
        }
    }
}