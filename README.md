# Password Cracking :unlock:

## Topic :memo:

The project demonstrates cybersecurity issues by testing three different password-cracking algorithms used by hackers. Based on the efficiency of these three algorithms, it is possible to determine how secure a password is and what changes should be made to ensure the password is strong enough to withstand a cyberattack.

## Topic choice :thinking:

With the rapid development of technology, cybersecurity issues also arise, and users need to take them into consideration before revealing personal confidential data. Therefore, choosing a strong password is important. Of course, a password should be easy to remember, but the simpler it is, the more exposed the user becomes to a cyber attack. In order to understand these risks from a practical perspective, I have implemented three well-known password cracking algorithms: Brute Force Attack, Dictionary Attack, and Rainbow Attack. In this way, users can test their own passwords and find out how effective they are in protecting their data.

## Theoretical Aspects :brain:

The program is implemented in Visual Studio 2022, using Windows Forms App (.Net Framework), in the C# programming language. After a brief introduction, the user can enter their name and password, and then they can choose which algorithm will be used to test their password.

### 1\. Brute Force Attack: 

It is the simplest, but also the most inefficient, of the algorithms. As the name suggests, the algorithm uses the concept of brute force to generate all possible combinations of characters (letters, digits, symbols) in order to eventually guess the password entered by the user. The inefficiency of this algorithm arises from the multiple possibilities: both uppercase and lowercase letters, digits, and various symbols can be used, forming a total of 74 characters. In this program, I opted for a Backtracking algorithm that generates all possibilities and only displays the correct one. Due to its inefficiency, the algorithm requires too much time to display a password with more than 4 characters, so if the password is longer than that, it is not displayed.

### 2\. Dictioary Attack: 

It is more efficient than Brute Force, but not the most useful in reality. As the name suggests, the algorithm uses a list of words in English, a dictionary. The words from this list are compared with the password, and if they are not found, the password is constructed from multiple words (e.g., waterfall = water + fall). The execution time is much shorter than that of the previous algorithm, and this algorithm can find any password, regardless of its length or complexity. However, it is not as dangerous as it seems. If someone wanted to enter a password to access an account, they would need more than 3 attempts to guess it, which is usually not allowed. Therefore, this method is as useful as Brute Force.

 ### 3\. Rainbow Attack:
 
Although it may not seem as complex at first, this algorithm can become dangerous if used correctly. To bypass the restrictions of a login interface (which usually doesn’t allow more than a few password attempts), hackers prefer to access the saved data in the database. There, passwords are stored as hash values, and the process is irreversible. Therefore, the preferred method is to transform words, stored in a table called a Rainbow Table, into hash values, and then search for the hash value obtained from the database in the table. For the Rainbow Attack, I used the cryptographic indexing algorithm with SHA-256 hashing (Secure Hash Algorithm 256-bit), whose premise is the irreversibility and uniqueness of the hash. In this case, the algorithm does not work for all passwords, but in a real situation, Rainbow Attack can become dangerous.

As a result of running these algorithms, certain conclusions can be drawn about the password chosen by the user. The password should not be too short; it should have at least 8 characters, otherwise algorithms like Brute Force Attack will be able to crack the password too easily. The password should contain as many symbols and digits as possible to confuse the Dictionary Attack algorithm, and using uppercase letters helps create a complex password. It is recommended to use a password that does not contain common words to make it harder to discover using the Rainbow Attack algorithm. Additionally, using personal data in passwords can make the password easier to guess.

## App description :computer:

The program begins with a brief introduction where the user is required to enter their name and password.

<img src="https://github.com/user-attachments/assets/f28e5e49-58a4-44f2-b036-3ce16c2186ec" width="500" title="Figure1"/> <img src="https://github.com/user-attachments/assets/76cfa76b-4aac-48f6-9fd3-1371a672de9f" width="500" title="Figure2"/> 

After following all the steps, the user reaches the Menu, the main form, from where the three algorithms can be accessed. Each one represents a button that leads to the form from which the corresponding algorithm can be run. From each of these forms, the user can either exit the program (Quit) or return to the main form (Menu).

<img src="https://github.com/user-attachments/assets/02846fe2-5ea0-462f-a30a-73d0cfde4988" width="500" title="Figure3"/> <img src="https://github.com/user-attachments/assets/e7274cf3-bfff-480f-b11e-c8cd316462fe" width="500" title="Figure1"/> 

The Brute Force Attack (Figure4) displays the found password only if it is shorter than 5 characters and informs the user how many attempts were needed to discover the password.

<img src="https://github.com/user-attachments/assets/dd8b131e-2460-4085-a602-ccbc9330aeec" width="500" title="Figure5"/> <img src="https://github.com/user-attachments/assets/32bc4a8d-f04e-42b9-b5e2-c9e13182dbf4" width="500" title="Figure6"/>

The Dictionary Attack (Figure5) displays the found password in any case and reveals how many attempts were necessary to discover this password. The Rainbow Attack (Figure6) displays the found password only if it exists in the list of words transformed into hashes and also shows the hash value corresponding to the entered password.

<img src="https://github.com/user-attachments/assets/283b8470-9cf5-4500-9ef3-1a10571d9660" width="500" title="Figure7"/>

After all three algorithms have been tested, the user can find a new button, Bonus, on the Menu form. This button leads to a new form where the user is initially asked for permission to display the password exactly as it was entered from the keyboard. If accepted, the password is displayed and analyzed. Conclusions are shown, and the user can find out whether the entered password can be used in a real-life situation. If there are recommendations to improve the entered password, they will be displayed.

## Conclusions :bulb:

In conclusion, the main goal of the project is to help users improve their security system by observing how different algorithms react to the password. Additionally, the program attempts to explain, through practical examples, the importance of having a strong password, revealing how hackers use similar algorithms for cyber attacks.

## Bibliography :mag_right:

[<u>SHA-256
Algorithm</u>](https://support.google.com/google-ads/answer/9004655?hl=ro)

[<u>Password-cracking-techniques</u>](https://cybernews.com/best-password-managers/password-cracking-techniques/)

