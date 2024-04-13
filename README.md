# mono_v2_bug
After resource starting, runtime lack on Wait in Class1.Test:
![image](https://github.com/Gyzzmo/mono_v2_bug/assets/6975406/d2e20f89-cb28-42ef-8e95-22cec6cffbec)
Try with latest and recommanded client version, same result.
Same if you try to Request a Model object (Request(xxx)), the inside Wait block runtime too.
