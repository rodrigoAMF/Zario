using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestZerarMoedas {

    [Test]
    public void TestZerarMoedasSimplePasses() {
        PlayerController playerController = new PlayerController();

        playerController.setNumeroMoedas(0);

        Assert.AreEqual(playerController.getNumeroMoedas(), 0);
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestZerarMoedasWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
