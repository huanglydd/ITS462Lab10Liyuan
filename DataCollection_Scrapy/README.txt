Project Title:
    medeffects/nih-project

Contributer:
    Liyuan Huang
    Shichao Feng
    Yongbing Tang
    
Getting Started:
    Data collection is actually a set of python code named "scrapy", we can use this set of code to crawl data from the twitter website. Running
"scrapy" need pre-configured environment. In the following parts will introduce the prerequisites and installation guide.
    "Scrapy" is built with python code, which means it can run on any platform that support python. Initially, it was created by Yongbing using 
Python 2.0 on MAC OS. Then Shichao update the code to Python 3.0 on MAC OS. Liyuan implement the Python 3.0 code to Windows OS, and solving the automatic run
issue and blocking issue. Check the comments in the code to see the differences.
    After get the code work, we manage to get all the tweets for total 1147 medicines. Tweets records are stored as json format and seperated by
medicine name. The collection consist of two iteration, first iteration is general collecting (Collect all the small and mid size meds). Second
iteration is huge meds and unfinish meds collecting (Collect large med and unfinished small mid meds). First iteration takes around 2-3 weeks (4 machines
collecting), the second iteration will take around 1 week (3 machines).

Prerequisites:
    Windows & Mac:
           1. Running environment configured.
           2. Free space more than 50 GBs.
           3. Stable internet connection, using cable if avaliable.
           
Installing:
    Windows:
           1. Download and install python 3.X (3.6 for mine, 32bit or 64bit).
           2. Download and install Anaconda3.
           3. Install scrapy using command: conda install -c conda-forge scrapy
           4. Download and configure necessary libraries: bs4, nltk, etc.
           5. Download stopwords: Go the cmd python terminal, run "import nltk" and "nltk.download()" and download all.
           6. If you choose to use pymongo to store data. Install "pymongo" lib.
           7. Update the reliable list and user agent file located in twitterscraper.
    Mac:
           1. Download and install python 3.X.
           2. Download and install Anaconda3.
           3. Install pip or pip3 tools. (or homebrew)
           4. nltk stopwords download.
           5. Install needed libs or packages.
           6. Update the reliable list and user agent file located in twitterscraper.
           
Running the tests:
    Windows & Mac:
           For small and mid meds collecting - using project named "Normal_Meds_Collect"
           Manually Run - Run Manual_Collect.py or Run "twitter crawl search" under "~\twitterscraper" directory
                    Manual_Collect.py: 1. GUI interface, type in medicine name in.
                                       2. You can show now query in search.py. You can update new med name to search.py. You can reset.
                                       3. Radio button is a function used to build query like ""prozac" until:2017-05-01".
                                       4. Click run button to do the collection.
                                       5. Once finished, find your data under "twitterscraper\tweet_file"
                    CMD run "twitter crawl search": 1. Change the query in search.py to your med name.
                                                    2. Change the Pipeline.py output address to where you want.
                                                    3. In CMD or Terminal correct directory, run "twitter crawl search".
                                                    4. Get result.
           Automatically Run - Run "Automatic_Collect.py"
                    1. Put medicines to file name as "new_selected_med_names_test".
                    2. CMD or Terminal correct directory, run "Automatic_Collect.py".
                    3. Wait for code running, this may take days or weeks. Keep conputer running.
                    4. Get the results.
                    
           For large medicine collecting - Using project named "Huge_Meds_Collect"
           Manually Run - Run Manual_Collect.py
                    Manual_Collect.py: 1. GUI interface, type in medicine name in.
                                       2. Update the search.py file.
                                       3. Run the code.
                                       4. Wait for week to let code finish. Code might not finished by itself, continuesly check the status.
                                       5. Get results.
                    Tips(Try run multiple huge meds at same time, this will save lots of time)
                    
  Structure:
           Folders:
                  1. 1-200_ShichaoMac, 201-400_LiyuanPC2, ...: Save examples for collected medicines.
                  2. Normal_Meds_Collect: Project to collect small and mid meds at 1st iteration.
                  3. Huge_Meds_Collect: Project to collect large meds at 2nd iteration.
                  4. Need Recollect: List of meds need recollect.
           Files:
                  1. Collection_Assignment.xlsx: Statistic Excel file.
                  2. Medicine_List.txt: Meds names and counts.
                  3. Meds_Completeness_Stat.py: Check compleness of 1st iteration collected data.
                  4. Meds_Stat.py: Do the statistic for the collected data.
                  5. new_selected_med_names: Store all medicines names.
                  6. new_selected_med_names_test: Store all the medicines for automatically run script.
       
Built With:
          1. Sublime Text 3.
          
Versioning:
          2016.3.10 Last updated by Yongbing Tang. (Python 2)
          2017.4.01 Modified by Shichao Feng (Python 3).
          2017.5.30 Modified by Liyuan Huang. (Auto, Block issue)
          
License:
          Instructor: Prof. Keyuan Jiang, Prof. R. Calix
          Purdue University Northwest
          
Acknowledgments:
          1) Code could be run on Linux.
          2) Make sure to sleep some time between each request.
          3) When met blocking issue, please check the design of timeline tool of twitter. Link: https://dev.twitter.com/rest/public/timelines
          4) Sometimes the search will return to top, stability could be inproved.
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
