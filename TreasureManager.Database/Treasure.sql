PGDMP     *                    u            Treasure    10.0    10.0                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false                       1262    16393    Treasure    DATABASE     �   CREATE DATABASE "Treasure" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Indonesian_Indonesia.1252' LC_CTYPE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "Treasure";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false                       0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    24613    Configuration    TABLE     L   CREATE TABLE "Configuration" (
    "Key" text NOT NULL,
    "Value" text
);
 #   DROP TABLE public."Configuration";
       public         postgres    false    3            �            1259    24661    Employee    TABLE     �   CREATE TABLE "Employee" (
    "UserId" text NOT NULL,
    "Name" text,
    "BirthPlace" text,
    "BirthDate" date,
    "Address" text,
    "Phone" text
);
    DROP TABLE public."Employee";
       public         postgres    false    3            �            1259    32839    Logins    TABLE     ]   CREATE TABLE "Logins" (
    "Username" text NOT NULL,
    pass text NOT NULL,
    id text
);
    DROP TABLE public."Logins";
       public         postgres    false    3            �            1259    16405    prop_id_seq    SEQUENCE     m   CREATE SEQUENCE prop_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.prop_id_seq;
       public       postgres    false    3            �            1259    16397    Property    TABLE     6  CREATE TABLE "Property" (
    "Id" integer DEFAULT nextval('prop_id_seq'::regclass) NOT NULL,
    "PropertyName" text,
    "Remarks" text,
    "Year" integer,
    "Value" numeric,
    "Description" text,
    "TransactionId" text,
    "ReferenceId" text,
    "Status" boolean DEFAULT true,
    "UserId" text
);
    DROP TABLE public."Property";
       public         postgres    false    197    3            �            1259    24605    Savings    TABLE     �   CREATE TABLE "Savings" (
    "SavingsId" text NOT NULL,
    "Remarks" text,
    "Debet" numeric,
    "Credit" numeric,
    "Tanggal" date,
    "ReferenceId" text,
    "UserId" text
);
    DROP TABLE public."Savings";
       public         postgres    false    3                      0    24613    Configuration 
   TABLE DATA               2   COPY "Configuration" ("Key", "Value") FROM stdin;
    public       postgres    false    199   L                 0    24661    Employee 
   TABLE DATA               ^   COPY "Employee" ("UserId", "Name", "BirthPlace", "BirthDate", "Address", "Phone") FROM stdin;
    public       postgres    false    200   �                 0    32839    Logins 
   TABLE DATA               1   COPY "Logins" ("Username", pass, id) FROM stdin;
    public       postgres    false    201   3       
          0    16397    Property 
   TABLE DATA               �   COPY "Property" ("Id", "PropertyName", "Remarks", "Year", "Value", "Description", "TransactionId", "ReferenceId", "Status", "UserId") FROM stdin;
    public       postgres    false    196   �                 0    24605    Savings 
   TABLE DATA               k   COPY "Savings" ("SavingsId", "Remarks", "Debet", "Credit", "Tanggal", "ReferenceId", "UserId") FROM stdin;
    public       postgres    false    198   �                  0    0    prop_id_seq    SEQUENCE SET     3   SELECT pg_catalog.setval('prop_id_seq', 13, true);
            public       postgres    false    197            �
           2606    24620     Configuration Configuration_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY "Configuration"
    ADD CONSTRAINT "Configuration_pkey" PRIMARY KEY ("Key");
 N   ALTER TABLE ONLY public."Configuration" DROP CONSTRAINT "Configuration_pkey";
       public         postgres    false    199            �
           2606    32848    Logins Logins_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY "Logins"
    ADD CONSTRAINT "Logins_pkey" PRIMARY KEY ("Username", pass);
 @   ALTER TABLE ONLY public."Logins" DROP CONSTRAINT "Logins_pkey";
       public         postgres    false    201    201            �
           2606    16404    Property Property_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY "Property"
    ADD CONSTRAINT "Property_pkey" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."Property" DROP CONSTRAINT "Property_pkey";
       public         postgres    false    196            �
           2606    24612    Savings Savings_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY "Savings"
    ADD CONSTRAINT "Savings_pkey" PRIMARY KEY ("SavingsId");
 B   ALTER TABLE ONLY public."Savings" DROP CONSTRAINT "Savings_pkey";
       public         postgres    false    198            �
           2606    32821    Employee UsersIdpkey 
   CONSTRAINT     U   ALTER TABLE ONLY "Employee"
    ADD CONSTRAINT "UsersIdpkey" PRIMARY KEY ("UserId");
 B   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "UsersIdpkey";
       public         postgres    false    200            �
           2606    32827    Property Property_User_Fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "Property"
    ADD CONSTRAINT "Property_User_Fkey" FOREIGN KEY ("UserId") REFERENCES "Employee"("UserId") ON UPDATE CASCADE ON DELETE CASCADE;
 I   ALTER TABLE ONLY public."Property" DROP CONSTRAINT "Property_User_Fkey";
       public       postgres    false    200    196    2700            �
           2606    32822    Savings savings_user_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "Savings"
    ADD CONSTRAINT savings_user_fkey FOREIGN KEY ("UserId") REFERENCES "Employee"("UserId") ON UPDATE CASCADE ON DELETE CASCADE;
 E   ALTER TABLE ONLY public."Savings" DROP CONSTRAINT savings_user_fkey;
       public       postgres    false    200    198    2700               S   x�N,��K/�L�N,���LM,�����+Ɉ�NI�����ˏ�r�-�ɯLM*2є����T���* f��qqq .�(�         t   x�s�-�720474200�-N-RN,)��	��prr�"�2��r)MģȘ3(3��81�45G!$1��)1/�4/�����D��P���ӻ(�8/������������ܐ+F��� �$         �   x��;1C��]����$��	� �O�y,��|�_���"Eq�V�������S�`dz�;�҄��'�W�&v�˰�Bt��lE� X�2
�K:�NmX�
aR�QI���2�/�Eâ�%��@��_�J�Ho������5�\/Ƙ?�'/�      
   �   x�e��j� ���S�	��s4��]F�A�ژ5eo_=�6s`�D�/��K�?�4�	���|H�oi�����ϵ�^�So4��"��0V�����Ut�Ɗ1�+��eƁs�0�%��������kH4�2��9��;�>���,g9�``�҃W��?�*�?g�$`�+�um��W��Sڐt	�0���5~V�H!�..�;?.~j2�@��t��I��J��:T��F)u+a�j         �   x�N,�72047426�700�,I-V0�r��3Ə$�kh�kl�Y��t�-�j��
F5�l�H������Ĕb�z�9��,-���5��e�YZ�����D���� ����ĬĤ��T��b���� ��>u     