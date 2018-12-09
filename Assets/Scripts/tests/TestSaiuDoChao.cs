using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestSaiuDoChao {

    [Test]
    public void TestSaiuDoChaoSimplePasses() {
        PlayerController playerController = new PlayerController();
        playerController.setEstaNoChao(false);

        Assert.False(playerController.isEstaNoChao());
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestSaiuDoChaoWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
