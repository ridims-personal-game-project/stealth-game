/*
* File name     : PlayerMovements.cs
* Developed on  : 23/03/2020
* Description   : Script for anything related with moving the player and 
*                 it's animation
* Developed by  : Ari Mahardika Ahmad Nafis
* Contact       : arimahardika.an@gmail.com
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    private SpriteRenderer mySpriteRenderer;
    bool isFacingRight = true;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        //Standard movement script
        float inputX = Input.GetAxisRaw("Horizontal");
        Debug.Log("X " + inputX);
        float inputY = Input.GetAxisRaw("Vertical");
        Debug.Log("Y " + inputY);
        movement = new Vector2(inputX, inputY);

        transform.Translate(movement * speed * Time.deltaTime);

        if(inputX == -1 && isFacingRight){
            mySpriteRenderer.flipX = true;
        }
        if(inputX == 1 && isFacingRight){
            mySpriteRenderer.flipX = false;
        }
    }
}
