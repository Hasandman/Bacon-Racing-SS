using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PausaTest {

    [Test]
    public void PausaTestSimplePasses() {
        // Use the Assert class to test conditions.

        //Act
        bool pausa=true;
        var pausaTest = new GameObject().AddComponent<Pausa>();

        //Arrange
        pausaTest.Pause(pausa);

        //Assert
        Assert.IsTrue(pausa);


    }

   
}
