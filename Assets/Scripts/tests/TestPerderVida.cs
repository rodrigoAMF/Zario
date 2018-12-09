using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestPerderVida {
    [Test]
    public void TestPerderVidaSimplePasses() {
        PlayerController playerController = new PlayerController();

        int numeroVidas = playerController.getNumeroVidas();

        playerController.setNumeroVidas(playerController.getNumeroVidas() - 1);
        Assert.AreEqual(playerController.getNumeroVidas(), numeroVidas-1);
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestPerderVidaWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
