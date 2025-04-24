# ☎️ Old Phone Pad Simulator

This project simulates the behavior of old mobile phone keypads, where each number represents multiple letters. The user inputs sequences of digits directly through the console, using special characters like space (` `), asterisk (`*`), and hash (`#`) to control the message.

---

## 🧠 Description

Each key from 2 to 9 maps to a group of letters. To type a specific letter, you press the same key multiple times:

- `2` → A  
- `22` → B  
- `222` → C

A space (` `) is used to pause between letters that require the same key.  
An asterisk (`*`) works as a backspace (deletes the last typed character).  
The hash (`#`) signifies the end of the message and sends it.

---

## 🎮 Usage Examples

| Input                      | Output  |
|---------------------------|---------|
| `33#`                     | E       |
| `227*#`                   | B       |
| `4433555 555666#`         | HELLO   |
| `8 88777444666*664#`      | TEXTED  |
| `777733 6660 555 555666#` | SE JOEL |

---

## 🖥️ How to Run

1. Make sure you have .NET 6 or later installed.
2. Clone this repository or copy the `Program.cs` and `OldPhone.cs` files.
3. Open a terminal in the project directory.
4. Run the program:

```bash
dotnet run
