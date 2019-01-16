using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ItemsTest {

    [Test]
    public void ItemsTestSimplePasses() {
        // Use the Assert class to test conditions.

        //Act
        int random=1;
        var claseObtenerRandom = new GameObject().AddComponent<Item>();

        //Arrange
        claseObtenerRandom.ObtenerItem1(random);

        //Assert
        Assert.Greater(random, 0);

    }

  


}
